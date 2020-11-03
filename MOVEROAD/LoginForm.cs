using MySql.Data.MySqlClient;
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
    public partial class LoginForm : Form
    {
        public MySqlConnection conn = DBConnetion.getInstance().getDBConnetion();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM account where id = '" + Loginid.Text + "' and password = '" +LoginPass.Text+"'";
            int index = (int) DBConnetion.getInstance().Select(sql, 0);

            if (index != -1)
            {
                sql = "SELECT * FROM user where accountid = '" + index + "'";
                UserInfo me = (UserInfo) DBConnetion.getInstance().Select(sql, 1);
                MainForm change = new MainForm(me);
                this.Visible = false;
                change.ShowDialog();
            }
            else
            {
                MessageBox.Show("아이디 혹은 비밀번호를 확인 해주세요.");
            }
        }
    }
}
