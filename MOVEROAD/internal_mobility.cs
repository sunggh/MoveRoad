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
    public partial class internal_mobility : Form
    {
        private MainForm mf;

        public internal_mobility(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }

        private void btn_user_search_Click(object sender, EventArgs e)
        {
            using (search_username dpt = new search_username())
            {
                dpt.ShowDialog();
                tb_user.Text = dpt.username_;
            }
        }

        private void btn_dpt_search_Click(object sender, EventArgs e)
        {
            using (search_departname dpt = new search_departname())
            {
                dpt.ShowDialog();
                tb_depart_name.Text = dpt.dpt_name_;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_move_Click(object sender, EventArgs e)
        {
            string tb_user_name = tb_user.Text; // 사원 명
            string tb_dpt_name = tb_depart_name.Text; // 부서 명

            //먼저 부서명(한글)을 통해 user테이블의 depart값(depart 테이블의 id값) 으로 변환해야함.
            string change_depart = "select id from department where `name` = '" + tb_dpt_name + "'";
            String id = (String)DBConnetion.getInstance().Select(change_depart,87);

            //이제 user테이블에서 정보대로 바꾸기
            string update_query = "update user set depart = '" + id + "' where name = '" + tb_user_name + "'";
            DBConnetion.getInstance().Update(update_query);

            this.Dispose();
        }
    }
}
