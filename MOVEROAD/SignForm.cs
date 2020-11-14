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
            comboBoxDrafter.Items.Clear(); //초기화
            string sql_drafter = "SELECT `name` FROM `project`.`user` WHERE `index` = " + main.departments[comboBoxWork.SelectedIndex].manager + "";
            string drafter = (string)DBConnetion.getInstance().Select(sql_drafter, 3);
            comboBoxDrafter.Items.Add(drafter);
        }

        //InfoFile.DepartmentInfo depart;

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            //string work = comboBoxWork.Text;
            string drafter = comboBoxDrafter.Text;
            string content = textBoxContent.Text;
            string comment = textBoxComment.Text;

            //progress = 진행사항 (0:결재 전, 1:결재 중, 2:결재 완료, 3:반려) 등록할때는 항상 progress = 0
            string query = "INSERT INTO sign(title, text, comment, sub_class, drafter, drafter_to, progress) " +
                "VALUES('" + title + "', '" + content + "', '" + comment + "', '" + main.departments[comboBoxWork.SelectedIndex].id + "', '" + main.me.index + "', '" + drafter + "', 0)";
            DBConnetion.getInstance().Insert(query);

            MessageBox.Show("결재가 등록되었습니다.", "확인");
        }

        private void checkBoxSignList_CheckedChanged(object sender, EventArgs e) //내가 등록한 결재 내역을 보려면
        {
            
        }
    }
}