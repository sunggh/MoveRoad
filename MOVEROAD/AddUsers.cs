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
            if(comboBoxDepart.SelectedIndex == 0)
            {
                MessageBox.Show("미지정 부서는 등록할 수 없습니다.", "등록 오류");
                return;
            }

            // 현재 입력된 정보들을 DB에 추가하는 함수
            // TABLE, COLUMN은 ` ` VALUES는 ' ' 주의
            // INSERT INTO `TABLE`(`column`, `column`, ...) VALUES ('string', 숫자, ...);
            string query = "INSERT INTO `user`(`depart`, `grade`, `age`, `id`, `password`, `name`, `gender`, `phone`, `address`)" +
                " VALUES (" + depart + ", " + grade + ", " + age + ", '" + id + "', '" + password + "', '" + name + "', " + gender + ", '" + phone + "', '" + address + "')";
            DBConnetion.getInstance().Insert(query);
            
            comboBoxDepart.Text = "";
            comboBoxGrade.Text = "";
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
            string query = "SELECT user.index AS 'No.', department.name AS '부서명', " +
                "CASE user.grade WHEN 0 THEN '사장' WHEN 1 THEN '부서장' WHEN 2 THEN '사원' END AS '직위', user.name AS '이름', user.age AS '나이', " +
                "CASE user.gender WHEN 0 THEN '남자' WHEN 1 THEN '여자' END AS '성별', user.phone AS 'H.P', user.address AS '주소' " +
                "FROM project.user, project.department WHERE user.depart = department.id";
            object table = DBConnetion.getInstance().Select(query, 70);

  
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
    }
}
