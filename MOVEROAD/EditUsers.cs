﻿using System;
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
    public partial class EditUsers : Form
    {
        MainForm main;
        
        public EditUsers(MainForm main)
        {
            InitializeComponent();
            this.main = main;
            DataShow();
        }

        private void DataShow()
        {
            string query = "SELECT user.index AS 'No.', department.name AS '부서명', " +
                "CASE user.grade WHEN 0 THEN '사장' WHEN 1 THEN '부서장' WHEN 2 THEN '사원' END AS '직위', user.name AS '이름', user.age AS '나이', " +
                "CASE user.gender WHEN 0 THEN '남자' WHEN 1 THEN '여자' END AS '성별', user.phone AS 'H.P', user.address AS '주소' " +
                "FROM project.user, project.department WHERE user.depart = department.index";
            object table = DBConnetion.getInstance().Select(query, 70);
            
            dataGridView1.DataSource = table;
        }

        public void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridView1.CurrentRow.Index;

            // 클릭한 정보 넣어주기
            EditUsers_form edit = new EditUsers_form(main);
            edit.index = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            edit.depart = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            edit.grade = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            edit.name = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            edit.age = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            edit.gender = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            edit.phone = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
            edit.address = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
            edit.init();
            
            // 수정 창 띄우고 다른행동 못하게 금지
            main.TransparencyKey = Color.Gray;
            main.Opacity = 0.5;
            using (edit)
            {
                edit.ShowDialog();
            }
            main.Opacity = 1;
            if (main.me.depart != 1)
            {
                MessageBox.Show("접근 제한", "Error");
                DashBoard dashBoard = new DashBoard(main.me, main);
                dashBoard.TopLevel = false;
                dashBoard.Show();
                main.MainPanel.Controls.Clear();
                main.MainPanel.Controls.Add(dashBoard);
                main.lastPanel = dashBoard;
                return;
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            DataShow();
        }
    }
}
