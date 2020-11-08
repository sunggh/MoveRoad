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
    public partial class HRForm : Form
    {
        public HRForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HRForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            //lastPanel.Dispose();
            PaymentForm.getinstance().TopLevel = false;
            PaymentForm.getinstance().Show();
            MainForm.getinstance_().MainPanel.Controls.Clear();
            MainForm.getinstance_().Controls.Add(PaymentForm.getinstance());
        }
    }
}
