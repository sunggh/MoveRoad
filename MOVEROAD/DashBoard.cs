﻿using System;
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
        public DashBoard(UserInfo user)
        {
            string[] grade = { "직원", "부서장", "사장" };
            string[] depart = { "인사팀", "개발팀", "홍보팀" };
            InitializeComponent();
            this.nameLabel.Text = user.name;
            this.ageLabel.Text = user.age + " 살";
            this.departLabel.Text = depart[user.depart-1];
            this.gradeLabel.Text = grade[user.grade-1];
            this.user = user;
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            using (UserSetting us = new UserSetting(this.user))
            {
                us.ShowDialog();

            }
        }
    }
}
