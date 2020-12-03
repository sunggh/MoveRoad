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
            msgList.Items.Add("새로운 메세지가 없습니다.");
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += new DoWorkEventHandler(BackgroundWorkerDoWork);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackgroundWorkerRunWorkerCompleted);
            backgroundWorker.RunWorkerAsync();
            this.nameLabel.Text = user.name;
            this.ageLabel.Text = user.age + " 살";
            this.departLabel.Text = departName[user.depart];
            this.gradeLabel.Text = grade[user.grade];
            this.user = user;

            set_attendance_check();
        }


        private void set_attendance_check()
        {
            //만약 출근을 누르지 않았다면, 출근은 눌렀지만 퇴근을 누르지 않았다면, 퇴근을 눌렀다면

            //       출,퇴근 정보 가져오기 ///////

            string ID = main.me.id;  //현재접속중인 id값

            object start = DBConnetion.getInstance().Select("SELECT startTime FROM attendance_card " +
                "WHERE id='" + ID + "' and date ='" + DateTime.Now.ToString("yyyy-MM-dd") + "'", 22);  // 출근버튼을 클릭하였는지 확인

            object finish = DBConnetion.getInstance().Select("SELECT finishTime FROM attendance_card " +
                "WHERE id='" + ID + "' and date!= 'null'", 23); // 퇴근을 눌렀는지 확인

            //////////////////////////////////////
            

            if ((string)start == null)   // 출근 X
            {
                label_attendance.Text = "출근을 눌러주세요.";
            }
            else if ((string)start != null && (string)finish == "\"") // 출근 O , 퇴근 X
            {
                label_attendance.Text = start + "  출근";
            }
            else
            {
                label_attendance.Text = start + "  출근\n\n"+finish+"  퇴근";
            }
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }
        private void BackgroundWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            if (this.main.getMsgDash().Count>0)
            {
                if (msgList.Items[0].ToString() != this.main.getMsgDash()[0].ToString() || msgList.Items.Count != this.main.getMsgDash().Count)
                {
                    e.Result = (bool)true;
                }
                else
                    e.Result = (bool)false;
            }
            else
            {
                e.Result = (bool)false;
            }
            Thread.Sleep(500);
        }
        private void BackgroundWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((bool)e.Result)
            {
                if (msgList.Items.Count < 7)
                {
                    msgList.Items.Clear();
                    msgList.Items.AddRange(this.main.getMsgDash().ToArray());
                }
                else
                {
                    msgList.Items.RemoveAt(0);
                    msgList.Items.Add(this.main.getMsgDash()[5]);
                }
            }
            else
            {

            }

            backgroundWorker.RunWorkerAsync();

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
