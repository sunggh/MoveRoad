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
    public partial class TaskForm : Form
    {
        MainForm main;
        public TaskForm(MainForm main)
        {
            InitializeComponent();
            this.main = main;
        }
    }
}
