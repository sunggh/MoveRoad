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
    public partial class Messenger : Form
    {
        MainForm main;
        public UserInfo to_user = null;
        public Messenger(MainForm main)
        {
            InitializeComponent();
            this.main = main;
            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.HorizontalScroll.Enabled = false;
            flowLayoutPanel1.AutoScroll = true;

        }
        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            SetTextBoxClientSize(sender as TextBox);
        }// textbox 크기 자동 조정1


        public void SetTextBoxClientSize(TextBox textBox)
        {
            const int MARGIN_X = 0;
            const int MARGIN_Y = 1;


            Size size = TextRenderer.MeasureText(textBox.Text, textBox.Font);
            textBox.ClientSize = new Size(size.Width + MARGIN_X, size.Height + MARGIN_Y);
            textBox.Multiline = true;

        }  // textbox 크기 자동 조정2
        private void nameBOX_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                flowLayoutPanel1.Controls.Clear();
                if (nameBOX.Text == "")
                {
                    return;
                }
                int check = 0;
                foreach (var user in main.onlines.Values)
                {
                    if(user.name == nameBOX.Text)
                    {
                        to_user = user;
                        
                        check = 1;
                    }
                }
                if (check == 0)
                {
                    MessageBox.Show("해당 인원은 오프라인입니다.");
                    to_user = null;
                    return;
                }
                foreach (var room in main.room)
                {
                    if(room.Value == to_user.index)
                    {
                        main.room_id = room.Key;
                        break;
                    }
                }
                if(!main.room_msg.ContainsKey(to_user))
                {
                    string message = "2|" + main.me.index + "|" + to_user.index;
                    byte[] buffer = Encoding.Unicode.GetBytes(message);
                    main.stream.Write(buffer, 0, buffer.Length);
                    main.stream.Flush();
                } 
                else
                {
                    flowLayoutPanel1.Controls.Clear();
                    foreach (var msgs in main.room_msg[to_user])
                    {
                        addchat(msgs);
                    }
                }
                
            }
        }
        public void addchat(string msg)
        {
            Panel panel = new Panel();
            Panel panel2 = new Panel();
            TextBox textBox = new TextBox();
            SetTextBoxClientSize(textBox);
            textBox.ScrollBars = ScrollBars.None;
            textBox.TextChanged += textBox2_TextChanged;
            string[] str = msg.Split(new string[] { "|" }, StringSplitOptions.None);
            textBox.Text = str[1];
            textBox.Location = new Point(10, 10);
            if (str[0] == "나")
            {
                textBox.Dock = DockStyle.Right;
            }
            else
            {
                textBox.Dock = DockStyle.Left;
            }

            panel.Controls.Add(textBox);
            panel.Size = new Size(640, 30);
            panel.Dock = DockStyle.Top;
            panel2.Size = new Size(640, 10);
            panel2.Dock = DockStyle.Top;
            flowLayoutPanel1.Controls.Add(panel);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.AutoScrollPosition = new Point(0, flowLayoutPanel1.DisplayRectangle.Height);
        }
        private void text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (to_user == null)
                {
                    MessageBox.Show("상대방이 오프라인입니다.");
                    text.Text = "";
                    return;
                }
                if (!main.onlines.ContainsKey(to_user.index))
                {
                    MessageBox.Show("상대방이 오프라인입니다.");
                    text.Text = "";
                    return;
                }
                if(text.Text == "")
                {       
                    return;
                }
                string message = text.Text;
                main.room_msg[to_user].Add("나|" + message);
                addchat("나|" + message);
                message = "3|" + main.room_id + "|" + to_user.index+ "|" + message;
                byte[] buffer = Encoding.Unicode.GetBytes(message);
                main.stream.Write(buffer, 0, buffer.Length);
                main.stream.Flush();
                text.Text = "";
            }
        }
    }
}
