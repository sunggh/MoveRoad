using MOVEROAD.Properties;
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
        public LoginForm()
        {
           
            InitializeComponent();
            if (Properties.Settings.Default.autoSet == 1)
            {
                autoSave.Checked = true;
                Loginid.Text = Properties.Settings.Default.idText;
                LoginPass.Text = Properties.Settings.Default.pwText;
            }
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM user where id = '" + Loginid.Text + "' and password = '" +LoginPass.Text+"'";
            UserInfo me = (UserInfo)DBConnetion.getInstance().Select(sql, 0);
            if (me != null)
            {
                if (autoSave.Checked)
                {
                    Properties.Settings.Default.autoSet = 1;
                    Properties.Settings.Default.idText = Loginid.Text;
                    Properties.Settings.Default.pwText = LoginPass.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.autoSet = 0;
                    Properties.Settings.Default.idText = "";
                    Properties.Settings.Default.pwText = "";
                    Properties.Settings.Default.Save();
                }
                MainForm change = new MainForm(me);
                this.Visible = false;
                change.ShowDialog();
            }
            else
            {
                MessageBox.Show("아이디 혹은 비밀번호를 확인 해주세요.");
            }

        }

        private void autoSave_CheckedChanged(object sender, EventArgs e)
        {

        }
        //pw에서 enter눌렀을 때 로그인
        private void LoginPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_button_Click(sender, e);
            } 
        }
    }
}
