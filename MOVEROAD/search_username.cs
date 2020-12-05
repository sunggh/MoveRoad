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
    public partial class search_username : Form
    {
        public string username_;

        public search_username()
        {
            InitializeComponent();
            print_lv_dpt_users();
        }
        
        public void print_lv_dpt_users()
        {
            //이름과 부서를 뽑아내기(사원 계급만)
            string get_name_and_dpt = "SELECT `user`.`index`, `user`.`name`, `department`.`name`as `depart` " +
                "FROM project.user,project.department " +
                "where `department`.index = `user`.`depart` and `grade` = 2";

            List<string> list;
            list = DBConnetion.getInstance().dpt_id_and_name(get_name_and_dpt,0);
            lv_dpt_users.Items.Clear();
            lv_dpt_users.BeginUpdate();
            ListViewItem item;

            for (int i = 0; i < list.Count; i = i + 3)
            {
                item = new ListViewItem(list[i]);
                item.SubItems.Add(list[i + 1]);
                item.SubItems.Add(list[i + 2]);
                lv_dpt_users.Items.Add(item);
            }
            lv_dpt_users.EndUpdate();
        }

        private void lv_dpt_users_DoubleClick(object sender, EventArgs e)
        {
            if (lv_dpt_users.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = lv_dpt_users.SelectedItems;
                ListViewItem item = items[0];
                string username = item.SubItems[1].Text; 

                username_ = username;

                this.Dispose();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
