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
    public partial class SearchUsers : Form
    {
        private static SearchUsers instance = new SearchUsers();
        public static SearchUsers getInstance()
        {
            return instance;
        }

        public SearchUsers()
        {
            InitializeComponent();
        }
        // 부서명, 성명, 나이 입력받아서 검색버튼 누르면 데이터 그리드뷰로 찾아주는 클래스
        // SELECT FROM WHERE 쓰믄댐
    }
}
