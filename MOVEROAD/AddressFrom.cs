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
    public partial class AddressFrom : Form
    {
        public AddressFrom()
        {
            InitializeComponent();
            listView1.Columns[1].Width = 750;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void AddressFrom_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Columns.Count; i++)
            {
                listView1.Columns[i].TextAlign = HorizontalAlignment.Center;
                listView1.Columns[i].Width = -2;
            }

        }
        List<Address> addresses = new List<Address>();
        private void button1_Click(object sender, EventArgs e)
        {
            
            addresses = AddressFinder.getInstance().getZoneList(textBox1.Text);
            listView1.Items.Clear();
            listView1.BeginUpdate();
            ListViewItem item;
            foreach (Address address in addresses)
            {
                item = new ListViewItem(Convert.ToString(address.zonenumber));
                item.SubItems.Add(address.roadname+" ("+address.placename+")");
                listView1.Items.Add(item);
            }//road_address_name
            listView1.EndUpdate();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
            if (textBox1.Text == "주소를 입력 해주세요.")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if(textBox1.Text == "주소를 입력 해주세요.")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }
       public String[] address = {"",""};
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView.SelectedListViewItemCollection items = listView1.SelectedItems;
            address[0] = listView1.FocusedItem.SubItems[0].Text;
            address[1] = listView1.FocusedItem.SubItems[1].Text;
            this.Dispose();

        }
    }
}
