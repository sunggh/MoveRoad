using MOVEROAD.InfoFile;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOVEROAD
{
    public partial class SignForm : Form
    {
        MainForm main;
        public SignForm(MainForm main)
        {
            InitializeComponent();

            this.main = main;

            //업무선택 콤보박스
            foreach (DepartmentInfo department in main.departments)
            {
                comboBoxWork.Items.Add(department.name);
            }

        }

        private void comboBoxWork_SelectedIndexChanged(object sender, EventArgs e) //콤보박스의 업무를 선택하면
        {
            comboBoxDrafter.Items.Clear(); //결재자 초기화

            try
            {
                //콤보박스에서 선택된 업무의 부서장만 SELECT할 수 있게
                string sql_drafter = "SELECT name FROM user WHERE grade = 1 AND depart = " + main.departments[comboBoxWork.SelectedIndex].id + "";
                string drafter = (string)DBConnetion.getInstance().Select(sql_drafter, 3);
                comboBoxDrafter.Items.Add(drafter);
            }
            catch
            {
                MessageBox.Show("해당 부서의 부서장이 존재하지 않습니다.", "알림");
            }
        }

        //결재 신규 등록할 때
        private void buttonInsert_Click(object sender, EventArgs e) 
        {
            string title = textBoxTitle.Text;
            string drafter = comboBoxDrafter.Text;
            string content = textBoxContent.Text;
            string comment = textBoxComment.Text;

            //progress = 진행사항 (0:결재 전, 1:결재 중, 2:결재 완료, 3:반려) 등록할때는 항상 progress = 0
            //사원만 신규 결재 등록 가능
            if(main.me.grade == 2)
            {
                string sql = "INSERT INTO sign(title, text, comment, sub_class, drafter, drafter_to, progress) " +
                "VALUES('" + title + "', '" + content + "', '" + comment + "', '" + main.departments[comboBoxWork.SelectedIndex].id + "', '" + main.me.index + "', '" + drafter + "', 0)";

                DBConnetion.getInstance().Insert(sql);

                MessageBox.Show("결재가 등록되었습니다.", "알림");
            }
            else
            {
                MessageBox.Show("결재 등록은 사원만 가능합니다.", "알림");
            }

        }

        private void tabControlSign_SelectedIndexChanged(object sender, EventArgs e)
        {
            //나에게 온 결재 요청 내역 tab을 클릭하면
            if (tabControlSign.SelectedTab == tabPageToMe) 
            {
                //user가 사장이면 결재 중인 내역만 보이게
                if(main.me.grade == 0)
                {
                    string sql = "SELECT sign.index AS No, title AS 제목, text AS 내용, comment AS 코멘트, user.name AS 기안자 " +
                    "FROM sign JOIN user ON drafter_to = '" + main.me.name + "' AND sign.drafter = user.index AND sign.progress = 1";

                    object table = DBConnetion.getInstance().Select(sql, 70);

                    dataGridViewRequest.DataSource = table;
                }
                //user가 부서장이면 결재 전인 내역만 보이게
                else if(main.me.grade == 1)
                {
                    string sql = "SELECT sign.index AS No, title AS 제목, text AS 내용, comment AS 코멘트, user.name AS 기안자 " +
                    "FROM sign JOIN user ON drafter_to = '" + main.me.name + "' AND sign.drafter = user.index AND sign.progress = 0";

                    object table = DBConnetion.getInstance().Select(sql, 70);

                    dataGridViewRequest.DataSource = table;
                }
                //user가 사원이면
                //이거뺄까?
                else if(main.me.grade == 2)
                {
                    MessageBox.Show("해당 권한이 없습니다.", "알림");
                }
            }

            //내가 등록한 결재 내역 tab을 클릭하면
            else if (tabControlSign.SelectedTab == tabPageFromMe)
            {
                SignFromMe();
            }
        }

        private void SignFromMe()
        {
            //내가 등록한 결재 내역
            string sql_done = "SELECT sign.index AS No, title AS 제목, text AS 내용, comment AS 코멘트, CASE WHEN progress=0 THEN '결재전' WHEN progress=1 THEN '결재중' WHEN progress=2 THEN '결재완료' ELSE '반려됨' END AS 진행상황 FROM sign WHERE drafter = '" + main.me.index + "' AND sign.progress != 3";

            object table_DoneList = DBConnetion.getInstance().Select(sql_done, 70);
            dataGridViewSignList.DataSource = table_DoneList;

            //반려 내역
            string sql_turn = "SELECT sign.index AS No, title AS 제목, text AS 내용, comment AS 코멘트 FROM sign WHERE drafter = '" + main.me.index + "' AND sign.progress = 3";

            object table_TurnList = DBConnetion.getInstance().Select(sql_turn, 70);
            dataGridViewSignTurnList.DataSource = table_TurnList;
        }

        //결재하기
        private void buttonSign_Click(object sender, EventArgs e) 
        {
            if(dataGridViewRequest.CurrentCell == null)
            {
                MessageBox.Show("결재할 내역을 선택해 주십시오.", "알림");
            }
            else
            {
                string datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                int rowIndex = dataGridViewRequest.CurrentRow.Index;

                string cnt_ = dataGridViewRequest.Rows[rowIndex].Cells[0].Value.ToString();
                int cnt = Convert.ToInt32(cnt_.ToString());

                string boss = "SELECT name FROM user WHERE grade = 0";
                string boss_ = (string)DBConnetion.getInstance().Select(boss, 3);

                //uesr가 부서장이면 결재자를 사장으로 바꿔주고 진행 상황을 1(결재 중)로 바꾸기
                if (main.me.grade == 1)
                {
                    string sql = "UPDATE sign SET sign.progress = 1, sign.drafter_to = '" + boss + "' WHERE sign.index = '" + cnt + "'";

                    DBConnetion.getInstance().Update(sql);

                    string query = "INSERT INTO sign_ok(sign_ok.num, date) VALUES('" + cnt + "', '" + datetime + "')";
                    DBConnetion.getInstance().Insert(query);
                }

                //user가 사장이면 진행 상황을 2(결재 완료)로 바꾸기
                else if (main.me.grade == 0)
                {
                    string sql = "UPDATE sign SET sign.progress = 2 WHERE sign.index = '" + cnt + "'";

                    DBConnetion.getInstance().Update(sql);

                    string query = "UPDATE sign_ok SET sign_ok.date = '" + datetime + "' WHERE sign_ok.num = '" + cnt + "'";
                    DBConnetion.getInstance().Update(query);
                }

                MessageBox.Show(datetime + "에 결재되었습니다.", "알림");
            }
        }

        //반려하기
        private void buttonTurn_Click(object sender, EventArgs e) 
        {
            if (dataGridViewRequest.CurrentRow == null)
            {
                MessageBox.Show("반려할 내역을 선택해 주십시오.", "알림");
            }
            else
            {
                string memo = textBoxMemo.Text;

                int rowIndex = dataGridViewRequest.CurrentRow.Index;

                string cnt_ = dataGridViewRequest.Rows[rowIndex].Cells[0].Value.ToString();
                int cnt = Convert.ToInt32(cnt_.ToString());

                string sql = "INSERT INTO sign_turn(sign_turn.index, memo) VALUES('" + cnt + "', '" + memo + "')";

                DBConnetion.getInstance().Insert(sql);

                string query = "UPDATE sign SET sign.progress = 3 WHERE sign.index = '" + cnt + "'";

                DBConnetion.getInstance().Update(query);

                MessageBox.Show("반려되었습니다.", "알림");
            }
        }

        //결재 반려내역 셀 클릭시 내용 상세보기 & 반려 메모 보기
        private void dataGridViewSignTurnList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridViewSignTurnList.CurrentRow.Index;

            string cnt_ = dataGridViewSignTurnList.Rows[rowIndex].Cells[0].Value.ToString();
            int cnt = Convert.ToInt32(cnt_.ToString());

            string sql = "SELECT memo FROM sign_turn WHERE sign_turn.index = '" + cnt + "'";

            textBoxSignTurnMemo.Text = (string)DBConnetion.getInstance().Select(sql, 7);

            string query = "SELECT text FROM sign WHERE sign.index = '" + cnt + "'";

            textBoxDetail_turn.Text = (string)DBConnetion.getInstance().Select(query, 9);
        }

        //결재 요청내역 셀 클릭시 내용 상세보기
        private void dataGridViewRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridViewRequest.CurrentRow.Index;

            string cnt_ = dataGridViewRequest.Rows[rowIndex].Cells[0].Value.ToString();
            int cnt = Convert.ToInt32(cnt_.ToString());

            string sql = "SELECT text FROM sign WHERE sign.index = '" + cnt + "'";

            textBoxDetail_req.Text = (string)DBConnetion.getInstance().Select(sql, 9);
        }

        //내가 등록한 결재 내역 셀 클릭시 내용 상세보기
        private void dataGridViewSignList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridViewSignList.CurrentRow.Index;

            string cnt_ = dataGridViewSignList.Rows[rowIndex].Cells[0].Value.ToString();
            int cnt = Convert.ToInt32(cnt_.ToString());

            try
            {
                string sql = "SELECT text FROM sign WHERE sign.index = '" + cnt + "'";

                textBoxDetail_done.Text = (string)DBConnetion.getInstance().Select(sql, 9);

                string query = "SELECT date FROM sign_ok JOIN sign WHERE sign_ok.num = '" + cnt + "' AND sign.progress != 0";
                DateTime done_date = (DateTime)DBConnetion.getInstance().Select(query, 10);

                MessageBox.Show(done_date + "에 결재된 내역입니다.", "알림");
            }
            catch
            {
                MessageBox.Show("결재 전 내역입니다.", "알림");
            }
        }
    }
}