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

        public int depart;
        public string name;
        public int age;

        public SearchUsers()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.depart = comboBoxDepart.SelectedIndex;
            this.name = textBoxName.Text;
            this.age = Convert.ToInt32(textBoxAge.Text);

            DataShow_Search();
        }

        private void DataShow_Search()
        {
            string query = "SELECT `index` AS `No.`, depart AS 부서명, grade AS 직위, name AS 이름, age AS 나이, gender AS 성별, phone AS `H.P`, address AS 주소 FROM `user`" +
                "WHERE `depart` = '" + depart + "' AND `name` = '" + name + "' AND `age` = '" + age + "'";
            DataTable table = DBConnetion.getInstance().getDBTable(query);
            dataGridView1.DataSource = table;
        }
        // 부서명, 성명, 나이 입력받아서 검색버튼 누르면 데이터 그리드뷰로 찾아주는 클래스
        // SELECT FROM WHERE 쓰믄댐
    }
}
