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
        public UserSetting(UserInfo me)
        {
            InitializeComponent();
            this.idTextbox.Text = me.id;
            this.pwTextBox.Text = "";
            this.pwTextBox2.Text = "";
            this.addTextbox.Text = me.address;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.idTextbox.Text == "")
            {
                MessageBox.Show("변경 할 ID를 입력해주세요.");
                return;
            }
            if (this.pwTextBox.Text == "")
            {
                MessageBox.Show("변경 할 비밀번호를 입력해주세요.");
                return;
            }
            if (this.pwTextBox2.Text == this.pwTextBox.Text)
            {
                MessageBox.Show("비밀 번호 확인이 틀립니다.");
                return;
            }
            if (this.addTextbox.Text == "")
            {
                MessageBox.Show("집 주소를 제대로 입력 해주세요.");
                return;
            }
            MessageBox.Show("성공적으로 변경 되었습니다.");
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (AddressFrom af = new AddressFrom())
            {
                af.ShowDialog();
            }
        }
    }
}
