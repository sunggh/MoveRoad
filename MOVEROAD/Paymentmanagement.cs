﻿using System;
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
        HRForm hr;

        public Paymentmanagement(HRForm hr)
        {
            this.hr = hr;
            InitializeComponent();
        }
    }
}
