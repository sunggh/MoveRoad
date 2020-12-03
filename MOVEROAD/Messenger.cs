using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOVEROAD
{
    public partial class Messenger : Form
    {
        MainForm main;
        public UserInfo to_user = null;
        private BackgroundWorker backgroundWorker;
        public Dictionary<int, UserInfo> onlines;
        public int select = -1;
        public Messenger(MainForm main)
        {
            InitializeComponent();
            this.main = main;
            onlines = new Dictionary<int, UserInfo>(this.main.onlines);
            flowLayoutPanel1.AutoScroll = false;
            flowLayoutPanel1.HorizontalScroll.Enabled = false;
            flowLayoutPanel1.AutoScroll = true;
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += new DoWorkEventHandler(BackgroundWorkerDoWork);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackgroundWorkerRunWorkerCompleted);
            backgroundWorker.RunWorkerAsync();
        }
        private void BackgroundWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            
            if (onlines.SequenceEqual(this.main.onlines))
            {
                e.Result = (bool)true;
            }
            else
            {
                e.Result = (bool)false;
            }
            Thread.Sleep(10);
        }
        private void BackgroundWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((bool)e.Result)
            {
               
            }
            else
            {
                loadUserList();
                onlines = new Dictionary<int, UserInfo>(this.main.onlines);
            }
            backgroundWorker.RunWorkerAsync();
        }
        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            SetTextBoxClientSize(sender as TextBox);
        }// textbox 크기 자동 조정1

        public void loadUserList()
        {
            onlineList.Items.Clear();
            foreach (var user in this.main.onlines)
            {
                onlineList.Items.Add(user.Value.name + "(" + user.Value.index + ")");
            }
        }
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
           /* if (e.KeyCode == Keys.Enter)
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
            }*/
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
            panel.Size = new Size(490, 30);
            panel.Dock = DockStyle.Top;
            panel2.Size = new Size(490, 10);
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
                    loadUserList();
                    return;
                }
                if (!main.onlines.ContainsKey(to_user.index))
                {
                    MessageBox.Show("상대방이 오프라인입니다.");
                    text.Text = "";
                    return;
                }
                if(main.room_id == -1)
                {
                    MessageBox.Show("상대방이 종료를 한번 하여 사라진 방입니다. 상대방을 다시 눌러주세요.");
                    return;
                }
                if (nameBOX.Text == "")
                {
                    MessageBox.Show("상대방이 종료를 한번 하여 사라진 방입니다. 상대방을 다시 눌러주세요.");
                    return;
                }
                if (text.Text == "")
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
        public UserInfo getToUser(int index)
        {
            int i = 0;
            foreach (var touser in main.onlines)
            {
                if (index == i)
                {
                    to_user = touser.Value;
                    break;
                }
                i++;
            }
            return to_user;
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void nameBOX_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void onlineList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            select = onlineList.SelectedIndex;
            if (select == -1) return;
            int i = 0;
            int check = 0;
            foreach (var touser in main.onlines)
            {
                if (select == i)
                {
                    to_user = touser.Value;
                    check = 1;
                    break;
                }
                i++;
            }
            flowLayoutPanel1.Controls.Clear();
            if (check == 0)
            {
                MessageBox.Show("해당 인원은 오프라인입니다.");
                to_user = null;
                loadUserList();
                return;
            }
            nameBOX.Text = to_user.name+to_user.index;
            foreach (var room in main.room)
            {
                if (room.Value == to_user.index)
                {
                    main.room_id = room.Key;
                    break;
                }
            }
            if (!main.room_msg.ContainsKey(to_user))
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
}
