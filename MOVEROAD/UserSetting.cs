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
    public partial class UserSetting : Form
    {
        private UserInfo me;
        public UserSetting(UserInfo me)
        {
            InitializeComponent();
            this.idTextbox.Text = me.id;
            this.pwTextBox.Text = "";
            this.pwTextBox2.Text = "";
            this.addTextbox.Text = me.address;
            this.me = me;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool pass = false;
            if(this.idTextbox.Text == "")
            {
                MessageBox.Show("변경 할 ID를 입력해주세요.");
                return;
            }
            if (this.addTextbox.Text == "")
            {
                MessageBox.Show("집 주소를 제대로 입력 해주세요.");
                return;
            }
            if (this.pwTextBox.Text != "" && this.pwTextBox2.Text != "")
            {
                if(pwTextBox.Text != pwTextBox2.Text)
                {
                    MessageBox.Show("비밀번호와 확인이 일치하지 않습니다.");
                    return;
                }
                pass = true;
            }
            me.address = addTextbox.Text;
            if(pass)
                DBConnetion.getInstance().Update("UPDATE `project`.`user` SET `password` = '"+pwTextBox.Text+"',`address` = '" + addTextbox.Text+ "' WHERE (`index` = '"+me.index+"')");
            else
                DBConnetion.getInstance().Update("UPDATE `project`.`user` SET `address` = '" + addTextbox.Text + "' WHERE (`index` = '" + me.index + "')");
            MessageBox.Show("성공적으로 변경 되었습니다.");
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            using (AddressFrom af = new AddressFrom())
            {
                
                af.ShowDialog();
                if (af.address[1] != "")
                    addTextbox.Text = af.address[1];
                else
                    addTextbox.Text = me.address;
            }
        }
    }
}
