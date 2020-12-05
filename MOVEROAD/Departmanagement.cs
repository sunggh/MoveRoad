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
            string query = "SELECT department.name as departname,user.name,left(department.`description`,10) as `description`  " +
                "FROM project.user,project.department " +
                "where user.index = department.manager AND department.index != 99999";

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
            mf.TransparencyKey = Color.Gray;
            mf.Opacity = 0.5;
            using (depart_add_event add = new depart_add_event(mf))
            {
                if (add.ShowDialog() == DialogResult.OK)
                {
                    //refresh
                    listview_departlist();
                }
            }
            mf.Opacity = 1;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            mf.TransparencyKey = Color.Gray;
            mf.Opacity = 0.5;
            using (depart_revise_event revise = new depart_revise_event(mf))
            {
                if (revise.ShowDialog() == DialogResult.OK)
                {
                    //refresh
                    listview_departlist();
                }
            }
            mf.Opacity = 1;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lv_depart.SelectedItems.Count == 1)
            {
                if (MessageBox.Show("정말 삭제 하시겠습니까?", "부서정보 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ListView.SelectedListViewItemCollection items = lv_depart.SelectedItems;
                    ListViewItem item = items[0]; // 클릭 한거
                    string dpt_name = item.SubItems[0].Text; // 부서명
                    string manager = item.SubItems[1].Text; // 부서장으로 선택된 사람의 이름

                    //먼저 부서명을 통해(부서명은 중복될 일이 없으니) 부서정보를 받아오기
                    string get_depart_id = "select * from department where `name` = '" + dpt_name + "'";
                    DepartmentInfo dpt_info = (DepartmentInfo)DBConnetion.getInstance().Select(get_depart_id, 88);

                    //삭제될 부서의 부서장을 user에서 찾아 정보 받아오기
                    string manager_to_index = "SELECT * from project.user where name ='" + manager + "' and depart = '" + dpt_info.id + "' and grade = 1";
                    UserInfo user = (UserInfo)DBConnetion.getInstance().Select(manager_to_index, 0);

                    //1.
                    //department 테이블에서 지정된 부서의 정보를 delete함.
                    string delete_query = "delete from department where `name` ='" + dpt_name + "' and `index` = '" + dpt_info.id + "'";
                    DBConnetion.getInstance().Delete(delete_query);

                    //2.
                    //부서 삭제 시 부서장의 직급은 사원으로 내리고 그 부서에 속한 모든 부서원들은 미지정 부서로 이동하게 됨
                    string update_user_query = "update `user` set `grade` = 2 where `index` = " + user.index;
                    DBConnetion.getInstance().Update(update_user_query);

                    //3.
                    //이제 삭제되는 부서에 속한 모든 부서원들을 미지정 부서로 이동
                    string update_query = "update `user` set `depart` = 0 where depart = '" + dpt_info.id + "'";
                    DBConnetion.getInstance().Update(update_query);

                    tb_depart_name.Text = "";
                    tb_depart_head.Text = "";
                    tb_depart_description.Text = "";

                    listview_departlist();
                    return;
                }
                else
                {
                    MessageBox.Show("취소 되었습니다.", "삭제 취소");
                    return;
                }
            }
            else
            {
                MessageBox.Show("삭제할 부서를 클릭 후 다시 시도하세요.");
            }
        }

        private void lv_depart_Click(object sender, EventArgs e)
        {
            if (lv_depart.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = lv_depart.SelectedItems;
                ListViewItem item = items[0]; // 클릭 한거
                string dpt_name = item.SubItems[0].Text;
                string name = item.SubItems[1].Text;

                //설명 뽑기
                string get_ds = "select description as `name` from department where name = '" + dpt_name + "'";
                string ds = (string)DBConnetion.getInstance().Select(get_ds, 3);
                string description = ds;

                tb_depart_name.Text = dpt_name;
                tb_depart_head.Text = name;
                tb_depart_description.Text = description;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mf.TransparencyKey = Color.Gray;
            mf.Opacity = 0.5;
            using (internal_mobility im = new internal_mobility(mf))
            {
                if (im.ShowDialog() == DialogResult.OK)
                {
                    //refresh
                    listview_departlist();
                }
            }
            mf.Opacity = 1;
        }
    }
}
