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
        }
    }
}
