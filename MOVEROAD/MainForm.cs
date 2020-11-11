﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOVEROAD
{
    public partial class MainForm : Form
    {
        private Point mousePoint;
        public UserInfo me { get; set; }
        private Form lastPanel;
        public MainForm(UserInfo me)
        {
            this.me = me;
            InitializeComponent();
            DashBoard dashBoard = new DashBoard(me, this);
            dashBoard.TopLevel = false;
            dashBoard.Show();
            this.MainPanel.Controls.Clear();
            this.MainPanel.Controls.Add(dashBoard);
            lastPanel = dashBoard;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lastPanel.Dispose();
            HRForm hR = new HRForm();
            hR.TopLevel = false;
            hR.Show();
            lastPanel = hR;
            this.MainPanel.Controls.Clear();
            this.MainPanel.Controls.Add(hR);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonTask_Click(object sender, EventArgs e)
        {
            lastPanel.Dispose();
            TaskMainForm task = new TaskMainForm(this);
            task.TopLevel = false;
            task.Show();
            lastPanel = task;
            this.MainPanel.Controls.Clear();
            this.MainPanel.Controls.Add(task);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lastPanel.Dispose();
            DashBoard dashBoard = new DashBoard(me ,this);
            dashBoard.TopLevel = false;
            dashBoard.Show();
            this.MainPanel.Controls.Clear();
            this.MainPanel.Controls.Add(dashBoard);
            lastPanel = dashBoard;
        }
    }
}
