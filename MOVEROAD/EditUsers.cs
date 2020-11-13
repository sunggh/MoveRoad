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
            DataShow();
        }

        private void DataShow()
        {
            string query = "SELECT `index` AS `No.`, depart AS 부서명, grade AS 직위, name AS 이름, age AS 나이, gender AS 성별, phone AS `H.P`, address AS 주소 FROM `user`";
            DataTable table = DBConnetion.getInstance().getDBTable(query);
            
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // 데이터 그리드뷰로 첨부터 사원목록 다 보여주고 한놈 클릭하면 팝업창으로 금마 정보 수정할수있게끔 만들믄댐
    }
}
