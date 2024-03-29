﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOVEROAD
{
    public partial class depart_revise_event : Form
    {
        public string get_id;

        private MainForm mf;

        public depart_revise_event(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }

        private void btn_search_head_Click(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Gray;
            this.Opacity = 0.5;
            using (rivise_depart rivise = new rivise_depart(this))
            {
                rivise.ShowDialog();
            }
            this.Opacity = 1;
        }

        private void btn_revise_Click(object sender, EventArgs e)
        {
            UserInfo user;
            UserInfo user2;
            string og_name = tb_original_name.Text;
            string og_head = tb_original_head.Text;
            string og_description = tb_original_description.Text;
            string revise_name = tb_revise_name.Text;
            string revise_head = tb_revise_head.Text;
            string revise_description = tb_revise_description.Text;

            //정규식//
            Regex regex = new Regex("^([가-힣]{2,})$");
            if (!regex.IsMatch(revise_name) || !regex.IsMatch(revise_description))
            {
                MessageBox.Show("한글만 입력가능합니다.");
                return;
            }

            if (revise_name.Equals("") || revise_head.Equals(""))
            {
                MessageBox.Show("내용을 입력해주세요.");
            }
            else
            {
                //og는 분명히 부서장이어야 함(부서장은 한명이니 중복x)
                string index_to_head = "SELECT * FROM user where `name`= '" + og_head + "' and `grade` = 1";
                user = (UserInfo)DBConnetion.getInstance().Select(index_to_head, 0); // og의 유저값

               
                //수정될 ng는 동명이인이 있을 수 있음
                string head_to_index = "SELECT * FROM user where `name`= '" + revise_head + "' and `grade` = 2 and `index` = '"+get_id+"'";
                user2 = (UserInfo)DBConnetion.getInstance().Select(head_to_index, 0); // 수정할 유저값

                string update_query = "update project.`department` " +
                    "set `name` = '" + revise_name + "',`manager` = '" + user2.index + "', `description` = '" + revise_description + "' " +
                    "where `name` = '" + og_name + "' and `manager` = '" + user.index + "' and `description` = '" + og_description + "'";
                DBConnetion.getInstance().Update(update_query);
                //이까지는 보이는 부서의 수정

                string up_query, up_query2;

                //이후부터는 예외를 처리해주어야함.
                //예외1: 만약에 수정하려는 부서장과, 수정되어지는 부서장이 다르다면 직급세팅필요
                if (!og_head.Equals(revise_head))
                {
                    //수정전 유저 부서는 그대로 직급은 사원으로
                    up_query = "update `user` set `grade` = 2 where `index` = '" + user.index + "' ";
                    DBConnetion.getInstance().Update(up_query);

                    //수정되어지는 유저 직급, 부서 변경
                    up_query2 = "update `user` set `depart` = '" + user.depart + "', `grade` = 1 where `index` = '" + user2.index + "'";
                    DBConnetion.getInstance().Update(up_query2);
                }

                string get_dpt = "select `index` from `department` where `name` = '" + revise_name + "' and `manager` = '" + user2.index + "'";
                int dpt_og_id = (int)DBConnetion.getInstance().Select(get_dpt, 20);
                
                //task_class의 부서이름이 달린 대업무 이름도 변경하기
                string task_class = "update task_class set `name` = '" + revise_name + "' where `parent_id`=1 and `level` = 1 and `depart_id` = '" + dpt_og_id+ "'";
                DBConnetion.getInstance().Update(task_class);

                MessageBox.Show("수정되었습니다.");
                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Gray;
            this.Opacity = 0.5;
            using (search_head search = new search_head())
            {
                search.ShowDialog();
                tb_revise_head.Text = search.name_;
                get_id = search.get_id_;
            }
            this.Opacity = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
