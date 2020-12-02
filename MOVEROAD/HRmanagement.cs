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
        MainForm main;
        
        public HRManagement(MainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void buttonAddUsers_Click(object sender, EventArgs e)
        {
            // AddUsers 창으로 넘어가기
            AddUsers addUsers = new AddUsers(main);
            addUsers.TopLevel = false;
            addUsers.Show();
            HRpanel.Controls.Clear();
            HRpanel.Controls.Add(addUsers);
        }

        private void buttonSearchUsers_Click(object sender, EventArgs e)
        {
            // SearchUsers 창으로 넘어가기
            SearchUsers searchUsers = new SearchUsers(main);
            searchUsers.TopLevel = false;
            searchUsers.Show();
            HRpanel.Controls.Clear();
            HRpanel.Controls.Add(searchUsers);
        }

        private void buttonEditUsers_Click(object sender, EventArgs e)
        {
            // EditUsers 창으로 넘어가기
            EditUsers editUsers = new EditUsers(main);
            editUsers.TopLevel = false;
            editUsers.Show();
            HRpanel.Controls.Clear();
            HRpanel.Controls.Add(editUsers);
        }
    }
}
