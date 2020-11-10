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
    public partial class HRManagement : Form
    {
        private static HRManagement instance = new HRManagement();
        public static HRManagement getInstance()
        {
            return instance;
        }

        public HRManagement()
        {
            InitializeComponent();
        }

        private void buttonAddUsers_Click(object sender, EventArgs e)
        {
            // AddUsers 창으로 넘어가기
        }

        private void buttonSearchUsers_Click(object sender, EventArgs e)
        {
            // SearchUsers 창으로 넘어가기
        }

        private void buttonEditUsers_Click(object sender, EventArgs e)
        {
            // EditUsers 창으로 넘어가기
        }
    }
}
