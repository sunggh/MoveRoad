﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

// 출근부 구현 위 , 아래 버튼을 누르면 한달 추가, 감소 기능
// 출근버튼을 누르면 현재 시간을 기점으로 출근됨 = 출근버튼은 한번만 가능
// 퇴근버튼을 누르면 현재 시간을 기점으로 퇴근됨 = 출근버튼을 누르기 전, 퇴근버튼누른후 또 누르면 오류발생 MessageBox로 출력
// 조회버튼을 통해 월을 기준으로 출퇴근 시간, 일한시간 조회가능
// 일한시간은 퇴근시간-출근시간으로 시간을 기준으로 나눔

namespace MOVEROAD
{
    public partial class attendance_card : Form
    {
        
        MainForm main;
        public attendance_card(MainForm main)
        {
            InitializeComponent();
            Today.Text = DateTime.Now.ToString("yyyy-MM-dd");
            label2.Text = DateTime.Now.ToString("yyyy-MM");
            this.main = main;
           
        }
        private void buttonStart_Click(object sender, EventArgs e) // 출근버튼
        {
            string ID = main.me.id;  //현재접속중인 id값
            object start = DBConnetion.getInstance().Select("SELECT startTime FROM attendance_card " +
                "WHERE id='" + ID + "' and date ='" + DateTime.Now.ToString("yyyy-MM-dd") + "'", 5);  // 출근버튼을 클릭하였는지 확인

            //현재 접속중인 유저의 index값 가져오기
            UserInfo user;
            string get_index = "select * from `user` where `id` = '" + ID + "'";
            user = (UserInfo)DBConnetion.getInstance().Select(get_index, 0);

            if ((string)start == null)   // 출근버튼을 누르지 않았더라면
            {
                DBConnetion.getInstance().Insert("INSERT INTO attendance_card (id, date, startTime)" +
                        "VALUES('" + ID + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("HH:mm") + "')");

                //출근 시 salary 테이블에 기본값 배치
                string insert_base = "insert into salary(`index`,`date`,`basicPay`) values ('" + user.index + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "',0)";
                DBConnetion.getInstance().Insert(insert_base);

                MessageBox.Show("현재시각" + DateTime.Now.ToString("HH시 mm분") + "출근 완료");
            }
            else // 출근버튼을 눌렀다면
                MessageBox.Show("이미 출근 처리 되었습니다.");
        }

        private void buttonFinish_Click(object sender, EventArgs e) //퇴근 버튼
        {
            att_finish();
            check_overtime();
        }

        #region 퇴근 확인
        private void att_finish()
        {
            string ID = main.me.id;
            DateTime dt;
            dt = Convert.ToDateTime(Today.Text);
            string today = dt.ToString("yyyy-MM-dd");


            object start = DBConnetion.getInstance().Select("SELECT startTime FROM attendance_card " +
                "WHERE id='" + ID + "' and date!= 'null' and finishTime ='\"' ", 5); // 현재 id값이 출근을 눌렀는지 확인하기 위한 변수

            object finish = DBConnetion.getInstance().Select("SELECT finishTime FROM attendance_card " +
                "WHERE id='" + ID + "' and date!= 'null' and finishTime = '\"' ", 6); // 퇴근을 눌렀는지 확인

            if ((string)start != null && (string)finish == "\"") // 출근을 누르고 퇴근을 누르지 않았을때 (정상적인 상황)
            {// 만약 출근을 눌렀다면 정상적으로 종료시간 업데이트 종료시간 업데이트시 당일날만 업데이트 하기위해 like문으로 date의 값을 당일날이라는 조건으로 걸어둔다
                DBConnetion.getInstance().Update("UPDATE attendance_card SET date2='" + DateTime.Now.ToString("yyyy-MM-dd") + "' , finishTime ='" + DateTime.Now.ToString("HH:mm") + "' " +
                     "WHERE id='" + ID + "' and startTime != 'null' and  finishTime = '\"' ");

                MessageBox.Show("현재시각" + DateTime.Now.ToString("HH:mm") + "퇴근 완료");
                workTime(); // 퇴근과 동시에 업무시간 업데이트
            }
            if ((string)start == null) // 만약 출근버튼을 먼저 누르지 않았다면
                MessageBox.Show("먼저 출근버튼을 눌러주십시오.");

            if ((string)finish != "\"" && (string)finish != null)
                MessageBox.Show("이미 퇴근처리가 되었습니다.");
        }
        #endregion

