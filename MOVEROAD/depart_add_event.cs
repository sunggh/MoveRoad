using MOVEROAD.InfoFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOVEROAD
{
    public partial class depart_add_event : Form
    {
        private MainForm mf;

        public depart_add_event(MainForm mf)
        {
            InitializeComponent();

            this.mf = mf;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            UserInfo user;
            string depart_name = tb_depart_name.Text; // 입력한 부서명

            string depart_head = tb_depart_head.Text; // 입력한 부서장
            string head_to_index = "SELECT * FROM user where `name`= '"+depart_head+"'";//부서장으로 선택한 사람의 정보를 다 가져옴
            user = (UserInfo)DBConnetion.getInstance().Select(head_to_index,0);

            string depart_memo = tb_depart_memo.Text; // 입력한 설명

            //department 테이블의 id 개수를 세어서 index를 수동으로 올려줘야함(더미 포함이라 count개수 대로)
            string get_index_query = "select count(`id`-1) as `id` from department";
            string count_id = DBConnetion.getInstance().get_department_countid(get_index_query);

            //예외처리
            if (depart_name.Equals("") || depart_head.Equals(""))
            {
                MessageBox.Show("내용을 입력해주세요.");
            }
            else
            {
                //그 사람의 인덱스로 검색하기
                string add_query = "insert into department values ('" + count_id + "','" + depart_name + "'," + user.index + ",'" + depart_memo + "')";
                DBConnetion.getInstance().Insert(add_query);

                //user.depart하면 부서 인덱스 쓸수있음.

                string id_search = "select id from department where name = '" + depart_name + "'";

                int department_id = (int)DBConnetion.getInstance().Select(id_search, 20);
                //id를 찾았음.

                //그 사람의 직급도 변경하고 원 소속의 부서를 새로 생성된 부서로 변경해야함
                //새로 생성된 부서를 사용하기 위해서는 새로 생성된 부서의 id를 찾아야함.
                string update_query = "update user set `depart` = '" + department_id + "', `grade` = 1 where `index` = " + user.index;
                DBConnetion.getInstance().Update(update_query);

                //부서 추가시 task_class에도 값을 
                string task_add_query = "INSERT INTO task_class(name,parent_id,level,depart_id) VALUES('" + depart_name + "',' 1 ',' 1 ','" + count_id + "')";
                DBConnetion.getInstance().Insert(task_add_query);

                //메인에 객체형태로 department 넣어주기 위함.
                mf.departments.Add(new DepartmentInfo(department_id, depart_name, user.index, depart_memo));

                MessageBox.Show("정상적으로 등록되었습니다.");

                this.DialogResult = DialogResult.OK;
                this.Dispose();
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (search_head search = new search_head())
            {
                search.ShowDialog();
                tb_depart_head.Text = search.name_;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tb_depart_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_depart_head_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
