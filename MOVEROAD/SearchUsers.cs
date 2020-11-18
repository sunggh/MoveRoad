﻿using MOVEROAD.InfoFile;
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
    public partial class SearchUsers : Form
    {
        MainForm main;
        
        public int depart;
        public string name;
        public int age;

        public SearchUsers(MainForm main)
        {
            InitializeComponent();
            this.main = main;
            init();
        }

        private void init()
        {
            List<DepartmentInfo> departs = main.departments;
            foreach(var departname in departs)
            {
                string name = departname.name;
                comboBoxDepart.Items.Add(name);
            }
        }

        private void buttonDepartSearch_Click(object sender, EventArgs e)
        {
            this.depart = comboBoxDepart.SelectedIndex;

            string query = "SELECT user.index AS 'No.', department.name AS '부서명', " +
                "CASE user.grade WHEN 0 THEN '사장' WHEN 1 THEN '부서장' WHEN 2 THEN '사원' END AS '직위', user.name AS '이름', user.age AS '나이', " +
                "CASE user.gender WHEN 0 THEN '남자' WHEN 1 THEN '여자' END AS '성별', user.phone AS 'H.P', user.address AS '주소' " +
                "FROM project.user, project.department WHERE user.depart = department.id AND department.id = '" + depart + "'";
            DataTable table = DBConnetion.getInstance().getDBTable(query);
            dataGridView1.DataSource = table;

            comboBoxDepart.Text = "";
        }

        private void buttonNameSearch_Click(object sender, EventArgs e)
        {
            this.name = textBoxName.Text;

            string query = "SELECT user.index AS 'No.', department.name AS '부서명', " +
                "CASE user.grade WHEN 0 THEN '사장' WHEN 1 THEN '부서장' WHEN 2 THEN '사원' END AS '직위', user.name AS '이름', user.age AS '나이', " +
                "CASE user.gender WHEN 0 THEN '남자' WHEN 1 THEN '여자' END AS '성별', user.phone AS 'H.P', user.address AS '주소' " +
                "FROM project.user, project.department WHERE user.depart = department.id AND user.name = '" + name + "'";
            DataTable table = DBConnetion.getInstance().getDBTable(query);
            dataGridView1.DataSource = table;

            textBoxName.Text = "";
        }

        private void buttonAgeSearch_Click(object sender, EventArgs e)
        {
            this.age = Convert.ToInt32(textBoxAge.Text);

            string query = "SELECT user.index AS 'No.', department.name AS '부서명', " +
                "CASE user.grade WHEN 0 THEN '사장' WHEN 1 THEN '부서장' WHEN 2 THEN '사원' END AS '직위', user.name AS '이름', user.age AS '나이', " +
                "CASE user.gender WHEN 0 THEN '남자' WHEN 1 THEN '여자' END AS '성별', user.phone AS 'H.P', user.address AS '주소' " +
                "FROM project.user, project.department WHERE user.depart = department.id AND user.age = '" + age + "'";
            DataTable table = DBConnetion.getInstance().getDBTable(query);
            dataGridView1.DataSource = table;

            textBoxAge.Text = "";
        }
    }
}
