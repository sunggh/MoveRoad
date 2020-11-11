using MySql.Data.MySqlClient;
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
    public partial class AddUsers : Form
    {
        private static AddUsers instance = new AddUsers();
        public static AddUsers getInstance()
        {
            return instance;
        }

        public int depart;
        public int grade;
        public int age;
        public string id;
        public string password;
        public string name;
        public int gender;
        public string phone;
        public string address;
        
        public AddUsers()
        {
            InitializeComponent();
            DataShow();
        }

        private void AddNewcomer()
        {
            // 현재 입력된 정보들을 DB에 추가하는 함수
            // TABLE, COLUMN은 ` ` VALUES는 ' ' 주의
            // INSERT INTO `TABLE`(`column`, `column`, ...) VALUES ('string', 숫자, ...);
            string query = "INSERT INTO `user`(`depart`, `grade`, `age`, `id`, `password`, `name`, `gender`, `phone`, `address`)" +
                " VALUES (" + depart + ", " + grade + ", " + age + ", '" + id + "', '" + password + "', '" + name + "', " + gender + ", '" + phone + "', '" + address + "')";
            DBConnetion.getInstance().Insert(query);
        }
        
        private void DataShow()
        {
            string query = "SELECT depart, grade, name, age, gender, phone, address FROM `user`";
            DataTable table = DBConnetion.getInstance().getDBTable(query);
            dataGridView1.DataSource = table;
            dataGridView1.Columns[0].HeaderText = "부서명";
            dataGridView1.Columns[1].HeaderText = "직위";
            dataGridView1.Columns[2].HeaderText = "이름";
            dataGridView1.Columns[3].HeaderText = "나이";
            dataGridView1.Columns[4].HeaderText = "성별";
            dataGridView1.Columns[5].HeaderText = "H.P";
            dataGridView1.Columns[6].HeaderText = "주소";
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            this.depart = comboBoxDepart.SelectedIndex;
            this.grade = comboBoxGrade.SelectedIndex;
            this.age = Convert.ToInt32(textBoxAge.Text);
            this.id = textBoxId.Text;
            this.password = textBoxPassword.Text;
            this.name = textBoxName.Text;
            this.gender = comboBoxGender.SelectedIndex;
            this.phone = textBoxPhone.Text;
            this.address = textBoxAddress.Text;

            AddNewcomer(); // 사원 추가
            DataShow(); // 데이터 그리드뷰 갱신
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // 주소 검색창
            using (AddressFrom af = new AddressFrom())
            {

                af.ShowDialog();
                if (af.address[1] != "")
                    textBoxAddress.Text = af.address[1];
                else
                    textBoxAddress.Text = address;
            }
        }

        private void textBoxPhone_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxPhone.Text = "";
        }

        private void buttonAddUsers_Click(object sender, EventArgs e)
        {

        }
    }
}
