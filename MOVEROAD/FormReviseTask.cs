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
        DateTime startTime;
        DateTime finishTime;
        
        public FormReviseTask()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Application.UseWaitCursor = false;

                DataTable dtChanges = new DataTable();
                dtProcessFlag = (DataTable)dataGridViewTask.DataSource;

                //Added 하면 젠체애들 다 업데이트 해주긴 함 | 정석은 Modified
                dtChanges = dtProcessFlag.GetChanges(DataRowState.Added);

                string revisedIndex = "";
                if (dtChanges != null)
                {
                    for (int i = 0; i < dtChanges.Rows.Count; i++)
                    {
                        int id = (int)dtChanges.Rows[i]["ID"];
                        string text = dtChanges.Rows[i]["업무내용"] as string;
                        string date = dtChanges.Rows[i]["날짜"] as string;

                        startTime = Convert.ToDateTime(textBoxStartTime.Text);
                        finishTime = Convert.ToDateTime(textBoxFinishTime.Text);
                        string st = date + " " + dtChanges.Rows[i]["시작시간"];
                        string ft = date + " " + dtChanges.Rows[i]["종료시간"];


                        //업무시간 확인
                        if (DateTime.Compare(startTime, finishTime) == 1 || haveTimeOverlap() || startTime == finishTime) // st 보다 ft가 더 작으면
                        {
                            MessageBox.Show("업무시간을 확인하시오.");
                            return;
                        }

                        Console.WriteLine("시작시간 : " + st);
                        string query = "UPDATE task SET text = '" + text + "', startTime ='" + st + "', finishTime = '" + ft + "' WHERE id = '" + id + "'";
                        DBConnetion.getInstance().Update(query);

                        revisedIndex += id + " ";
                    }
                }
                //MessageBox.Show("[ " +revisedIndex + " ] 업무 수정이 완료 되었습니다.");
                MessageBox.Show("업무 수정이 완료 되었습니다.");
                dtChanges = null;

                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                Console.WriteLine("오류 : " + ex);
                MessageBox.Show("입력 형식이 잘못되었거나 수정된 정보가 없습니다. 확인하고 다시 시도하십시오.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
