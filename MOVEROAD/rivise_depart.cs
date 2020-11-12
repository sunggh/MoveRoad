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
    public partial class rivise_depart : Form
    {
        public rivise_depart()
        {
            InitializeComponent();
            print_revising_users();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.OpenForms["rivise_depart"].Close();
        }

        public void print_revising_users()
        {
            string query = "select * from department";
            List<string> list;
            list = (List<string>)DBConnetion.getInstance().revise_userlist(query);
            lv_rivise.Items.Clear();
            lv_rivise.BeginUpdate();
            ListViewItem item = new ListViewItem();

            for (int i = 0; i < list.Count; i = i + 3)
            {
                item = new ListViewItem(list[i]);
                item.SubItems.Add(list[i + 1]);
                item.SubItems.Add(list[i + 2]);
                lv_rivise.Items.Add(item);
            }
            lv_rivise.EndUpdate();
        }

        private void lv_rivise_DoubleClick_1(object sender, EventArgs e)
        {
            UserInfo user;
            if (lv_rivise.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = lv_rivise.SelectedItems;
                ListViewItem item = items[0];
                string name = item.SubItems[0].Text;

                string manager = item.SubItems[1].Text;
                string index_to_head = "SELECT * FROM user where `index`= '" + manager + "'";
                user = (UserInfo)DBConnetion.getInstance().Select(index_to_head, 0);

                string description = item.SubItems[2].Text;

                depart_revise_event.getinstance().tb_original_name.Text = name;
                depart_revise_event.getinstance().tb_original_head.Text = user.name;
                depart_revise_event.getinstance().tb_original_description.Text = description;

                depart_revise_event.getinstance().lb_depart_name.Visible = true;
                depart_revise_event.getinstance().lb_depart_head.Visible = true;
                depart_revise_event.getinstance().lb_depart_description.Visible = true;
                depart_revise_event.getinstance().tb_revise_name.Visible= true;
                depart_revise_event.getinstance().tb_revise_head.Visible = true;
                depart_revise_event.getinstance().tb_revise_description.Visible = true;
                depart_revise_event.getinstance().btn_revise.Visible = true;
                depart_revise_event.getinstance().btn_search.Visible = true;
                Application.OpenForms["rivise_depart"].Close();
            }
        }
    }
}
