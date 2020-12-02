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
    public partial class FormReviseTask : Form
    {
        private TaskForm TaskForm;
        private UserInfo me;
        DateTime startTime;
        DateTime finishTime;

        int id;
        string taskName;
        string text;
        string date;
        string st;
        string ft;
        int searchFlag;

        public FormReviseTask(TaskForm TaskForm, UserInfo me, int id, string taskName, string text, string date, string  st, string ft, int searchFlag)
        {
            this.TaskForm = TaskForm;
            this.me = me;
            this.id = id;
            this.taskName = taskName;
            this.text = text;
            this.date = date;
            this.ft = ft;
            this.st = st;
            this.searchFlag = searchFlag;

            InitializeComponent();
            InitTaskInfo();
        }
        private void InitTaskInfo()
        {
            labelTaskName.Text = taskName;
            labelUserName.Text = me.name;
            textBoxStartTime.Text = st;
            textBoxFinishTime.Text = ft;
            textBoxText.Text = text;
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM task WHERE id = '" + id + "'";
            DBConnetion.getInstance().Delete(query);

            MessageBox.Show("업무 삭제가 완료 되었습니다.");
            setTaskView();
            this.Dispose();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            startTime = Convert.ToDateTime(textBoxStartTime.Text);  //DateTime
            finishTime = Convert.ToDateTime(textBoxFinishTime.Text);
            st = date + " " + textBoxStartTime.Text;    //string
            ft = date + " " + textBoxFinishTime.Text;
            text = textBoxText.Text;

            //업무시간 확인
            if (DateTime.Compare(startTime, finishTime) == 1 || TaskForm.haveTimeOverlap(me.index) || startTime == finishTime) // st 보다 ft가 더 작으면
            {
                MessageBox.Show("업무시간을 확인하시오.");
                return;
            }

            Console.WriteLine("시작시간 : " + st);
            string query = "UPDATE task SET text = '" + text + "', startTime ='" + st + "', finishTime = '" + ft + "' WHERE id = '" + id + "'";
            DBConnetion.getInstance().Update(query);
            
            MessageBox.Show("업무 수정이 완료 되었습니다.");
            setTaskView();
            this.Dispose();
        }
        private void setTaskView()
        {
            if (searchFlag == 1)
            {
                TaskForm.selectedKeywordDataView();
            }
            else if (searchFlag == 2)
            {
                TaskForm.selectedRegistrantDataView();
            }
        }
    }
}
