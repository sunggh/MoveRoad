﻿using MOVEROAD.InfoFile;
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
            textBoxExistingIndex.Text = index;
            textBoxEditIndex.Text = index;
            textBoxExistingDepart.Text = depart;
            textBoxExistingGrade.Text = grade;
            textBoxExistingName.Text = name;
            textBoxExistingAge.Text = age;
            textBoxExistingGender.Text = gender;
            textBoxExistingPhone.Text = phone;
            textBoxExistingAddress.Text = address;

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
            // 수정한 정보를 기존 정보에 넣어주기
            depart = comboBoxEditDepart.Text; // int
            grade = comboBoxEditGrade.Text; // int
            name = textBoxEditName.Text; // string
            age = textBoxEditAge.Text; // int
            gender = comboBoxEditGender.Text; // int
            phone = textBoxEditPhone.Text; // string
            address = textBoxEditAddress.Text; // string
            init();

            int editIndex = Convert.ToInt32(index);
            int editDepart = comboBoxEditDepart.SelectedIndex;
            int editGrade = comboBoxEditGrade.SelectedIndex;
            string editName = name;
            int editAge = Convert.ToInt32(age);
            int editGender = comboBoxEditGender.SelectedIndex;
            string editPhone = phone;
            string editAddress = address; 

            // 수정한 정보를 query문으로 update 해주기
            string query = "UPDATE project.`user` SET `depart` = '" + editDepart + "', `grade` = '" + editGrade + "', `name` = '" + editName + "', " +
                "`age` = '" + editAge + "', `gender` = '" + editGender + "', `phone` = '" + editPhone + "', `address` = '" + editAddress + "' WHERE `index` = '" + editIndex + "'";
            DBConnetion.getInstance().Update(query);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
