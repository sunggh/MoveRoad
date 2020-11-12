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
        private static depart_revise_event instance = new depart_revise_event();

        public static depart_revise_event getinstance()
        {
            return instance;
        }
        public depart_revise_event()
        {
            instance = this;
            InitializeComponent();
        }

        private void btn_search_head_Click(object sender, EventArgs e)
        {
            rivise_depart rivise = new rivise_depart();
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
            user = (UserInfo)DBConnetion.getInstance().Select(index_to_head, 0);

            string head_to_index = "SELECT * FROM user where `name`= '" + revise_head + "'";
            user2 = (UserInfo)DBConnetion.getInstance().Select(head_to_index, 0);

            string update_query = "update `department` set `name` = '"+ revise_name + "',`manager` = "+ user2.index + "," +
                "`description` = '"+ revise_description + "' where `name` = '" + og_name + "' and `manager` = " + user.index + "and " +
                "`description` = '" + og_description + "'" ;
            DBConnetion.getInstance().Update(update_query);
            Application.OpenForms["rivise_depart"].Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            search_head search = new search_head(1);
            search.ShowDialog();
        }
    }
}
