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
        //int set = 9999;

        public string name_;

        public search_head()
        {
            InitializeComponent();
            print_search_users();
            //this.set = set;
        }

        public void print_search_users()
        {
            //string first_query = "select `name`, `grade` from project.user where ";

            string query = "SELECT `name`, CASE `grade` WHEN 0 THEN '사장' WHEN 1 THEN '부서장' WHEN 2 THEN '사원' END AS `grade` FROM project.user where `grade` = 2";
            List<string> list;
            list = (List<string>)DBConnetion.getInstance().search_userlist(query);
            lv_searching.Items.Clear();
            lv_searching.BeginUpdate();
            ListViewItem item;

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
            if (lv_searching.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = lv_searching.SelectedItems;
                ListViewItem item = items[0];
                string name = item.SubItems[0].Text; // 부서 이름


                //depart_add_event.getinstance().tb_depart_head.Text = name;
                name_ = name;

                //depart_revise_event.getinstance().tb_revise_head.Text = name;

                this.Dispose();
            }
        }

        private void lv_searching_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
