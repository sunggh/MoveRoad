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
    public partial class EditUsers : Form
    {
        private static EditUsers instance = new EditUsers();
        public static EditUsers getInstance()
        {
            return instance;
        }

        public EditUsers()
        {
            InitializeComponent();
        }
        // 데이터 그리드뷰로 첨부터 사원목록 다 보여주고 한놈 클릭하면 팝업창으로 금마 정보 수정할수있게끔 만들믄댐
    }
}
