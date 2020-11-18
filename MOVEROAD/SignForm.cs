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

            string sql_drafter = "SELECT `name` FROM `project`.`user` WHERE `index` = " + main.departments[comboBoxWork.SelectedIndex].manager + "";
            string drafter = (string)DBConnetion.getInstance().Select(sql_drafter, 3);
            comboBoxDrafter.Items.Add(drafter);
        }


        private void buttonInsert_Click(object sender, EventArgs e) //결재 신규 등록
        {
            string title = textBoxTitle.Text;
            string drafter = comboBoxDrafter.Text;
            string content = textBoxContent.Text;
            string comment = textBoxComment.Text;

            //progress = 진행사항 (0:결재 전, 1:결재 중, 2:결재 완료, 3:반려) 등록할때는 항상 progress = 0
            string query = "INSERT INTO sign(title, text, comment, sub_class, drafter, drafter_to, progress) " +
                "VALUES('" + title + "', '" + content + "', '" + comment + "', '" + main.departments[comboBoxWork.SelectedIndex].id + "', '" + main.me.index + "', '" + drafter + "', 0)";
            DBConnetion.getInstance().Insert(query);

            MessageBox.Show("결재가 등록되었습니다.", "확인");
        }

        private void tabControlSign_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControlSign.SelectedTab == tabPageToMe) //나에게 온 결재 요청 내역 tab을 클릭하면
            {
                string sql = "SELECT title AS 제목, text AS 내용, comment AS 코멘트 FROM sign WHERE drafter_to = '" + main.me.name + "'"; //미완성이무니다

                DataTable table = DBConnetion.getInstance().getDBTable(sql);

                dataGridViewRequest.DataSource = table;
            }
            else if(tabControlSign.SelectedTab == tabPageFromMe) //내가 결재 등록한 내역 tab을 클릭하면
            {
                string sql = "SELECT title AS 제목, text AS 내용, comment AS 코멘트 FROM sign WHERE drafter = '" + main.me.index + "'";

                DataTable table = DBConnetion.getInstance().getDBTable(sql);

                dataGridViewSignList.DataSource = table;
            }
        }
    }
}