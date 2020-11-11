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
    public partial class TaskMainForm : Form
    {
        MainForm main;
        public TaskMainForm(MainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            Form TR = new TaskRegistrationForm();
            TR.TopLevel = false;
            TR.Show();
            main.MainPanel.Controls.Clear();
            main.MainPanel.Controls.Add(TR);
        }
    }
}
