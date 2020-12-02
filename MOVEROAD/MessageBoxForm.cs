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
    public partial class MessageBoxForm : Form
    {
        MainForm main;
        private List<Message> messages = new List<Message>();
      
        public MessageBoxForm(MainForm main)
        {
            
            InitializeComponent();
            this.main = main;
            string sql = "SELECT * FROM message where mto = '" + main.me.id + "' and receivevisible ='1' "; // 받는사람이 현재유저인 모든 쪽지 내용
            messages = (List<Message>)DBConnetion.getInstance().Select(sql, 6);
            viewMessageList();
            //  colorListViewHeader(ref listView1, Color.FromArgb(70, 71, 117), Color.White);

        }
        private void viewMessageList()
        {
            listView1.Items.Clear();
            listView1.BeginUpdate();
            ListViewItem item;
            foreach (Message message in messages)
            {
                item = new ListViewItem();
                item.SubItems.Add(message.from_id);
                item.SubItems.Add(message.title);
                string str = "읽음";
                if (message.reads == 0) str = "읽지X";
                item.SubItems.Add(str);
                item.SubItems.Add(message.date.ToString("yyyy-MM-dd"));
                listView1.Items.Add(item);
            }
            listView1.EndUpdate();
        }

       
        public static void colorListViewHeader(ref ListView list, Color backColor, Color foreColor)
        {
            list.OwnerDraw = true;
            list.DrawColumnHeader +=
                new DrawListViewColumnHeaderEventHandler
                (
                    (sender, e) => headerDraw(sender, e, backColor, foreColor)
                );
            list.DrawItem += new DrawListViewItemEventHandler(bodyDraw);
        }

        private static void headerDraw(object sender, DrawListViewColumnHeaderEventArgs e, Color backColor, Color foreColor)
        {
            using (SolidBrush backBrush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(backBrush, e.Bounds);
            }

            using (SolidBrush foreBrush = new SolidBrush(foreColor))
            {
                e.Graphics.DrawString(e.Header.Text, e.Font, foreBrush, e.Bounds);
            }
        }

        private static void bodyDraw(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            
            
             if (e.ColumnIndex == 0) 
             {
                e.DrawBackground();
                bool value = false; 
                 try { 
                     value = Convert.ToBoolean(e.Header.Tag); 
                 } catch (Exception) { 
                 } 
                 CheckBoxRenderer.DrawCheckBox(e.Graphics, new Point(e.Bounds.Left + 4, e.Bounds.Top + 4), value ? System.Windows.Forms.VisualStyles.CheckBoxState.CheckedNormal : System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal); 
             } else {
                
                e.DrawDefault = true;
            }
             
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnRead_Click(object sender, EventArgs e)  // 직접 메시지를 수신하지 않아도 읽음처리 가능
        {

            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Checked == true)
                {
                    string sql = "UPDATE `message` SET `reads` = '1' WHERE (`id` = '" + messages[i].index + "')";


                    DBConnetion.getInstance().Update(sql);
                    messages[i].reads = 1;
                   

                }             
            }
            viewMessageList();
            

        }  

        private void btnNew_Click(object sender, EventArgs e)
        {
            using (MessageForm message = new MessageForm(main))
            {
                message.ShowDialog();
            }
                
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int row = listView1.SelectedItems[0].Index;
            
            using (MessageReceiveForm receiveForm = new MessageReceiveForm(messages[row]))
            {
                receiveForm.ShowDialog();
            }
            if(messages[row].reads == 0)
            {
                string sql = "UPDATE `message` SET `reads` = '1' WHERE (`id` = '"+ messages[row].index+ "')";
                DBConnetion.getInstance().Update(sql);
 
            }
            messages[row].reads = 1;
            
            viewMessageList();
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }
        
        private void btnDelete_Click(object sender, EventArgs e) // 삭제
        {            
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {                       
                if (listView1.Items[i].Checked == true )
                {                
                    string sql = "UPDATE `message` SET receivevisible ='0' WHERE (`id` = '" + messages[i].index + "')";

                   
                    DBConnetion.getInstance().Update(sql);
                    listView1.Items[i].Remove();
                  
                }
                
            }
            main.lastPanel.Dispose(); 
            MessageBoxForm mb = new MessageBoxForm(this.main);
            mb.TopLevel = false;
            mb.Show();
            main.lastPanel = mb;
            main.MainPanel.Controls.Clear();
            main.MainPanel.Controls.Add(mb);
        }
        
        private void pictureBoxRegistrantSearch_Click(object sender, EventArgs e) // 검색
        {

            string id = main.me.id;             //현재 유저 id 값
            string from = Fromsearch.Text;      //보낸사람 
            string title = titlesearch.Text;    //제목
            string text = textsearch.Text;      //내용
            string sql = "";
            string empty = "";



            if (from == empty && title == empty && text == empty) // 모두검색(세개다 입력 X)
            {
                sql = "SELECT * FROM message where mto = '" + id + "'";
            }
            if (from != empty && title != empty && text != empty) // 보낸사람+제목+내용 검색
            {
                sql = "SELECT * FROM message where mto = '" + id + "' and mfrom='" + from + "'" +
                   "and title like '%" + title + "%' and text like '%" + text + "%'";
            }


            if (from == empty && title != empty && text != empty) // 제목 + 내용 검색
            {
                sql = "SELECT * FROM message where mto = '" + id + "' and " +
                   " title like '%" + title + "%' and text like '%" + text + "%'";
            }
            if (title == empty && from != empty && text != empty)// 보낸사람 + 내용 검색
            {
                sql = "SELECT * FROM message where mto = '" + id + "' and mfrom='" + from + "'" +
                   "and  text like '%" + text + "%'";
            }
            if (text == empty && from != empty && title != empty)// 보낸사람 + 제목 검색
            {
                sql = "SELECT * FROM message where mto = '" + id + "' and mfrom='" + from + "'" +
                   "and title like '%" + title + "%' ";
            }



            if (from == empty && title == empty && text != empty) // 내용검색
            {
                sql = "SELECT * FROM message where mto = '" + id + "' and text like '%" + text + "%'";
            }
           if (from == empty && text == empty && title != empty)  // 제목검색
            {
                sql = "SELECT * FROM message where mto = '" + id + "' and title like '%" + title + "%'";
            }
            if (title == empty && text == empty && from != empty)// 보낸사람검색
            {
                sql = "SELECT * FROM message where mto = '" + id + "' and mfrom='" + from + "'";
            }

            messages = (List<Message>)DBConnetion.getInstance().Select(sql, 6);
            viewMessageList();
        }

        private void 보낸쪽지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main.lastPanel.Dispose(); //이렇게 해야 메모리가 지워짐
            MessageBoxForm2 mb = new MessageBoxForm2(this.main);
            mb.TopLevel = false;
            mb.Show();
            main.lastPanel = mb;
            main.MainPanel.Controls.Clear();
            main.MainPanel.Controls.Add(mb);
        }

        private void 받은쪽지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main.lastPanel.Dispose(); //이렇게 해야 메모리가 지워짐
            MessageBoxForm mb = new MessageBoxForm(this.main);
            mb.TopLevel = false;
            mb.Show();
            main.lastPanel =mb;
            main.MainPanel.Controls.Clear();
            main.MainPanel.Controls.Add(mb);
        }
    }
}