        #region 퇴근 시 추가수당을 위한 계산
        private void check_overtime()
        {
            //현재 날짜
            DateTime dt = Convert.ToDateTime(Today.Text);
            string today = dt.ToString("yyyy-MM-dd");

            //현재 접속중인 아이디
            string ID = main.me.id;

            //현재 접속중인 유저의 index
            UserInfo user;
            string get_index = "select * from `user` where `id` = '" + ID + "'";
            user = (UserInfo)DBConnetion.getInstance().Select(get_index, 0);
            // user.index로 쓰기

            #region 주말일 시
            // 만약 주말이라면 아예 예외로하기
            string get_dayofweek = "select DAYOFWEEK(`date`) as `dayofweek` from project.attendance_card where `id` = '"+ID+"' and `date` = '" + today + "'";
            int dayofweek = Convert.ToInt32((string)DBConnetion.getInstance().Select(get_dayofweek, 85));
            #endregion

            if (dayofweek > 1 && dayofweek < 7) { //일요일=1, 토요일=7이 아닌경우

                // 비교를 위해 퇴근일 가져오기
                string get_sf_date = "select date2 from attendance_card where `id` = '" + ID + "' and `date` = '" + today + "'";
                string finishdate = (string)DBConnetion.getInstance().Select(get_sf_date, 89);

                // 출/퇴근일이 같을때 22시 이후인지 알기위함
                string get_ot_date = "SELECT TIME_TO_SEC(timediff(`finishTime`,'00:00')) as `sectime` FROM project.attendance_card " +
                    "where `id` = '" + ID + "' and `date` = '" + today+"'";
                int check_ot = Convert.ToInt32(DBConnetion.getInstance().Select(get_ot_date, 86));


                // if 22시-출근시간>=10시간 , 10시간 기본급
                // else if 22시-출근시간<10시간, 그 시간만큼 기본급을 위한 계산
                string up_night = "SELECT TIME_TO_SEC(timediff('22:00',`startTime`)) as `sectime` " +
                "FROM project.attendance_card " +
                "where `id` = '" + ID + "' and `date` = '" + today + "'";
                // 10시에서 뺀 시간
                int get_nighttime_sec = Convert.ToInt32((string)DBConnetion.getInstance().Select(up_night, 86));


                // 출근일과 퇴근일이 다르다면 야간근무임, 그리고 퇴근일이 같아도 22시 이상이면 야간근무
                if (!today.Equals(finishdate) || (today.Equals(finishdate) &&check_ot>=79200))
                {
                    // 초과근무면서 야간근무 겹칠때 ( 야간이 되기전에 이미 10시간이 넘을때 )
                    if (get_nighttime_sec > 36000)
                    {
                        string update_basicpay = "update salary set `basicpay` = 100000 where `index` = '" + user.index + "' and `date` = '" + today+"'";
                        DBConnetion.getInstance().Update(update_basicpay);
                    }
                    else // 겹치지만 야간되기전에 10시간근무 넘은건 아닐때 10시까지만 계산
                    {
                        string update_basicpay = "update salary set `basicpay` = '" + (get_nighttime_sec / 3600) * 10000 + "' where `index` = '"+user.index+"' and `date` = '" + today + "'";
                        DBConnetion.getInstance().Update(update_basicpay);
                    }
                }
                // 출근일과 퇴근일이 같으면서 야간근무가 아닌경우
                else if (today.Equals(finishdate) && check_ot < 79200)
                {
                    string get_worktimesec = "select TIME_TO_SEC(timediff(`finishTime`,`startTime`)) as `sectime` FROM attendance_card " +
                            "where `id` = '" + ID + "' and `date` = '" + today + "'";
                    int worktime = Convert.ToInt32((string)DBConnetion.getInstance().Select(get_worktimesec, 86));

                    // 어차피 야간은 아닐테니 근무시간이 10시간 넘으면 초과근무
                    if (worktime > 36000)
                    {
                        string update_basicpay = "update salary set `basicpay` = 100000 where `index` = '" + user.index + "' and `date` = '" + today + "'";
                        DBConnetion.getInstance().Update(update_basicpay);
                    }
                    else //야간도 초과근무도 아니라면
                    {
                        string update_basicpay = "update salary set `basicpay` = '" + (worktime / 3600) * 10000 + "' " +
                            "where `index` = '" + user.index + "' and `date` = '" + today + "'";
                        DBConnetion.getInstance().Update(update_basicpay);
                    }
                }
            }
        }
        #endregion

