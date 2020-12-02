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
            int userdepart = main.me.depart;

            List<string> list = new List<string>();
            string query = "";

            if (userdepart == 1)
            {
                //인사인 경우
                query = "SELECT `u`.name,left(`s`.`date`,7) as `date`, sum(`s`.`basicPay`) as `basicPay`" +
                    ",SUM(`overtimePay`) as `overtimePay`,sum(`nighttimePay`) as `nighttimePay`" +
                    ",sum(`holidayPay`) as `holidayPay`,`d`.`totalPay`,`d`.`deduction`,`d`.`actualPay`" +
                    "FROM project.user as `u`,project.salary as `s`,project.deduction as `d` " +
                    "where left(`s`.`date`,7) = '"+date+"' and `u`.index = `s`.index and `u`.index = `d`.index and left(`s`.`date`, 7) = `d`.`date` " +
                    "group by `s`.index,left(`s`.`date`,7)";
            }
            else
            {
                //인사가 아닌경우
                query = "SELECT `u`.name,left(`s`.`date`,7) as `date`,SUM(`basicPay`) as `basicPay`" +
                ", SUM(`overtimePay`) as `overtimePay`,sum(`nighttimePay`) as `nighttimePay`,sum(`holidayPay`) as `holidayPay`" +
                ", `d`.`totalPay`,`d`.`deduction`,`d`.`actualPay` " +
                "FROM project.attendance_card as `ac`,project.salary as `s`" +
                ", project.user as `u`,project.deduction as `d` " +
                "WHERE left(`s`.`date`,7) = '" + date + "' and `s`.`index` = '" + userindex + "'" +
                " and `s`.`index` = `u`.`index` and `s`.`date` = `ac`.`date` and `u`.`id` = `ac`.`id` " +
                " and left(`s`.`date`,7) = `d`.`date` and `u`.`index` = `d`.`index` " +
                "GROUP BY left(`s`.`date`,7)";
            }
            list = (List<string>)DBConnetion.getInstance().Select(query, 80);

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
            string userid = main.me.id;
            DateTime dt = DateTime.Now;
            string today = dt.ToString("yyyy-MM-dd");

            string checkin_query = "SELECT * FROM project.attendance_card WHERE attendance_card.id = '" + userid + "' AND date = '" + today + "'";
            object checkin = DBConnetion.getInstance().Select(checkin_query, 28);

            string checkout_query = "SELECT * FROM project.attendance_card WHERE attendance_card.id = '" + userid + "' AND date2 = '" + today + "'";
            object checkout = DBConnetion.getInstance().Select(checkout_query, 28);

            if(checkin.Equals(1) && checkout.Equals(0)) // 현재 출근처리 되어있으며, 퇴근하지 않은 경우 추가수당 ui창 띄우기
            {
                // 초과근무 창 띄우고 다른행동 못하게 금지
                using (PaymentForm payment = new PaymentForm(main))
                {
                    if (payment.ShowDialog() == DialogResult.OK)
                    {
                        //refresh
                    }
                }
            }
            else // 출근처리가 안 되어있거나 이미 퇴근처리가 된 경우
            {
                MessageBox.Show("출근처리가 안 되어있거나 이미 퇴근처리 되었습니다.", "확인");
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            
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

        private void label_deductioninfo_Click(object sender, EventArgs e)
        {
            show_deductioninfo sd = new show_deductioninfo();
            sd.ShowDialog();
        }
    }
}
