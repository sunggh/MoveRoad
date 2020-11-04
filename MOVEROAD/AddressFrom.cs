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
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void AddressFrom_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Address> addresses = new List<Address>();
            addresses = AddressFinder.getInstance().getZoneList(textBox1.Text);
            foreach (Address address in addresses)
            {
                listBox1.Items.Add((string)(address.placename + "(" + address.zonenumber + ")"));
            }
        }
    }
}
