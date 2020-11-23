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
    public partial class MessageReceiveForm : Form
    {
        Message Message;
        public MessageReceiveForm(Message message)
        {
            InitializeComponent();
            Message = message;
            FromBox.Text = message.from_id;
            FromtitleBox.Text = message.title;
            FromtextBox.Text = message.messege;
            time.Text = message.date.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnReply_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }
    }
}
