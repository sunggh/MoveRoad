﻿using System;
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
    public partial class HRmanagement : Form
    {
        public int depart;
        public int grade;
        public int age;
        public string id;
        public string password;
        public string name;
        public int gender;
        public string phone;
        public string address;
        
        public HRmanagement()
        {
            InitializeComponent();
        }

        private void AddNewcomer()
        {
            // 현재 입력된 정보들을 DB에 추가하는 함수
            // TABLE, COLUMN은 ` ` VALUES는 ' ' 주의
            // INSERT INTO `TABLE`(`column`, `column`, ...) VALUES ('string', 숫자, ...);
            string query = "INSERT INTO `user`(`depart`, `grade`, `age`, `id`, `password`, `name`, `gender`, `phone`, `address`)" +
                " VALUES ('" + depart + "', '" + grade + "', '" + age + "', '" + id + "', '" + password + "', '" + name + "', '" + gender + "', '" + phone + "', '" + address + "')";
            DBConnetion.getInstance().Update(query);
            
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            this.depart = Convert.ToInt32(textBoxDepart.Text);
            this.grade = Convert.ToInt32(textBoxGrade.Text);
            this.age = Convert.ToInt32(textBoxAge.Text);
            this.id = textBoxId.Text;
            this.password = textBoxPassword.Text;
            this.name = textBoxName.Text;
            this.gender = Convert.ToInt32(comboBoxGender.Text);
            this.phone = textBoxPhone.Text;
            this.address = textBoxAddress.Text;

            AddNewcomer(); // 사원 추가
            // 데이터 그리드 뷰 갱신한번 해주셈
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            using (AddressFrom af = new AddressFrom())
            {

                af.ShowDialog();
                if (af.address[1] != "")
                    textBoxAddress.Text = af.address[1];
                else
                    textBoxAddress.Text = address;
            }
        }
    }
}
