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
        
        public PaymentForm(MainForm main)
        {
            InitializeComponent();
            Today.Text = DateTime.Now.ToString("yyyy년MM월 dd일 HH시 mm분 ddd요일");
            this.main = main;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DateTime dt = Convert.ToDateTime(Today.Text);
            string today = dt.ToString("yyyy-MM-dd"); // 오늘 날짜
            int select = comboBoxSelect.SelectedIndex; // 초과근무 선택
            int time = Convert.ToInt32(textBoxTime.Text); // 근무시간
            int userIndex = Convert.ToInt32(main.me.index); // 현재 접속중인 index 값
            string ID = main.me.id; // 현재 접속중인 ID

            // 휴일근무 - 오늘 요일값 받아오기
            string dayofweek = dt.ToString("ddd");

            // 야간근무 - 현재 시간을 받아와서 22시 이후인지 알아보기
            string dthour = dt.ToString("HH");
            int nowhour = Convert.ToInt32(dthour);

            // 초과근무 - 출근시간과 현재시간을 받아와서 10시간 이상인지 알아보기
            string dttime = dt.ToString("HH:mm");
            string overtime_check_query = "SELECT time_to_sec(timediff('" + dttime + "', attendance_card.startTime)) AS 'sectime' " +
                "FROM project.attendance_card " +
                "WHERE attendance_card.id = '" + ID + "' AND attendance_card.date = '" + today + "'";
            int overtime_sec = Convert.ToInt32((string)DBConnetion.getInstance().Select(overtime_check_query, 86));

            // 로그인한 사용자가 출근기록이 있는지 확인
            string check_login_query = "SELECT * FROM project.salary " +
                "WHERE salary.date = '" + today + "' AND salary.index = " + userIndex;
            object check = DBConnetion.getInstance().Select(check_login_query, 8);

            if (check.Equals(1)) // 출근한 기록이 있을 때
            {
                switch (select)
                {
                    case 0: // 연장근무
                        if(overtime_sec >= 36000) // (현재시간 - 출근시간)이 10시간 이상인 경우 
                        {
                            string overtime_query = "UPDATE salary SET salary.overtimePay = '" + time * 15000 + "' " +
                            "WHERE salary.index = " + userIndex + " AND salary.date = '" + today + "'";
                            DBConnetion.getInstance().Update(overtime_query);

                            string total_query = "UPDATE project.salary SET totalPay = basicPay+overtimePay+nighttimePay+holidayPay " +
                                "WHERE salary.index = '" + userIndex + "' AND salary.date = '" + today + "'";
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
                        if(nowhour >= 22 && nowhour <= 24) // 야간(22시-24시)인 경우
                        {
                            string nighttime_query = "UPDATE salary SET salary.nighttimePay = '" + time * 15000 + "' " +
                            "WHERE salary.index = " + userIndex + " AND salary.date = '" + today + "'";
                            DBConnetion.getInstance().Update(nighttime_query);

                            string total_query = "UPDATE project.salary SET totalPay = basicPay+overtimePay+nighttimePay+holidayPay " +
                                "WHERE salary.index = '" + userIndex + "' AND salary.date = '" + today + "'";
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
                        if(dayofweek == "일" || dayofweek == "토") // 주말인 경우
                        {
                            string holiday_query = "UPDATE salary SET salary.holidayPay = '" + time * 15000 + "' " +
                            "WHERE salary.index = " + userIndex + " AND salary.date = '" + today + "'";
                            DBConnetion.getInstance().Update(holiday_query);

                            string total_query = "UPDATE project.salary SET totalPay = basicPay+overtimePay+nighttimePay+holidayPay " +
                                "WHERE salary.index = '" + userIndex + "' AND salary.date = '" + today + "'";
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
            }
            if (check.Equals(0)) // 출근한 기록이 없을 때
            {
                MessageBox.Show("먼저 출근버튼을 눌러주십시오.");
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
