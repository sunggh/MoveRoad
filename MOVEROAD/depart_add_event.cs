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
    public partial class depart_add_event : Form
    {
        public depart_add_event()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.OpenForms["depart_add_event"].Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string depart_name = tb_depart_name.Text;
            string depart_
            string add_query = "insert into department(name,manager) values ()"
            DBConnetion
        }
    }
}
