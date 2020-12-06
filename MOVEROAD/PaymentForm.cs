using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOVEROAD
{
    public partial class PaymentForm: Form
    {
        MainForm main;
        
        public PaymentForm(MainForm main, DateTime time)
        {
            InitializeComponent();
            testTime.Value = time;
            testTime.Update();
            Today.Text = testTime.Value.ToString("yyyy년MM월 dd일 HH시 mm분 ddd요일");
            this.main = main;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(textBoxTime.Text == "" || textBoxTime.Text == "(시간 입력)")
            {
                MessageBox.Show("시간을 입력해 주세요.", "신청 불가");
                return;
            }

            try
            {
                DateTime dt = Convert.ToDateTime(Today.Text);
                string today = testTime.Value.ToString("yyyy-MM-dd"); // 오늘 날짜dt.ToString
                int select = comboBoxSelect.SelectedIndex; // 초과근무 선택
                int time = Convert.ToInt32(textBoxTime.Text); // 근무시간
                int userIndex = Convert.ToInt32(main.me.index); // 현재 접속중인 index 값
                string ID = main.me.id; // 현재 접속중인 ID

                //현재 접속중인 유저의 정보 받아오기
                UserInfo user;
                string get_index = "select * from `user` where `account_id` = '" + ID + "'";
                user = (UserInfo)DBConnetion.getInstance().Select(get_index, 0);

                // 휴일근무 - 오늘 요일값 받아오기
                string dayofweek = testTime.Value.ToString("ddd");

                // 야간근무 - 현재 시간을 받아와서 22시 이후인지 알아보기
                string dthour = testTime.Value.ToString("HH");
                int nowhour = Convert.ToInt32(dthour);

                // 초과근무 - 출근시간과 현재시간을 받아와서 10시간 이상인지 알아보기
                string dttime = testTime.Value.ToString("HH:mm");
                string overtime_check_query = "SELECT time_to_sec(timediff('" + dttime + "', attendance_card.startTime)) AS 'sectime' " +
                    "FROM project.attendance_card " +
                    "WHERE attendance_card.user_id = '" + ID + "' AND attendance_card.date = '" + today + "'";
                int overtime_sec = Convert.ToInt32((string)DBConnetion.getInstance().Select(overtime_check_query, 86));

                // 로그인한 사용자가 출근기록이 있는지 확인
                string check_login_query = "SELECT * FROM project.salary " +
                    "WHERE salary.date = '" + today + "' AND salary.user_index = " + userIndex;
                object check = DBConnetion.getInstance().Select(check_login_query, 28);

                if (check.Equals(1)) // 출근한 기록이 있을 때
                {
                    switch (select)
                    {
                        case 0: // 연장근무
                            if (overtime_sec >= 36000) // (현재시간 - 출근시간)이 10시간 이상인 경우 
                            {
                                string overtime_query = "UPDATE salary SET salary.overtimePay = '" + time * 15000 + "' " +
                                "WHERE salary.user_index = " + userIndex + " AND salary.date = '" + today + "'";
                                DBConnetion.getInstance().Update(overtime_query);

                                string total_query = "UPDATE project.salary SET totalPay = basicPay+overtimePay+nighttimePay+holidayPay " +
                                    "WHERE salary.user_index = '" + userIndex + "' AND salary.date = '" + today + "'";
                                DBConnetion.getInstance().Update(total_query); // total 갱신

                                MessageBox.Show("연장근무 ( " + time + " ) 시간 등록이 완료되었습니다.", "신청 확인");
                                break;
                            }
                            else // 근무시간이 10시간 미만인 경우
                            {
                                MessageBox.Show("연장근무 가능 시간이 아닙니다.", "신청 불가");
                                break;
                            }

                        case 1: // 야간근무
                            if ((nowhour >= 22 && nowhour <= 24) || nowhour <= 4) // 야간(22시-24시, 04시 이전)인 경우
                            {
                                string nighttime_query = "UPDATE salary SET salary.nighttimePay = '" + time * 15000 + "' " +
                                "WHERE salary.user_index = " + userIndex + " AND salary.date = '" + today + "'";
                                DBConnetion.getInstance().Update(nighttime_query);

                                string total_query = "UPDATE project.salary SET totalPay = basicPay+overtimePay+nighttimePay+holidayPay " +
                                    "WHERE salary.user_index = '" + userIndex + "' AND salary.date = '" + today + "'";
                                DBConnetion.getInstance().Update(total_query); // total 갱신

                                MessageBox.Show("야간근무 ( " + time + " ) 시간 등록이 완료되었습니다.", "신청 확인");
                                break;
                            }
                            else // 주간인 경우
                            {
                                MessageBox.Show("야간근무 시간이 아닙니다.", "신청 불가");
                                break;
                            }
                        case 2: // 휴일근무
                            if (dayofweek == "일" || dayofweek == "토") // 주말인 경우
                            {
                                string holiday_query = "UPDATE salary SET salary.holidayPay = '" + time * 15000 + "' " +
                                "WHERE salary.user_index = " + userIndex + " AND salary.date = '" + today + "'";
                                DBConnetion.getInstance().Update(holiday_query);

                                string total_query = "UPDATE project.salary SET totalPay = basicPay+overtimePay+nighttimePay+holidayPay " +
                                    "WHERE salary.user_index = '" + userIndex + "' AND salary.date = '" + today + "'";
                                DBConnetion.getInstance().Update(total_query); // total 갱신

                                MessageBox.Show("휴일근무 ( " + time + " ) 시간 등록이 완료되었습니다.", "신청 확인");
                                break;
                            }
                            else // 평일인 경우
                            {
                                MessageBox.Show("오늘은 휴일이 아닙니다.", "신청 불가");
                                break;
                            }
                    }
                    get_deduction(user, today); // deduction 갱신
                }
                if (check.Equals(0)) // 출근한 기록이 없을 때
                {
                    MessageBox.Show("먼저 출근버튼을 눌러주십시오.");
                }
            }
            catch
            {
                MessageBox.Show("올바르게 입력하여 주십시오.", "입력 오류");
            }
        }

        //공제+실급여 계산
        private void get_deduction(UserInfo user, string today)
        {
            //달별 계산을위해 today 달별로 자르기
            today = DateTime.ParseExact(today, "yyyy-MM-dd", null).ToString("yyyy-MM");

            //먼저 deduction 테이블에 달별 실급여 정리하기
            string set_dedcution = "SELECT left(`date`,7) as `month`, sum(salary.`totalPay`) as `totalPay` " +
                "FROM project.salary " +
                "where salary.`user_index` = '"+user.index+"' and left(`date`,7) = '" + today + "' " +
                "group by `month`";

            List<string> list = (List<string>)DBConnetion.getInstance().Select(set_dedcution, 83);

            string get_query = "SELECT * FROM project.deduction where `date` = '" + today + "'";
            string get_date = (string)DBConnetion.getInstance().Select(get_query, 84);

            //deduction 테이블 달별, 실급여, 유저 삽입(나머지 값 0)
            //만약 테이블에 같은 달이 입력되어 있지 않다면
            if (get_date.Equals(""))
            {
                string insert_query = "insert into deduction(`user_index`,`date`,`totalPay`) values('" + user.index + "','" + list[0] + "','" + list[1] + "')";
                DBConnetion.getInstance().Insert(insert_query);
            }
            else
            {
                string update_query = "update deduction set `user_index` = '" + user.index + "', `date` = '" + list[0] + "', `totalPay` =  '" + list[1] + "' " +
                    "where `index` = '" + user.index + "' and `date` = '" + list[0] + "'";
                DBConnetion.getInstance().Insert(update_query);
            }

            string query = "select `totalPay` from deduction where `user_index` = '" + user.index + "' and `date` = '" + list[0] + "'";
            int totalPay = Convert.ToInt32((string)DBConnetion.getInstance().Select(query, 82)) / 1000 * 1000;
            //1000원미만 절사하기

            double health_insurance = ((totalPay * 0.0335) / 10 * 10);//건강보험-건강보험
            double health_insurance2 = (health_insurance * 0.1025) / 10 * 10;//건강보험-장기요양보험
            double total_health_insurance = health_insurance + health_insurance2;//건강+장기요양보험

            double pension; //연금보험료
            //만약 totalpay가 32만원미만이면 32만원으로, 503만원 초과면 503만원으로 계산하기
            if (totalPay > 14400 && totalPay < 320000)
            {
                pension = 14400;
            }
            else if (totalPay >= 0 && totalPay <= 14400)
            {
                pension = 0;
            }
            else if (totalPay > 5030000)
            {
                pension = 226350;
            }
            else
            {
                pension = (totalPay * 0.045) / 10 * 10;
            }

            double unemployment = (totalPay * 0.008) / 10 * 10;//실업

            double total_deduction = health_insurance + pension + unemployment;//총 공제가격

            double actualPay = totalPay - total_deduction;//총급여(실급여-공제)

            //deduction 테이블에 공제금 세개 넣기
            string update = "update deduction set health_insurance = '" + total_health_insurance + "', pension = '" + pension + "'" +
                ", unemployment = '" + unemployment + "' " +
                "where `user_index` = '" + user.index + "' and `date` = '" + list[0] + "'";
            DBConnetion.getInstance().Update(update);

            // 다시 salary 테이블에 넣기(공제 총액과 총급여 계산)
            string update_salary = "update deduction set `deduction` = '" + total_deduction + "', `actualPay` = '" + actualPay + "' " +
                "where `user_index` = '" + user.index + "' and `date` = '" + list[0] + "'";
            DBConnetion.getInstance().Update(update_salary);

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBoxTime_Click(object sender, EventArgs e)
        {
            textBoxTime.Text = "";
        }

        private void textBoxTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void testTime_ValueChanged(object sender, EventArgs e)
        {
            Today.Text = testTime.Value.ToString("yyyy년MM월 dd일 HH시 mm분 ddd요일");
        }
    }
}
