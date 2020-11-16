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
    public partial class attendance_card : Form
    {
        MainForm main;
        public attendance_card(MainForm main)
        {
            InitializeComponent();
            Today.Text = DateTime.Now.ToString("yyyy년 MM월 dd일");
            this.main = main;
          
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string a = main.me.id;  //현재접속중인 id값
            object b = DBConnetion.getInstance().Select("SELECT id FROM user WHERE id='" + a + "'", 4);  // 현재 로그인 중인 id값 읽어오기

           
            DBConnetion.getInstance().Insert("INSERT INTO attendance_card (id, date, startTime)" +
                    "VALUES('" + a + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("HH시mm분") + "')");

            MessageBox.Show("현재시각" + DateTime.Now.ToString("HH시 mm분") + "출근 완료");
          


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = main.me.id;
            object b = DBConnetion.getInstance().Select("SELECT id FROM attendance_card WHERE id='" + a + "' and startTime != 'null' ", 4); // 현재 id값이 출근은 눌렀는지 확인하기 위한 변수

            if ((string)b != null)
            {// 만약 출근을 눌렀다면 정상적으로 종료시간 업데이트
                DBConnetion.getInstance().Update("UPDATE attendance_card SET finishTime ='" + DateTime.Now.ToString("HH시mm분") + "' " +
                    "WHERE id='" + a + "' and startTime != 'null' ");

                MessageBox.Show("현재시각" + DateTime.Now.ToString("HH시 mm분") + "퇴근 완료");
            }
            else // 만약 출근버튼을 먼저 누르지 않았다면
                MessageBox.Show("먼저 출근버튼을 눌러주십시오.");


        }
    }
}
