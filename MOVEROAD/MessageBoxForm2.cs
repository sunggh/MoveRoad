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
            main.lastPanel.Dispose(); //이렇게 해야 메모리가 지워짐
            MessageBoxForm2 mb = new MessageBoxForm2(this.main);
            mb.TopLevel = false;
            mb.Show();
            main.lastPanel = mb;
            main.MainPanel.Controls.Clear();
            main.MainPanel.Controls.Add(mb);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using (MessageForm message = new MessageForm(main))
            {
                message.ShowDialog();
            }
        }

        private void pictureBoxRegistrantSearch_Click(object sender, EventArgs e)
        {
            string id = main.me.id;             //현재 유저 id 값
            string from = Fromsearch.Text;      //보낸사람 
            string title = titlesearch.Text;    //제목
            string text = textsearch.Text;      //내용
            string sql = "";
            string empty = "";



            if (from == empty && title == empty && text == empty) // 모두검색(세개다 입력 X)
            {
                sql = "SELECT * FROM message where mfrom = '" + id + "' and sendvisible = '1'";
            }
            if (from != empty && title != empty && text != empty) // 보낸사람+제목+내용 검색
            {
                sql = "SELECT * FROM message where mfrom = '" + id + "' and mto='" + from + "'" +
                   "and title like '%" + title + "%' and text like '%" + text + "%'and sendvisible = '1'";
            }


            if (from == empty && title != empty && text != empty) // 제목 + 내용 검색
            {
                sql = "SELECT * FROM message where mfrom = '" + id + "' and " +
                   " title like '%" + title + "%' and text like '%" + text + "%'and sendvisible = '1'";
            }
            if (title == empty && from != empty && text != empty)// 보낸사람 + 내용 검색
            {
                sql = "SELECT * FROM message where mfrom = '" + id + "' and mto='" + from + "'" +
                   "and  text like '%" + text + "%'and sendvisible = '1'";
            }
            if (text == empty && from != empty && title != empty)// 보낸사람 + 제목 검색
            {
                sql = "SELECT * FROM message where mfrom = '" + id + "' and mto='" + from + "'" +
                   "and title like '%" + title + "%' and sendvisible = '1'";
            }



            if (from == empty && title == empty && text != empty) // 내용검색
            {
                sql = "SELECT * FROM message where mfrom = '" + id + "' and text like '%" + text + "%'and sendvisible = '1'";
            }
            if (from == empty && text == empty && title != empty)  // 제목검색
            {
                sql = "SELECT * FROM message where mfrom = '" + id + "' and title like '%" + title + "%'and sendvisible = '1'";
            }
            if (title == empty && text == empty && from != empty)// 보낸사람검색
            {
                sql = "SELECT * FROM message where mfrom = '" + id + "' and mto='" + from + "'and sendvisible = '1'";
            }

            messages = (List<Message>)DBConnetion.getInstance().Select(sql, 6);
            viewMessageList();
        }
    }
}
