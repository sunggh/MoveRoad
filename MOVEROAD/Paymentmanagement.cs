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
    public partial class Paymentmanagement : Form
    {
        private static Paymentmanagement instance_ = new Paymentmanagement();

        public static Paymentmanagement getinstance()
        {
            return instance_;
        }
        public Paymentmanagement()
        {
            InitializeComponent();
        }
    }
}
