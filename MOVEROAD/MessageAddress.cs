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
    public partial class MessageAddress : Form
    {
        MainForm main;
        private List<UserInfo> users = new List<UserInfo>();
        public MessageAddress(MainForm main)
        {
            InitializeComponent();
            this.main = main;
            string sql = "SELECT * FROM user";
            users = (List<UserInfo>)DBConnetion.getInstance().Select(sql, 100);
            
            viewMessageList();

        }
        private void viewMessageList()
        {
            listView3.Items.Clear();
            listView3.BeginUpdate();
            ListViewItem item;
            foreach (UserInfo user in users)
            {
                item = new ListViewItem();
                item.SubItems.Add(user.id);
                item.SubItems.Add(user.name);
                item.SubItems.Add(Convert.ToString(user.depart));

                listView3.Items.Add(item);
            }
            listView3.EndUpdate();
        }
     

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageForm mf = new MessageForm(main);
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Checked == true)
                {             
                    string sql = "SELECT * FROM user WHERE `index` = '" + users[i].index + "'";
                    DBConnetion.getInstance().Select(sql, 101);
                    address[0] = listView1.FocusedItem.SubItems[0].Text;
                    address[1] = listView1.FocusedItem.SubItems[1].Text;
                    address[2] = listView1.FocusedItem.SubItems[2].Text;
                    this.Dispose();
                
                }
               
            }
                      
        }
        */
        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "";

            if (textBoxSearch.Text == "")
            {
                sql = "SELECT * FROM user";
            }
            else 
            {
                sql = "SELECT * FROM user WHERE `name` = '" + textBoxSearch.Text + "'";
            }

            users = (List<UserInfo>)DBConnetion.getInstance().Select(sql, 100);                   
            viewMessageList();
        }

        public String[] address = { "", "", "" };
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
                address[0] = listView3.FocusedItem.SubItems[0].Text;
                address[1] = listView3.FocusedItem.SubItems[1].Text;
                address[2] = listView3.FocusedItem.SubItems[2].Text;
                this.Dispose();

         }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

      
    }

 }

