using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOVEROAD
{
    public partial class search_head : Form
    {
        int set = 9999;
        public search_head(int set)
        {
            InitializeComponent();
            print_search_users();
            this.set = set;
        }

        public void print_search_users()
        {
            string query = "select * from user";
            List<string> list;
            list = (List<string>)DBConnetion.getInstance().search_userlist(query);
            lv_searching.Items.Clear();
            lv_searching.BeginUpdate();
            ListViewItem item = new ListViewItem();

            for (int i = 0; i < list.Count; i=i+2)
            {
                item = new ListViewItem(list[i]);
                item.SubItems.Add(list[i + 1]);
                lv_searching.Items.Add(item);
            }
            lv_searching.EndUpdate();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.OpenForms["search_head"].Close();
        }

        private void lv_searching_DoubleClick(object sender, EventArgs e)
        {
            if(lv_searching.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = lv_searching.SelectedItems;
                ListViewItem item = items[0];
                string name = item.SubItems[0].Text;

                if (set == 0)
                {
                    depart_add_event.getinstance().tb_depart_head.Text = name;
                } else if(set == 1)
                {
                    depart_revise_event.getinstance().tb_revise_head.Text = name;
                }
                Application.OpenForms["search_head"].Close();
            }
        }
    }
}
