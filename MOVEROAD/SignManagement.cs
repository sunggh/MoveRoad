using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVEROAD
{
    class SignManagement
    {
        public SignManagement()
        {
            //생성자
        }
        public string title { get; set; }
        public string text { get; set; }
        public string comment { get; set; }
        public int sub_class { get; set; } //업무 (1:인사, 2:홍보, 3:경리, 4:경영)
        public int drafter { get; set; } //결재자 (0:사원, 1:부장, 2:사장)
        public int progress { get; set; } //진행 사항 (0:결재 전, 1:결재 중, 2:결재 완료, 3:결재 반려)


        //singleton
        private static SignManagement sign = new SignManagement();

        public static SignManagement GetInstance()
        {
            return sign;
        }

        public void addSign()
        {
            //string query = "SELECT id FROM department";

            //MySqlConnection conn = new MySqlConnection(con);
            //conn.Open();
            //MySqlCommand cmd = new MySqlCommand(query, conn);
            //MySqlDataReader rdr = cmd.ExecuteReader();

            //while (rdr.Read())
            //{
            //    sub_class = Convert.ToInt32(rdr["id"]);
            //}

            //string query = "INSERT INTO sign(sub_class, comment, drafter, progress) VALUES(
        }
    }
}
