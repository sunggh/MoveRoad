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
    public partial class HRManagement : Form
    {
        MainForm main;
        
        public HRManagement(MainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void buttonAddUsers_Click(object sender, EventArgs e)
        {
            // AddUsers 창으로 넘어가기
            main.lastPanel.Dispose();
            AddUsers addUsers = new AddUsers();
            addUsers.TopLevel = false;
            addUsers.Show();
            main.lastPanel = addUsers;
            main.MainPanel.Controls.Clear();
            main.MainPanel.Controls.Add(addUsers);
        }

        private void buttonSearchUsers_Click(object sender, EventArgs e)
        {
            // SearchUsers 창으로 넘어가기
        }

        private void buttonEditUsers_Click(object sender, EventArgs e)
        {
            // EditUsers 창으로 넘어가기
        }
    }
}
