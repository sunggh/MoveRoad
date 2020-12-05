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
    public partial class search_departname : Form
    {
        public string dpt_name_;

        public search_departname()
        {
            InitializeComponent();
            print_lv_dpt_name();
        }

        public void print_lv_dpt_name()
        {
            //이름과 부서를 뽑아내기
            string get_name_and_dpt = "select `name` from department where `index` != 99999";

            List<string> list;
            list = (List<string>)DBConnetion.getInstance().dpt_id_and_name(get_name_and_dpt,1);
            lv_dpt_name.Items.Clear();
            lv_dpt_name.BeginUpdate();
            ListViewItem item;

            for (int i = 0; i < list.Count; i++)
            {
                item = new ListViewItem(list[i]);
                lv_dpt_name.Items.Add(item);
            }
            lv_dpt_name.EndUpdate();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lv_dpt_name_DoubleClick(object sender, EventArgs e)
        {
            if (lv_dpt_name.SelectedItems.Count == 1)
            {
                ListView.SelectedListViewItemCollection items = lv_dpt_name.SelectedItems;
                ListViewItem item = items[0];
                string dpt_name = item.SubItems[0].Text; 

                dpt_name_ = dpt_name;


                this.Dispose();
            }
        }
    }
}
