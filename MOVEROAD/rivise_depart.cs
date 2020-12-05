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
        depart_revise_event dre;
        public rivise_depart(depart_revise_event dre)
        {
            InitializeComponent();
            this.dre = dre;
            print_revising_users();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.OpenForms["rivise_depart"].Close();
        }

        public void print_revising_users()
        {
            string query = "SELECT `d`.`name`,`u`.`name` as `manager`,left(`d`.`description`,10) as `description` " +
                "FROM project.department as `d`,project.user as `u` " +
                "WHERE `d`.`manager` = `u`.`index` and `d`.`index`<99999";
            List<string> list;
            list = (List<string>)DBConnetion.getInstance().revise_userlist(query);
            
            lv_rivise.Items.Clear();
            lv_rivise.BeginUpdate();
            ListViewItem item;

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
                string index_to_head = "SELECT * FROM user where `name`= '" + manager + "' and `grade` = 1";
                user = (UserInfo)DBConnetion.getInstance().Select(index_to_head, 0);

                if (user == null)
                {
                    MessageBox.Show("인사 체계에 치명적 결함이 생겼습니다. 해당 부서에 문의하세요.");
                }
                else
                {
                    string description = item.SubItems[2].Text;

                    dre.tb_original_name.Text = name;
                    dre.tb_original_head.Text = user.name;
                    dre.tb_original_description.Text = description;

                    dre.lb_depart_name.Visible = true;
                    dre.lb_depart_head.Visible = true;
                    dre.lb_depart_description.Visible = true;
                    dre.tb_revise_name.Visible = true;
                    dre.tb_revise_head.Visible = true;
                    dre.tb_revise_description.Visible = true;
                    dre.btn_revise.Visible = true;
                    dre.btn_search.Visible = true;
                    this.Dispose();
                }
            }
        }
    }
}
