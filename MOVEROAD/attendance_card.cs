using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
                DBConnetion.getInstance().Update("UPDATE attendance_card SET finishTime ='" + DateTime.Now.ToString("HH시 mm분") + "' " +
                    "WHERE id='" + a + "' and startTime != 'null' ");

                MessageBox.Show("현재시각" + DateTime.Now.ToString("HH시 mm분") + "퇴근 완료");
            }
            else // 만약 출근버튼을 먼저 누르지 않았다면
                MessageBox.Show("먼저 출근버튼을 눌러주십시오.");


        }

        private void button3_Click(object sender, EventArgs e) // 한달추가
        {
            DateTime dt;
            dt = Convert.ToDateTime(label2.Text);      
            label2.Text = dt.AddMonths(1).ToString("yyyy-MM");

        }

        private void button4_Click(object sender, EventArgs e) //한달감소
        {
            DateTime dt;
            dt = Convert.ToDateTime(label2.Text);
            label2.Text = dt.AddMonths(-1).ToString("yyyy-MM");
        }

        private void button5_Click(object sender, EventArgs e) //출근부 조회
        {
            DateTime dt;
            dt = Convert.ToDateTime(label2.Text);
            string a = dt.ToString("yyyy-MM");
            


            // 출근부를 조회 현재 년-월을 like문으로 설정하여 년-월 별로 출근부를 조회 할수 있음 
            DataTable tb = DBConnetion.getInstance().getDBTable("SELECT DATE_FORMAT(date, '%d') AS 일, name AS 사용자이름,startTime AS 출근시간 ,finishTime AS 퇴근시간"
                       + " FROM attendance_card join user on attendance_card.id = user.id Where user.id='" + main.me.id + "' and date like '" + a + "%' " );
            dataGridView1.DataSource = tb;

            
        }

       
    }
}
