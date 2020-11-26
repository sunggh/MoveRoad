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
            string ID = main.me.id; // 현재 접속중인 아이디
            string date = dateTimePicker1.Value.ToShortDateString();
            int select = comboBoxSelect.SelectedIndex;
            int time = Convert.ToInt32(textBoxTime.Text);
            int userIndex = Convert.ToInt32(main.me.index);

            // 로그인한 사용자가 출근기록이 있는지 확인
            query = "SELECT * FROM project.attendance_card " +
                "WHERE attendance_card.date = '" + date + "'";
            object check = DBConnetion.getInstance().Select(query, 8);

            if (check.Equals(1)) // 출근한 기록이 있을때
            {
                switch (select)
                {
                    case 0: // 연장근무
                        query = "UPDATE salary SET salary.overtimePay = '" + time * 15000 + "' " +
                            "WHERE salary.index = " + ID + " AND salary.date = '" + date + "'";
                        DBConnetion.getInstance().Update(query);
                        MessageBox.Show("연장근무 ( " + time + " ) 시간 등록이 완료되었습니다.", "신청 확인");
                        break;
                    case 1: // 야간근무
                        query = "UPDATE salary SET salary.nighttimePay = '" + time * 15000 + "' " +
                            "WHERE salary.index = " + ID + " AND salary.date = '" + date + "'";
                        DBConnetion.getInstance().Update(query);
                        MessageBox.Show("야간근무 ( " + time + " ) 시간 등록이 완료되었습니다.", "신청 확인");
                        break;
                    case 2: // 휴일근무
                        query = "UPDATE salary SET salary.holidayPay = '" + time * 15000 + "' " +
                            "WHERE salary.index = " + ID + " AND salary.date = '" + date + "'";
                        DBConnetion.getInstance().Update(query);
                        MessageBox.Show("휴일근무 ( " + time + " ) 시간 등록이 완료되었습니다.", "신청 확인");
                        break;
                }
            }
            if (check.Equals(0))
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
