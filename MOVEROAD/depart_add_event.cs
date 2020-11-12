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
        private static depart_add_event instance = new depart_add_event();

        public static depart_add_event getinstance()
        {
            return instance;
        }
        public depart_add_event()
        {
            instance = this;
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.OpenForms["depart_add_event"].Close();
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

            MessageBox.Show("정상적으로 등록되었습니다.","확인");
            Application.OpenForms["depart_add_event"].Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search_head search = new search_head(0);
            search.ShowDialog();
        }
    }
}
