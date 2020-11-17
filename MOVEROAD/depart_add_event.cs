using MOVEROAD.InfoFile;
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
    public partial class depart_add_event : Form
    {
        private MainForm mf;

        public depart_add_event(MainForm mf)
        {
            InitializeComponent();

            this.mf = mf;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            UserInfo user;
            string depart_name = tb_depart_name.Text;

            string depart_head = tb_depart_head.Text;
            string head_to_index = "SELECT * FROM user where `name`= '"+depart_head+"'";
            user = (UserInfo)DBConnetion.getInstance().Select(head_to_index,0);

            string depart_memo = tb_depart_memo.Text;
            string add_query = "insert into department(`name`,`manager`,`description`) values ('"+depart_name+"',"+user.index+",'"+depart_memo+"')";
            DBConnetion.getInstance().Insert(add_query);

            string id_search = "select id from department where name = '"+depart_name+"'";

            int department_id = (int)DBConnetion.getInstance().Select(id_search, 10);

            mf.departments.Add(new DepartmentInfo(department_id, depart_name, user.index , depart_memo));

            MessageBox.Show("정상적으로 등록되었습니다.");

            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (search_head search = new search_head())
            {
                search.ShowDialog();
                tb_depart_head.Text = search.name_;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tb_depart_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_depart_head_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
