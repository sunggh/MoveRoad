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
            string sql_work = "SELECT name FROM department;";
            foreach (DepartmentInfo department in main.departments)
            {
                comboBoxWork.Items.Add(department.name);
            }

        }

        //InfoFile.DepartmentInfo depart;

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            string work = comboBoxWork.Text;
            string drafter = comboBoxDrafter.Text;
            string content = textBoxContent.Text;
            string comment = textBoxComment.Text;

            //결재 전이 아니라 progress를 int로
            //string query = "INSERT INTO sign(sub_class, comment, drafter, progress) VALUES(1, '" + comment + "', 1, 1)";
            //DBConnetion.getInstance().Insert(query);

            MessageBox.Show("결재가 등록되었습니다.", "확인");
        }

        private void comboBoxWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDrafter.Items.Clear();
            string sql_drafter = "SELECT `name` FROM `project`.`user` WHERE `index` = " + main.departments[comboBoxWork.SelectedIndex].manager + "";
            string drafter = (string)DBConnetion.getInstance().Select(sql_drafter, 3);
            comboBoxDrafter.Items.Add(drafter);
        }
    }
}