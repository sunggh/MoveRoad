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

            //콤보박스에서 선택된 업무의 부서장만 SELECT할 수 있게
            string sql_drafter = "SELECT name FROM user WHERE grade = 1 AND depart = " + main.departments[comboBoxWork.SelectedIndex].id + "";
            string drafter = (string)DBConnetion.getInstance().Select(sql_drafter, 3);
            comboBoxDrafter.Items.Add(drafter);
        }


        private void buttonInsert_Click(object sender, EventArgs e) //결재 신규 등록할 때 (미완 : 기안자, 결재자를 사장으로 못하게 해야함)
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

                MessageBox.Show("결재가 등록되었습니다.", "확인");
            }
            else
            {
                MessageBox.Show("기안자가 될 수 없습니다.", "확인"); //미완 : 멘트 변경해야할듯
            }
        }

        private void tabControlSign_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControlSign.SelectedTab == tabPageToMe) //나에게 온 결재 요청 내역 tab을 클릭하면
            {
                //user가 사장이면 결재 중인 내역만 보이게
                if(main.me.grade == 0)
                {
                    string sql = "SELECT sign.index AS No, title AS 제목, text AS 내용, comment AS 코멘트, user.name AS 기안자 " +
                    "FROM sign JOIN user ON drafter_to = '" + main.me.name + "' AND sign.drafter = user.index AND sign.progress = 1";

                    DataTable table = DBConnetion.getInstance().getDBTable(sql);

                    dataGridViewRequest.DataSource = table;
                }
                //user가 부서장이면 결재 전인 내역만 보이게
                else if(main.me.grade == 1)
                {
                    string sql = "SELECT sign.index AS No, title AS 제목, text AS 내용, comment AS 코멘트, user.name AS 기안자 " +
                    "FROM sign JOIN user ON drafter_to = '" + main.me.name + "' AND sign.drafter = user.index AND sign.progress = 0";

                    DataTable table = DBConnetion.getInstance().getDBTable(sql);

                    dataGridViewRequest.DataSource = table;
                }
            }
            //내가 등록한 결재 내역 tab을 클릭하면
            //미완 : 진행 상황 string으로 바꿔야함
            else if (tabControlSign.SelectedTab == tabPageFromMe)
            {
                string sql_done = "SELECT sign.index AS No, title AS 제목, text AS 내용, comment AS 코멘트, progress AS 진행상황 FROM sign WHERE drafter = '" + main.me.index + "' AND sign.progress != 3";

                DataTable table_DoneList = DBConnetion.getInstance().getDBTable(sql_done);
                dataGridViewSignList.DataSource = table_DoneList;

                string sql_turn = "SELECT sign.index AS No, title AS 제목, text AS 내용, comment AS 코멘트 FROM sign WHERE drafter = '" + main.me.index + "' AND sign.progress = 3";

                DataTable table_TurnList = DBConnetion.getInstance().getDBTable(sql_turn);
                dataGridViewSignTurnList.DataSource = table_TurnList;
            }
        }

        private void buttonSign_Click(object sender, EventArgs e) //결재하기
        {
            int rowIndex = dataGridViewRequest.CurrentRow.Index;

            string cnt_ = dataGridViewRequest.Rows[rowIndex].Cells[0].Value.ToString();
            int cnt = Convert.ToInt32(cnt_.ToString());

            //uesr가 부서장이면 결재자를 사장으로 바꿔주고 진행 상황을 1(결재 중)로 바꾸기
            if (main.me.grade == 1)
            {
                string sql = "UPDATE sign SET sign.progress = 1, sign.drafter_to = '" + "이동길" + "' WHERE sign.index = '" + cnt + "'";

                DBConnetion.getInstance().Update(sql);
            }

            //user가 사장이면 진행 상황을 2(결재 완료)로 바꾸기
            else if(main.me.grade == 0)
            {
                string sql = "UPDATE sign SET sign.progress = 2 WHERE sign.index = '" + cnt + "'";

                DBConnetion.getInstance().Update(sql);
            }

            string datetime = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");

            string query = "INSERT INTO sign_ok(sign_ok.num, date) VALUES('" + cnt + "', '" + datetime + "')";
            DBConnetion.getInstance().Insert(query);

            MessageBox.Show(datetime + "에 결재되었습니다.", "확인");
        }

        private void buttonTurn_Click(object sender, EventArgs e) //반려하기
        {
            string memo = textBoxMemo.Text;

            int rowIndex = dataGridViewRequest.CurrentRow.Index;

            string cnt_ = dataGridViewRequest.Rows[rowIndex].Cells[0].Value.ToString();
            int cnt = Convert.ToInt32(cnt_.ToString());

            string sql = "INSERT INTO sign_turn(sign_turn.index, memo) VALUES('" + cnt + "', '" + memo + "')";

            DBConnetion.getInstance().Insert(sql);

            string query = "UPDATE sign SET sign.progress = 3 WHERE sign.index = '" + cnt + "'";

            DBConnetion.getInstance().Update(query);

            MessageBox.Show("반려되었습니다.", "확인");
        }

        private void dataGridViewSignTurnList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridViewSignTurnList.CurrentRow.Index;

            string cnt_ = dataGridViewSignTurnList.Rows[rowIndex].Cells[0].Value.ToString();
            int cnt = Convert.ToInt32(cnt_.ToString());

            string sql = "SELECT memo FROM sign_turn WHERE sign_turn.index = '" + cnt + "'";

            textBoxSignTurnMemo.Text = (string)DBConnetion.getInstance().Select(sql, 7);
        }

        //결재 내용 상세보기
        private void dataGridViewRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridViewRequest.CurrentRow.Index;

            string cnt_ = dataGridViewRequest.Rows[rowIndex].Cells[0].Value.ToString();
            int cnt = Convert.ToInt32(cnt_.ToString());

            string sql = "SELECT text FROM sign WHERE sign.index = '" + cnt + "'";

            textBoxDetail.Text = (string)DBConnetion.getInstance().Select(sql, 9);
        }
    }
}