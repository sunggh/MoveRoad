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
    public partial class Main : Form
    {
        private Point mousePoint;
 
        public Main()
        {
            InitializeComponent();
            DBConnetion.getInstance().getDBConnetion(); // 최초 DB서버 on/off 체크 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HRForm hR = new HRForm();
            hR.TopLevel = false;
            hR.Show();
            this.MainPanel.Controls.Clear();
            this.MainPanel.Controls.Add(hR);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.MainPanel.Controls.Clear();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            work work = new work();
            work.TopLevel = false;
            work.Show();
            this.MainPanel.Controls.Clear();
            this.MainPanel.Controls.Add(work);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
