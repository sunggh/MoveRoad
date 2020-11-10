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
    public partial class Departmanagement : Form
    {
        private static Departmanagement instance_ = new Departmanagement();

        public static Departmanagement getinstance()
        {
            return instance_;
        }

        public Departmanagement()
        {
            instance_ = this;
            InitializeComponent();
        }

        public void departGDV()
        {
            //user 테이블 이용해서 그리드뷰 만들기
        }
    }
}
