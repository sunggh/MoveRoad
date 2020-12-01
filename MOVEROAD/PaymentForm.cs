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
            this.main = main;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string query = "";
            string today = dateTimePicker1.Value.ToShortDateString(); // 현재 날짜
            int select = comboBoxSelect.SelectedIndex; // 초과근무 선택
            int time = Convert.ToInt32(textBoxTime.Text); // 근무시간
            int userIndex = Convert.ToInt32(main.me.index); // 현재 접속중인 index 값
            string ID = main.me.id; // 현재 접속중인 ID

            // 주말 구분을 위해 오늘 요일값 받아오기 (일~토, 1~7)
            string get_dayofweek = "SELECT DAYOFWEEK(attendance_card.date) AS 'dayofweek' FROM project.attendance_card " +
                "WHERE attendance_card.id = '" + ID + "' AND attendance_card.date = '" + today + "'";
            int dayofweek = Convert.ToInt32((string)DBConnetion.getInstance().Select(get_dayofweek, 85));

            // 로그인한 사용자가 출근기록이 있는지 확인
            query = "SELECT * FROM project.salary " +
                "WHERE salary.date = '" + today + "' AND salary.index = " + userIndex;
            object check = DBConnetion.getInstance().Select(query, 8);

            if (check.Equals(1)) // 출근한 기록이 있을 때
            {
                switch (select)
                {
                    case 0: // 연장근무
                        query = "UPDATE salary SET salary.overtimePay = '" + time * 15000 + "' " +
                            "WHERE salary.index = " + userIndex + " AND salary.date = '" + today + "'";
                        DBConnetion.getInstance().Update(query);
                        MessageBox.Show("연장근무 ( " + time + " ) 시간 등록이 완료되었습니다.", "신청 확인");
                        break;
                    case 1: // 야간근무
                        query = "UPDATE salary SET salary.nighttimePay = '" + time * 15000 + "' " +
                            "WHERE salary.index = " + userIndex + " AND salary.date = '" + today + "'";
                        DBConnetion.getInstance().Update(query);
                        MessageBox.Show("야간근무 ( " + time + " ) 시간 등록이 완료되었습니다.", "신청 확인");
                        break;
                    case 2: // 휴일근무
                        if(dayofweek == 1 || dayofweek == 7) // 주말인 경우
                        {
                            query = "UPDATE salary SET salary.holidayPay = '" + time * 15000 + "' " +
                            "WHERE salary.index = " + userIndex + " AND salary.date = '" + today + "'";
                            DBConnetion.getInstance().Update(query);
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
