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
    public partial class PaymentForm : Form
    {
        private static PaymentForm instance_ = new PaymentForm();

        public static PaymentForm getinstance()
        {
            return instance_;
        }
        public PaymentForm()
        {
            InitializeComponent();
        }
    }
}
