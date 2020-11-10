using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOVEROAD
{
    public partial class HRForm : Form
    {
        MainForm main;


        public HRForm(MainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HRForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            main.lastPanel.Dispose(); //이렇게 해야 메모리가 지워짐
            Paymentmanagement pay = new Paymentmanagement(this);
            pay.TopLevel = false;
            pay.Show();
            main.MainPanel.Controls.Clear();
            main.Controls.Add(pay);
        }

        private void btn_HR_Click(object sender, EventArgs e)
        {
            main.lastPanel.Dispose(); //이렇게 해야 메모리가 지워짐
            HRManagement.getInstance().TopLevel = false;
            HRManagement.getInstance().Show();
            main.MainPanel.Controls.Clear();
            main.Controls.Add(HRManagement.getInstance());
        }

        private void btn_department_Click(object sender, EventArgs e)
        {
            main.lastPanel.Dispose(); //이렇게 해야 메모리가 지워짐
            Departmanagement.getinstance().TopLevel = false;
            Departmanagement.getinstance().Show();
            main.MainPanel.Controls.Clear();
            main.Controls.Add(Departmanagement.getinstance());
        }
    }
}
