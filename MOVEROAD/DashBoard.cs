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
            string[] grade = { "사장", "부서장", "사원" };
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
            setTaskListRecently();
            set_Sign();
        }

        private void setTaskListRecently()
        {
            //최근에 한 업무 5개 불러오기
            string query = "SELECT A.*, B.name as task FROM project.task as A LEFT OUTER JOIN project.task_class as B ON A.sub_id = B.id WHERE A.user_id = '" + user.index + "'";
            List<string> recentlyTask = DBConnetion.getInstance().Select(query, 16) as List<string>;
            recentlyTask.Reverse();
            int i = 1;
            foreach(string task in recentlyTask)
            {
                if (i > 5)
                    break;
                TaskList.Items.Add(i + ". " + task);
                i++;
            }
        }

        private void set_attendance_check()
        {
            //만약 출근을 누르지 않았다면, 출근은 눌렀지만 퇴근을 누르지 않았다면, 퇴근을 눌렀다면

            //       출,퇴근 정보 가져오기 ///////

            string ID = main.me.id;  //현재접속중인 id값

            object start = DBConnetion.getInstance().Select("SELECT startTime FROM attendance_card " +
                "WHERE id='" + ID + "' and date ='" + DateTime.Now.ToString("yyyy-MM-dd") + "'", 22);  // 출근버튼을 클릭하였는지 확인

            object finish = DBConnetion.getInstance().Select("SELECT finishTime FROM attendance_card " +
                "WHERE id='" + ID + "' and date ='" + DateTime.Now.ToString("yyyy-MM-dd") + "'", 23); // 퇴근을 눌렀는지 확인

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

       private void set_Sign()
        {
            //사장이 접속하면
            if(main.me.grade == 0)
            {
                //부서장이 한번 결재한 건이 사장한테 가니까 결재 중 상태인 내역 가져오기
                string sql = "SELECT count(*) FROM sign WHERE progress = 1 AND drafter_to = '" + main.me.name + "'";
                string count = (string)DBConnetion.getInstance().Select(sql, 11);

                label_sign.Text = "결재할 내역 : " + count + "개";
            }
            //부서장이 접속하면
            else if(main.me.grade == 1)
            {
                string sql = "SELECT count(*) FROM sign WHERE progress = 0 AND drafter_to = '" + main.me.name + "'";
                string count = (string)DBConnetion.getInstance().Select(sql, 11);

                label_sign.Text = "결재할 내역 : " + count + "개";
            }
            //사원이 접속하면
            else if (main.me.grade == 2)
            {
                //결재 전
                string sql_ = "SELECT count(*) FROM sign WHERE progress = 0 AND drafter = '" + main.me.index + "'";
                string count_yet = (string)DBConnetion.getInstance().Select(sql_, 11);
                //결재 중
                string query_ = "SELECT count(*) FROM sign WHERE progress = 1 AND drafter = '" + main.me.index + "'";
                string count_ing = (string)DBConnetion.getInstance().Select(query_, 11);
                //결재 완료
                string sql = "SELECT count(*) FROM sign WHERE progress = 2 AND drafter = '" + main.me.index + "'";
                string count_done = (string)DBConnetion.getInstance().Select(sql, 11);
                //결재 반려
                string query = "SELECT count(*) FROM sign WHERE progress = 3 AND drafter = '" + main.me.index + "'";
                string count_turn = (string)DBConnetion.getInstance().Select(query, 11);

                label_sign.Text = "결재 대기 내역 : " + count_yet + "개" + "\n" + "결재 중 내역 : " + count_ing + "개" + "\n" + "결재완료된 내역 : " + count_done + "개" + "\n" + "반려된 내역 : " + count_turn + "개";
            }
        }
    }
}
