using MOVEROAD.InfoFile;
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
                    Regex regex = new Regex("^01([0|1|6|7|8|9])-?([0-9]{3,4})-?([0-9]{4})$");
                    if (!regex.IsMatch(editPhone))
                    {
                        MessageBox.Show("전화 번호를 하이픈(-) 포함하여 제대로 입력해 주세요.", "입력 오류");
                        return;
                    }
                    if (editAge >= 1 && editAge < 100) // 나이 1세~99세 까지만 가입 가능
                    {
                        // 수정한 정보를 query문으로 update 해주기
                        string query = "UPDATE project.`user` SET `depart` = '" + depart_id + "', `grade` = '" + editGrade + "', `name` = '" + editName + "', " +
                            "`age` = '" + editAge + "', `gender` = '" + editGender + "', `phone` = '" + editPhone + "', `address` = '" + editAddress + "' WHERE `index` = '" + editIndex + "'";
                        DBConnetion.getInstance().Update(query);
                        
                        if(this.main.me.index == editIndex)
                        {
                            this.main.me.depart = depart_id;
                            this.main.me.grade = editGrade;
                            this.main.me.gender = editGender;
                            this.main.me.address = editAddress;
                            this.main.me.age = editAge;
                            this.main.me.name = editName;
                        }
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

        private void comboBoxEditDepart_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxEditGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(grade == "사장" || grade == "부서장")
            {
                MessageBox.Show("사장이나 부서장은 삭제할 수 없습니다.", "삭제 오류");
                return;
            }
            else
            {
                if (MessageBox.Show("[이름]: " + name + " [부서]: " + depart + "\n삭제 하시겠습니까?", "사원정보 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string delete_query = "DELETE FROM project.user WHERE user.index = " + index;
                    DBConnetion.getInstance().Delete(delete_query);

                    MessageBox.Show("삭제 되었습니다. 새로고침 시 적용됩니다.", "삭제 완료");
                    this.Dispose();
                    return;
                }
                else
                {
                    MessageBox.Show("취소 되었습니다.", "삭제 취소");
                    return;
                }
            }
        }
    }
}
