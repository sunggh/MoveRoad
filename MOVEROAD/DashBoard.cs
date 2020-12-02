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
    public partial class DashBoard : Form
    {
        UserInfo user;
        MainForm main;
        public DashBoard(UserInfo user, MainForm main)
        {
            string[] grade = { "사장", "부서장", "직원" };
            this.main = main;
            Dictionary<int ,string> departName = new Dictionary<int, string>();
            foreach(var depart in this.main.departments)
            {
                departName.Add(depart.id,depart.name);
            }
            InitializeComponent();
            
            this.nameLabel.Text = user.name;
            this.ageLabel.Text = user.age + " 살";
            this.departLabel.Text = departName[user.depart];
            this.gradeLabel.Text = grade[user.grade];
            this.user = user;
            
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            main.TransparencyKey = Color.Gray;
            main.Opacity = 0.5;
            using (UserSetting us = new UserSetting(this.user))
            {
                us.ShowDialog();
            }
            
            main.Opacity = 1;
        }

       
    }
}
