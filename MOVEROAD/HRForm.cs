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

        private void btn_HR_Click(object sender, EventArgs e)
        {
            if(main.me.depart != 1)
            {
                MessageBox.Show("접근 제한", "Error");
                return;
            }

            main.lastPanel.Dispose(); //이렇게 해야 메모리가 지워짐
            HRManagement hRManagement = new HRManagement(this.main);
            hRManagement.TopLevel = false;
            hRManagement.Show();
            main.lastPanel = hRManagement;
            main.MainPanel.Controls.Clear();
            main.MainPanel.Controls.Add(hRManagement);
        }

        private void btn_department_Click(object sender, EventArgs e)
        {
            if (main.me.depart != 1)
            {
                MessageBox.Show("접근 제한", "Error");
                return;
            }

            main.lastPanel.Dispose(); //이렇게 해야 메모리가 지워짐
            Departmanagement departmanagement = new Departmanagement(main);
            departmanagement.TopLevel = false;
            departmanagement.Show();
            main.lastPanel = departmanagement;
            main.MainPanel.Controls.Clear();
            main.MainPanel.Controls.Add(departmanagement);
        }

        private void btn_payment_Click(object sender, EventArgs e)
        {
            main.lastPanel.Dispose(); //이렇게 해야 메모리가 지워짐
            Paymentmanagement pay = new Paymentmanagement(main);
            pay.TopLevel = false;
            pay.Show();
            main.lastPanel = pay;
            main.MainPanel.Controls.Clear();
            main.MainPanel.Controls.Add(pay);
        }
    }
}
