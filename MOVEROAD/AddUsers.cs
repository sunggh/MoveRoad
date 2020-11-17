using MOVEROAD.InfoFile;
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
        MainForm main;
        
        public int depart;
        public int grade;
        public int age;
        public string id;
        public string password;
        public string name;
        public int gender;
        public string phone;
        public string address;
        
        public AddUsers(MainForm main)
        {
            InitializeComponent();
            this.main = main;
            DataShow();
            init();
//            comboBoxDepart.SelectedIndex = 0;
//            comboBoxGrade.SelectedIndex = 0;
        }

        private void init()
        {
            List<DepartmentInfo> departs = main.departments;
            foreach (var departname in departs)
            {
                string name = departname.name;
                comboBoxDepart.Items.Add(name);
            }
        }

        private void AddNewcomer()
        {
            // 현재 입력된 정보들을 DB에 추가하는 함수
            // TABLE, COLUMN은 ` ` VALUES는 ' ' 주의
            // INSERT INTO `TABLE`(`column`, `column`, ...) VALUES ('string', 숫자, ...);
            string query = "INSERT INTO `user`(`depart`, `grade`, `age`, `id`, `password`, `name`, `gender`, `phone`, `address`)" +
                " VALUES (" + depart + ", " + grade + ", " + age + ", '" + id + "', '" + password + "', '" + name + "', " + gender + ", '" + phone + "', '" + address + "')";
            DBConnetion.getInstance().Insert(query);

            comboBoxDepart.SelectedIndex = 0;
            comboBoxGrade.SelectedIndex = 0;
            textBoxAge.Text = "";
            textBoxId.Text = "";
            textBoxPassword.Text = "";
            textBoxName.Text = "";
            comboBoxGender.Text = "";
            textBoxPhone.Text = "";
            textBoxAddress.Text = "";
        }
        
        private void DataShow()
        {
            string query = "SELECT `index` AS `No.`, depart AS 부서명, grade AS 직위, name AS 이름, age AS 나이, gender AS 성별, phone AS `H.P`, address AS 주소 FROM `user`";
            DataTable table = DBConnetion.getInstance().getDBTable(query);

  
            dataGridView1.DataSource = table;
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
            if(textBoxPhone.Text == "하이픈(-)까지 입력")
            {
                textBoxPhone.Text = "";
            } 
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
