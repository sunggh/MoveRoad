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
    public partial class depart_revise_event : Form
    {
        private MainForm mf;

        public depart_revise_event(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }

        private void btn_search_head_Click(object sender, EventArgs e)
        {
            rivise_depart rivise = new rivise_depart(this);
            rivise.ShowDialog();
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


            string index_to_head = "SELECT * FROM user where `name`= '" + og_head + "'";
            user = (UserInfo)DBConnetion.getInstance().Select(index_to_head, 0); // og의 유저값

            string head_to_index = "SELECT * FROM user where `name`= '" + revise_head + "'";
            user2 = (UserInfo)DBConnetion.getInstance().Select(head_to_index, 0); // 수정할 유저값

            string update_query = "update project.`department` " +
                "set `name` = '"+ revise_name + "',`manager` = '"+ user2.index + "', `description` = '"+ revise_description + "' " +
                "where `name` = '" + og_name + "' and `manager` = '" + user.index + "' and `description` = '" + og_description + "'" ;
            DBConnetion.getInstance().Update(update_query);
            //이까지는 보이는 부서의 수정

            string up_query,up_query2;

            //이후부터는 예외를 처리해주어야함.
            //예외1: 만약에 수정하려는 부서장과, 수정되어지는 부서장이 다르다면 직급세팅필요
            if (!og_head.Equals(revise_head))
            {
                //수정전 유저 부서는 그대로 직급은 사원으로
                up_query = "update `user` set `grade` = 2 where `index` = '"+user.index+"' ";
                DBConnetion.getInstance().Update(up_query);

                //수정되어지는 유저 직급, 부서 변경
                up_query2 = "update `user` set `depart` = '" + user.depart + "', `grade` = 1 where `index` = '" + user2.index + "'";
                DBConnetion.getInstance().Update(up_query2);
            }

            // [[[[[[[[[[[[[[[[[[[[[[[[[중요]]]]]]]]]]]]]]]]]]]]]]]]] //
            //
            //         수정된대로 객체로 넣어주는 작업도 해야함
            //
            // [[[[[[[[[[[[[[[[[[[[[[[[[중요]]]]]]]]]]]]]]]]]]]]]]]]] //



            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            using (search_head search = new search_head())
            {
                search.ShowDialog();
                tb_revise_head.Text = search.name_;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
