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
        
        int overtime; // 연장근무
        int nightOvertime; // 야간근무
        int holidayWork; // 휴일근무

        public PaymentForm(MainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int select = comboBoxSelect.SelectedIndex;
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
