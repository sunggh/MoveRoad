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
    public partial class MessageForm : Form
    {
        MainForm main;
        public MessageForm(MainForm main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void TotitleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO `message`(`mto`,`mfrom`,`title`,`text`,`date`,`reads`) VALUES('" + ToBox.Text + "','" + this.main.me.id + "','" + TotitleBox.Text + "', '" + TotextBox.Text + "','" +DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+ "', '0')";
            DBConnetion.getInstance().Insert(sql);
            MessageBox.Show("성공적으로 전송 되었습니다.");
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
