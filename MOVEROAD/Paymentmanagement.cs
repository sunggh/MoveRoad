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
    public partial class Paymentmanagement : Form
    {
        MainForm main;

        public Paymentmanagement(MainForm main)
        {
            InitializeComponent();
            this.main = main;
            label2.Text = DateTime.Now.ToString("yyyy-MM");
            set_pay_listview(label2.Text);
        }

        private void set_pay_listview(string date)
        {
            //현재 접속중인 유저 index (접속한 아이디 유저의 급여표기 위함)
            int userindex = main.me.index;

            string query = "SELECT user.name,left(salary.`date`,7) as `date`,SUM(`basicPay`) as basicPay,`overtimePay`,`nighttimePay`,`holidayPay`,`totalPay`,`deduction`,`actualPay` " +
                "FROM project.attendance_card,project.salary,project.user " +
                "where left(salary.`date`,7) = '"+date+"' and salary.`index` = '" + userindex+"' " +
                    "and salary.`index` = user.`index` and salary.`date` = attendance_card.`date` " +
                "group by left(salary.`date`,7)";
            
            List<string> list;
            list = (List<string>)DBConnetion.getInstance().Select(query,80);

            lv_rivise.Items.Clear();
            lv_rivise.BeginUpdate();
            ListViewItem item;

            for (int i = 0; i < list.Count; i = i + 9)
            {
                item = new ListViewItem(list[i]);
                item.SubItems.Add(list[i + 1]);
                item.SubItems.Add(list[i + 2]);
                item.SubItems.Add(list[i + 3]);
                item.SubItems.Add(list[i + 4]);
                item.SubItems.Add(list[i + 5]);
                item.SubItems.Add(list[i + 6]);
                item.SubItems.Add(list[i + 7]);
                item.SubItems.Add(list[i + 8]);
                lv_rivise.Items.Add(item);
            }
            lv_rivise.EndUpdate();
        }

        private void btn_overtime_Click(object sender, EventArgs e)
        {
            // 초과근무 창 띄우기
            using(PaymentForm payment = new PaymentForm(main))
            {
                if(payment.ShowDialog() == DialogResult.OK)
                {
                    //refresh
                }
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            //급여 데이터 그리드뷰 새로고침
            set_pay_listview(label2.Text);
        }

        // 달 추가
        private void buttonInc_Click(object sender, EventArgs e)
        {
            DateTime dt;
            dt = Convert.ToDateTime(label2.Text);
            label2.Text = dt.AddMonths(1).ToString("yyyy-MM");
            set_pay_listview(label2.Text);
        }

        private void buttonDec_Click(object sender, EventArgs e)
        {
            DateTime dt;
            dt = Convert.ToDateTime(label2.Text);
            label2.Text = dt.AddMonths(-1).ToString("yyyy-MM");
            set_pay_listview(label2.Text);
        }
    }
}
