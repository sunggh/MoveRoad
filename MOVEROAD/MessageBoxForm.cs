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
            string sql = "SELECT * FROM message where mto = '" + main.me.name + "'";
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
                item.SubItems.Add(message.from_name);
                item.SubItems.Add(message.title);
                string str = "읽음";
                if (message.reads == 0) str = "읽지X";
                item.SubItems.Add(str);
                item.SubItems.Add(message.date.ToString("yyyy-MM-dd"));
                listView1.Items.Add(item);
            }
            listView1.EndUpdate();
        }

        private void 보낸쪽지ToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void btnRead_Click(object sender, EventArgs e)
        {
            
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
    }
}
