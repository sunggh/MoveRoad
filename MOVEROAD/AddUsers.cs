using MOVEROAD.InfoFile;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOVEROAD
{
    public partial class AddUsers : Form
    {
        MainForm main;
        
        public int depart;
        public string select_depart;
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
            if(this.select_depart == "미지정") // 부서이름 미지정일 경우
            {
                MessageBox.Show("미지정 부서는 등록할 수 없습니다.", "등록 오류");
                return;
            }
            else
            {
                string check_user_id = "SELECT * FROM project.user WHERE user.account_id = '" + this.id + "'";
                int check_id_status = (int)DBConnetion.getInstance().Select(check_user_id, 28);

                if (check_id_status.Equals(1))
                {
                    MessageBox.Show("아이디가 중복되었습니다. 다시 설정해주세요.", "등록 오류");
                    return;
                }
                else
                {
                    // 부서 id값 불러오기
                    string check_depart_name = "SELECT * FROM project.department WHERE department.name = '" + this.select_depart + "'";
                    int depart_id = (int)DBConnetion.getInstance().Select(check_depart_name, 20);

                    // 현재 입력된 정보들을 DB에 추가하는 함수
                    // TABLE, COLUMN은 ` ` VALUES는 ' ' 주의
                    // INSERT INTO `TABLE`(`column`, `column`, ...) VALUES ('string', 숫자, ...);
                    // depart | grade | age | id | password | name | gender | phone | address
                    string query = "INSERT INTO `user`(`depart`, `grade`, `age`, `account_id`, `password`, `name`, `gender`, `phone`, `address`)" +
                        " VALUES (" + depart_id + ", " + grade + ", " + age + ", '" + id + "', '" + password + "', '" + name + "', " + gender + ", '" + phone + "', '" + address + "')";
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
            }
        }
        
        private void DataShow()
        { 
            string query = "SELECT user.index AS 'No.', department.name AS '부서명', " +
                "CASE user.grade WHEN 0 THEN '사장' WHEN 1 THEN '부서장' WHEN 2 THEN '사원' END AS '직위', user.name AS '이름', user.age AS '나이', " +
                "CASE user.gender WHEN 0 THEN '남자' WHEN 1 THEN '여자' END AS '성별', user.phone AS 'H.P', user.address AS '주소' " +
                "FROM project.user, project.department WHERE user.depart = department.index";
            object table = DBConnetion.getInstance().Select(query, 70);

  
            dataGridView1.DataSource = table;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if(comboBoxDepart.Text == "" || comboBoxGrade.Text == "" || textBoxAge.Text == "" || textBoxId.Text == "" || textBoxPassword.Text == "" || textBoxName.Text == "" || comboBoxGender.Text == "" ||
                textBoxPhone.Text == "" || textBoxAddress.Text == "" || textBoxPhone.Text == "하이픈(-)포함 입력")
            {
                MessageBox.Show("빈칸을 모두 채워 주십시오.", "등록 오류");
                return;
            }
            else
            {
                this.select_depart = comboBoxDepart.Text; // 부서 이름
                this.grade = comboBoxGrade.SelectedIndex; // 직급
                this.age = Convert.ToInt32(textBoxAge.Text); // 나이
                this.id = textBoxId.Text; // 아이디
                this.password = textBoxPassword.Text; // 패스워드
                this.name = textBoxName.Text; // 이름
                this.gender = comboBoxGender.SelectedIndex; // 성별
                this.phone = textBoxPhone.Text; // 전화번호
                this.address = textBoxAddress.Text; // 주소
                Regex regex = new Regex("^01([0|1|6|7|8|9])-?([0-9]{3,4})-?([0-9]{4})$");
                if (!regex.IsMatch(this.phone))
                {
                    MessageBox.Show("전화 번호를 하이픈(-) 포함하여 제대로 입력해 주세요.", "입력 오류");
                    return;
                }
                if (age >= 1 && age < 100) // 나이 1세~99세 까지만 가입 가능
                {
                    AddNewcomer(); // 사원 추가
                    DataShow(); // 데이터 그리드뷰 갱신
                }
                else
                {
                    MessageBox.Show("나이를 올바르게 입력하여 주십시오. (범위: 1-99)", "입력 오류");
                    return;
                }
                
            }
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
            if(textBoxPhone.Text == "하이픈(-)포함 입력")
            {
                textBoxPhone.Text = "";
            } 
        }

        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void comboBoxGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxDepart_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