        private void workTime() // 업무시간 업데이트 (시작시간과 종료시간값을 받아와 DateTime형식으로 변환후 TimeSpan으로 두값을 빼준후 시간을 얻어옴 얻어온 시간값을 Int 형식으로 Convert후 DB에 저장)
        {
            DateTime dt;
            dt = Convert.ToDateTime(Today.Text);
            string today = dt.ToString("yyyy-MM-dd");
            string id = main.me.id;

          
             object start = DBConnetion.getInstance().Select("SELECT startTime FROM attendance_card WHERE id='" + id + "' and startTime != 'null' and finishTime != 'null' and date like '" + today + "%'" ,5);
             object finish = DBConnetion.getInstance().Select("SELECT finishTime FROM attendance_card WHERE id='" + id + "' and startTime != 'null' and  date like '" + today + "%'", 6);

            DateTime dt2 = Convert.ToDateTime(start);
            DateTime dt3 = Convert.ToDateTime(finish);

            TimeSpan ts;
            
            ts = dt3 - dt2;
            

            string hours= ts.ToString("hh");
            int worktime = Convert.ToInt32(hours);  
          

            DBConnetion.getInstance().Update("UPDATE attendance_card SET workTime ='"+worktime+"' " +
                    "WHERE id='" + id + "' and startTime != 'null' and finishTime != 'null' and date like '" + today + "%'"); 
            

        }

        private void buttonInc_Click(object sender, EventArgs e) // 한달 추가
        {
            DateTime dt;
            dt = Convert.ToDateTime(label2.Text);
            label2.Text = dt.AddMonths(1).ToString("yyyy-MM");
        }

        private void buttonDec_Click(object sender, EventArgs e) // 한달 감소
        {
            DateTime dt;
            dt = Convert.ToDateTime(label2.Text);
            label2.Text = dt.AddMonths(-1).ToString("yyyy-MM");
        }

        private void buttonRead_Click(object sender, EventArgs e) // 출근부 조회
        {
            DateTime dt;
            dt = Convert.ToDateTime(label2.Text);
            string a = dt.ToString("yyyy-MM");

            // 출근부를 조회 현재 년-월을 like문으로 설정하여 년-월 별로 출근부를 조회 할수 있음 
            string query = "SELECT DATE_FORMAT(date, '%d') AS 출근일, name AS 사용자이름,startTime AS 출근시간 ,DATE_FORMAT(date2, '%d') AS 퇴근일,finishTime AS 퇴근시간, workTime AS 근무시간"
                       + " FROM attendance_card join user on attendance_card.id = user.id Where user.id='" + main.me.id + "' and date like '" + a + "%' ";
            object tb = DBConnetion.getInstance().Select(query, 70);
            dataGridView1.DataSource = tb;
        }
    }
}