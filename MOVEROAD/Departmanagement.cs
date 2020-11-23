using MOVEROAD.InfoFile;
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
    public partial class Departmanagement : Form
    {
        //private depart_add_event depart_add_event;

        private MainForm mf;

        public Departmanagement(MainForm mf)
        {
            InitializeComponent();

            this.mf = mf;
            listview_departlist();
        }

        public void listview_departlist()
        {
            string query = "SELECT department.name as departname,user.name,department.description " +
                "FROM project.user,project.department " +
                "where user.index = department.manager AND department.id != 99999";

            List<string> list;

            list = DBConnetion.getInstance().get_departlist(query);

            lv_depart.Items.Clear();
            lv_depart.BeginUpdate();

            ListViewItem item;

            for (int i = 0; i < list.Count; i = i + 3)
            {
                item = new ListViewItem(list[i]);
                item.SubItems.Add(list[i + 1]);
                item.SubItems.Add(list[i + 2]);
                lv_depart.Items.Add(item);
            }
            lv_depart.EndUpdate();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //새 폼 띄우고 ShowDialog로 다른행동 못하게 금지
            using (depart_add_event add = new depart_add_event(mf))
            {
                if (add.ShowDialog() == DialogResult.OK)
                {
                    //refresh
                    listview_departlist();
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            using (depart_revise_event revise = new depart_revise_event(mf))
            {
                if (revise.ShowDialog() == DialogResult.OK)
                {
                    //refresh
                    listview_departlist();
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lv_depart.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = lv_depart.SelectedItems;
                ListViewItem item = items[0]; // 클릭 한거
                string dpt_name = item.SubItems[0].Text;
                string manager = item.SubItems[1].Text;
                string description = item.SubItems[2].Text;

                //부서 삭제 시 부서장의 직급은 사원으로 내리고 그 부서에 속한 모든 부서원들은 미지정 부서로 이동하게 됨

                string manager_to_index = "SELECT * from project.user where name ='"+manager+"'";
                UserInfo user = (UserInfo)DBConnetion.getInstance().Select(manager_to_index, 0);

                //지금 삭제되는 부서 id값 찾아서 user index 조건으로
                string get_depart_id = "select * from department where `name` = '" + dpt_name + "'";
                DepartmentInfo dpt_info = (DepartmentInfo)DBConnetion.getInstance().Select(get_depart_id, 88);

                //이제 삭제되는 부서에 속한 모든 부서원들을 미지정 부서로 이동
                string update_query = "update `user` set `depart` = 0 where depart = '" + dpt_info.id + "'";
                DBConnetion.getInstance().Update(update_query);

                //department 테이블에서 지정된 부서의 정보를 delete함.
                string delete_query = "delete from department where `name` ='" + dpt_name + "' and `manager` = " + user.index + " and `description` = '" + description + "'";
                DBConnetion.getInstance().Delete(delete_query);

                

                listview_departlist();
            }
            //depart_delete_event delete = new depart_delete_event();
            //delete.ShowDialog();
        }

        private void lv_depart_Click(object sender, EventArgs e)
        {
            if (lv_depart.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = lv_depart.SelectedItems;
                ListViewItem item = items[0]; // 클릭 한거
                string dpt_name = item.SubItems[0].Text;
                string name = item.SubItems[1].Text;
                string description = item.SubItems[2].Text;

                tb_depart_name.Text = dpt_name;
                tb_depart_head.Text = name;
                tb_depart_description.Text = description;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (internal_mobility im = new internal_mobility(mf))
            {
                if (im.ShowDialog() == DialogResult.OK)
                {
                    //refresh
                    listview_departlist();
                }
            }
        }
    }
}
