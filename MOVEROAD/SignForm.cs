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
        public int worker { get; set; } //직급 (0:사원, 1:부장, 2:사장)

        public int part { get; set; }
        MainForm main;
        string connection = "Server=211.229.51.172;Database=project;Uid=move;Pwd=road;Charset=euckr";
        public SignForm(MainForm main)
        {
            InitializeComponent();
            this.main = main;
            string sql = "SELECT `name` FROM `user` where `depart` = '"+main.me.depart+"' AND `grade` = '1'";
            comboBoxDrafter.Items.Add((string)DBConnetion.getInstance().Select(sql,3));
           //InitValue();
        }

        public void InitValue() //초기화
        {
            //MySqlConnection conn = new MySqlConnection(connection);
            //conn.Open(); //DB연결

            //string query = "SELECT name FROM department";
            //MySqlCommand cmd = new MySqlCommand(query, conn);
            //MySqlDataReader rdr = cmd.ExecuteReader(); //DB로부터 값 받아오기

            //while(rdr.Read()) //업무콤보박스 업무추가
            //{
            //    string sub_class = rdr.GetString("name");
            //    comboBoxWork.Items.Add(sub_class);
            //}

            //rdr.Close();

            //결재자콤보박스 직급추가
            comboBoxDrafter.Items.Add("사원");
        }
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            string sub_class = comboBoxWork.Text;
            string drafter = comboBoxDrafter.Text;
            string content = textBoxContent.Text;
            string comment = textBoxComment.Text;

            //MySqlConnection conn = new MySqlConnection(connection);
            //conn.Open(); //DB연결

            //string query = "SELECT index AS part FROM sub_class WHERE name = '" + sub_class + "'";
            //MySqlCommand cmd = new MySqlCommand(query, conn);
            //MySqlDataReader rdr = cmd.ExecuteReader(); //DB로부터 값 받아오기

            //while (rdr.Read())
            //{
            //    part = Int32.Parse(rdr["part"].ToString());
            //}

            //rdr.Close();

            worker = Convert.ToInt32(comboBoxDrafter.Text);

            DBConnetion.getInstance().Insert("INSERT INTO sign (sub_class, comment, drafter, progress) VALUES ('" + part + "', '" + comment + "', '" + worker + "', '" + "결재 전" + "')");

            MessageBox.Show("결재가 등록되었습니다.", "확인");
        }
/*
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            //string sub_class = comboBoxSubClass.Text;
            string drafter = comboBoxDrafter.Text;
            string content = textBoxContent.Text;
            string comment = textBoxComment.Text;

        }*/
    }
}