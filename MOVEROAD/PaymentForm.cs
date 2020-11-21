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

            string date = dateTimePicker1.Value.ToShortDateString();
            int select = comboBoxSelect.SelectedIndex;
            int time = Convert.ToInt32(textBoxTime.Text);
            int userIndex = Convert.ToInt32(main.me.index);

            query = "SELECT salary_overtime.date FROM project.salary_overtime WHERE salary_overtime.userIndex = " + userIndex;
            object check = DBConnetion.getInstance().Select(query, 8);

            if (check.Equals(0)) // 초과근무 기록이 존재하지 않을 때
            {
                switch (select)
                {
                    case 0: // 연장근무
                        query = "INSERT INTO `salary_overtime` (`userIndex`, `overtime`, `date`)" +
                            "VALUES (" + userIndex + ", " + time + ", " + date + ")";
                        DBConnetion.getInstance().Update(query);
                        MessageBox.Show("연장근무 ( " + time + " ) 시간 등록이 완료되었습니다.", "신청 확인");
                        break;
                    case 1: // 야간근무
                        query = "INSERT INTO `salary_overtime` (`userIndex`, `nighttime`, `date`)" +
                            "VALUES (" + userIndex + ", " + time + ", " + date + ")";
                        DBConnetion.getInstance().Update(query);
                        MessageBox.Show("야간근무 ( " + time + " ) 시간 등록이 완료되었습니다.", "신청 확인");
                        break;
                    case 2: // 휴일근무
                        query = "INSERT INTO `salary_overtime` (`userIndex`, `holidaytime`, `date`)" +
                            "VALUES (" + userIndex + ", " + time + ", " + date + ")";
                        DBConnetion.getInstance().Update(query);
                        MessageBox.Show("휴일근무 ( " + time + " ) 시간 등록이 완료되었습니다.", "신청 확인");
                        break;
                }
            }

            if (check.Equals(1)) // 기존에 초과근무 했던 기록이 존재할 때
            {
                switch (select)
                {
                    case 0: // 연장근무
                        query = "UPDATE ";
                        DBConnetion.getInstance().Update(query);
                        MessageBox.Show("연장근무 ( " + time + " ) 시간 등록이 완료되었습니다.", "신청 확인");
                        break;
                    case 1: // 야간근무
                        query = "UPDATE ";
                        DBConnetion.getInstance().Update(query);
                        MessageBox.Show("야간근무 ( " + time + " ) 시간 등록이 완료되었습니다.", "신청 확인");
                        break;
                    case 2: // 휴일근무
                        query = "UPDATE ";
                        DBConnetion.getInstance().Update(query);
                        MessageBox.Show("휴일근무 ( " + time + " ) 시간 등록이 완료되었습니다.", "신청 확인");
                        break;
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
