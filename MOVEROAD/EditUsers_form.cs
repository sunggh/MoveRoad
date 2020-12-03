using MOVEROAD.InfoFile;
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
    public partial class EditUsers_form : Form
    {
        MainForm main;
        
        public string index; // No.
        public string depart; // 부서명
        public string grade; // 직위
        public string name; // 이름
        public string age; // 나이
        public string gender; // 성별
        public string phone; // H.P
        public string address; // 주소

        public EditUsers_form(MainForm main)
        {
            InitializeComponent();
            this.main = main;
        }

        public void init()
        {
            // 정보 창에 기존에 있던 값들 다 넣어주기
            textBoxExistingIndex.Text = index;
            textBoxExistingDepart.Text = depart;
            textBoxExistingGrade.Text = grade;
            textBoxExistingName.Text = name;
            textBoxExistingAge.Text = age;
            textBoxExistingGender.Text = gender;
            textBoxExistingPhone.Text = phone;
            textBoxExistingAddress.Text = address;

            textBoxEditIndex.Text = index;
            comboBoxEditDepart.Text = depart;
            comboBoxEditGrade.Text = grade;
            textBoxEditName.Text = name;
            textBoxEditAge.Text = age;
            comboBoxEditGender.Text = gender;
            textBoxEditPhone.Text = phone;
            textBoxEditAddress.Text = address;

            List<DepartmentInfo> departs = main.departments;
            foreach (var departname in departs)
            {
                string name = departname.name;
                comboBoxEditDepart.Items.Add(name);
            }
        }

        private void textBoxEditAddress_DoubleClick(object sender, EventArgs e)
        {
            // 주소 텍스트칸 더블클릭시
            using (AddressFrom af = new AddressFrom())
            {

                af.ShowDialog();
                if (af.address[1] != "")
                    textBoxEditAddress.Text = af.address[1];
                else
                    textBoxEditAddress.Text = address;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string select_depart = comboBoxEditDepart.Text; // 수정할 부서명

            // 부서 id값 불러오기
            string check_depart_name = "SELECT * FROM project.department WHERE department.name = '" + select_depart + "'";
            int depart_id = (int)DBConnetion.getInstance().Select(check_depart_name, 20);
            if(depart_id == -1)
            {
                MessageBox.Show("부서명을 입력하여 주십시오.", "수정 오류");
            }
            else
            {
                // 수정한 정보를 기존 정보에 넣어주기
                depart = select_depart; // string
                grade = comboBoxEditGrade.Text; // int
                name = textBoxEditName.Text; // string
                age = textBoxEditAge.Text; // int
                gender = comboBoxEditGender.Text; // int
                phone = textBoxEditPhone.Text; // string
                address = textBoxEditAddress.Text; // string
                if (depart == "" || grade == null || name == "" || age == null || gender == null || phone == "" || address == "")
                {
                    MessageBox.Show("빈칸을 모두 채워 주십시오.", "수정 오류");
                }
                else
                {
                    init();

                    int editIndex = Convert.ToInt32(index);
                    int editDepart = comboBoxEditDepart.SelectedIndex;
                    int editGrade = comboBoxEditGrade.SelectedIndex;
                    string editName = name;
                    int editAge = Convert.ToInt32(age);
                    int editGender = comboBoxEditGender.SelectedIndex;
                    string editPhone = phone;
                    string editAddress = address;

                    if(editAge >= 1 && editAge < 100) // 나이 1세~99세 까지만 가입 가능
                    {
                        // 수정한 정보를 query문으로 update 해주기
                        string query = "UPDATE project.`user` SET `depart` = '" + depart_id + "', `grade` = '" + editGrade + "', `name` = '" + editName + "', " +
                            "`age` = '" + editAge + "', `gender` = '" + editGender + "', `phone` = '" + editPhone + "', `address` = '" + editAddress + "' WHERE `index` = '" + editIndex + "'";
                        DBConnetion.getInstance().Update(query);

                        MessageBox.Show("수정이 완료 되었습니다. 새로고침 시 적용됩니다.", "수정 완료");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("나이를 올바르게 입력하여 주십시오. (범위: 1-99)", "입력 오류");
                        return;
                    }
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBoxEditAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void textBoxEditPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
