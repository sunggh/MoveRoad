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
        public Departmanagement()
        {
            InitializeComponent();
            listview_departlist();
        }

        public void departGDV()
        {
            // 리스트 뷰 만들기
            // 클릭 이벤트 이용해서 부서에 대한 정보 표기하기
        }

        private void listview_departlist()
        {
            string query = "SELECT department.name as departname,user.name,department.description " +
                "FROM project.user,project.department " +
                "where user.index = department.manager";

            List<string> list;

            list = DBConnetion.getInstance().get_departlist(query);

            lv_depart.Items.Clear();
            lv_depart.BeginUpdate();

            ListViewItem item = new ListViewItem();

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
            depart_add_event add = new depart_add_event();
            add.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            depart_revise_event revise = new depart_revise_event();
            revise.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            depart_delete_event delete = new depart_delete_event();
            delete.ShowDialog();
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
    }
}
