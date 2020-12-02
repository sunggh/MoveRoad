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
    public partial class MessageSendInfo : Form
    {
        MainForm main;
        Message Message;
        public MessageSendInfo(Message message)
        {
            InitializeComponent();
            Message = message;
            FromBox.Text = message.to_id;
            FromtitleBox.Text = message.title;
            FromtextBox.Text = message.messege;
            time.Text = message.date.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
