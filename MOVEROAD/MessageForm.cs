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
    public partial class MessageForm : Form
    {
        MainForm main;
     
      
        public MessageForm(MainForm main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void TotitleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string to = ToBox.Text;
            string id = this.main.me.id;
            string title = TotitleBox.Text;
            string text = TotextBox.Text;
            string empty = "";

            if (to != empty && title != empty && text != empty)
            {
                string sql = "INSERT INTO `message`(`mto`,`mfrom`,`title`,`text`,`date`,`reads`) VALUES('" + to + "','" + id + "','" + title + "', '" + text + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '0')";
                DBConnetion.getInstance().Insert(sql);
                MessageBox.Show("성공적으로 전송 되었습니다.");
                this.Dispose();
            }
            if(to!= empty && title != empty && text == empty)
            {
                MessageBox.Show("내용을 입력해 주십시오");
            }
            if (to == empty && title != empty && text != empty)
            {
                MessageBox.Show("보내는 사람을 입력해 주십시오");
            }
            if (to != empty && title == empty && text != empty)
            {
                MessageBox.Show("제목을 입력해 주십시오");
            }

            if (to != empty && title == empty && text == empty)
            {
                MessageBox.Show("내용과 제목을 입력해 주십시오");
            }          
            if (to == empty && title != empty && text == empty)
            {
                MessageBox.Show("보내는 사람과 내용을 입력해 주십시오");
            }
            if (to == empty && title == empty && text != empty)
            {
                MessageBox.Show("보내는 사람과 제목을 입력해 주십시오");
            }

            if (to == empty && title == empty && text == empty)
            {
                MessageBox.Show("아무 정보가 입력되지 않았습니다");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MessageAddress ma = new MessageAddress(main))
            {
                ma.ShowDialog();
               ToBox.Text = ma.address[1];
             
              
         
            }
        }
    }
}
