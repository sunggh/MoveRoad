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
    public partial class MessageBoxForm2 : Form
    {
        MainForm main;
        private List<Message> messages = new List<Message>();
        public MessageBoxForm2(MainForm main)
        {
            InitializeComponent();
            this.main = main;
            string sql = "SELECT * FROM message where mfrom = '" + main.me.id + "' and sendvisible = '1' "; // 보낸사람이 현재유저인 모든 쪽지 내용
            messages = (List<Message>)DBConnetion.getInstance().Select(sql, 6);
            viewMessageList();
        }

        private void viewMessageList()
        {
            listView1.Items.Clear();
            listView1.BeginUpdate();
            ListViewItem item;
            foreach (Message message in messages)
            {
                item = new ListViewItem();
                item.SubItems.Add(message.to_id);
                item.SubItems.Add(message.title);
                string str = "수신완료";
                if (message.reads == 0) str = "수신X";
                item.SubItems.Add(str);
                item.SubItems.Add(message.date.ToString("yyyy-MM-dd"));
                listView1.Items.Add(item);
            }
            listView1.EndUpdate();
        }

        private void listview1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int row = listView1.SelectedItems[0].Index;

            using (MessageSendInfo sendForm = new MessageSendInfo(messages[row]))
            {
                sendForm.ShowDialog();
            }
            messages[row].reads = 0;

            viewMessageList();
        }


        private void 받은쪽지ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            main.lastPanel.Dispose(); //이렇게 해야 메모리가 지워짐
            MessageBoxForm mb = new MessageBoxForm(this.main);
            mb.TopLevel = false;
            mb.Show();
            main.lastPanel = mb;
            main.MainPanel.Controls.Clear();
            main.MainPanel.Controls.Add(mb);
        }

        private void 보낸쪽지ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            main.lastPanel.Dispose();
            MessageBoxForm2 mb = new MessageBoxForm2(this.main);
            mb.TopLevel = false;
            mb.Show();
            main.lastPanel = mb;
            main.MainPanel.Controls.Clear();
            main.MainPanel.Controls.Add(mb);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Checked == true)
                {
                    string sql = "UPDATE `message` SET sendvisible ='0' WHERE (`id` = '" + messages[i].index + "')";


                    DBConnetion.getInstance().Update(sql);
                    listView1.Items[i].Remove();

                }
               
            }
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using (MessageForm message = new MessageForm(main))
            {
                message.ShowDialog();
            }
        }
    }
}
