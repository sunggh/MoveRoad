using System;
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
    public partial class DashBoard : Form
    {
        UserInfo user;
        MainForm main;
        private BackgroundWorker backgroundWorker;
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
            msgList.Items.Add("메세지가 없습니다.");
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += new DoWorkEventHandler(BackgroundWorkerDoWork);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackgroundWorkerRunWorkerCompleted);
            backgroundWorker.RunWorkerAsync();
            this.nameLabel.Text = user.name;
            this.ageLabel.Text = user.age + " 살";
            this.departLabel.Text = departName[user.depart];
            this.gradeLabel.Text = grade[user.grade];
            this.user = user;

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }
        private void BackgroundWorkerDoWork(object sender, DoWorkEventArgs e)
        {
           
            if (this.main.msgDash.Count>0)
            {
                if(msgList.Items[0].ToString() != this.main.msgDash[0])
                    e.Result = (bool)true;
            }
            else
            {
                e.Result = (bool)false;
            }
            Thread.Sleep(500);
        }
        private void BackgroundWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result == null)
            {
                backgroundWorker.RunWorkerAsync();
            } else
            {
                if ((bool)e.Result)
                {
                    if (msgList.Items.Count < 7)
                    {
                        msgList.Items.Clear();
                        msgList.Items.AddRange(this.main.msgDash.ToArray());
                    }
                    else
                    {
                        msgList.Items.RemoveAt(0);
                        msgList.Items.Add(this.main.msgDash[5]);
                    }
                }
                else
                {

                }
            }
            
            
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
