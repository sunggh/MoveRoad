using MOVEROAD.InfoFile;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOVEROAD
{
    public class DBConnetion
    {
        private string dbip = "211.229.51.245";
        private string dbname = "project";
        private string dbpass = "road";
        private string dbid = "move";
        private static DBConnetion instance_ = new DBConnetion();

        public static DBConnetion getInstance()
        {
            return instance_;
        }

        public MySqlConnection getDBConnetion()
        {
            try
            {
                string con = "Server=" + dbip + ";Database=" + dbname + ";Uid=" + dbid + ";Pwd=" + dbpass + ";Charset=UTF8";
                MySqlConnection conn = new MySqlConnection(con);
                conn.Open();
                conn.Close();
                return conn;
            }
            catch
            {
                MessageBox.Show("DB서버 연결오류");
                return null;
            }
        }

        public object Select(string sql, int token)
        {
            MySqlConnection conn = getDBConnetion();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            object thing = new object();
            switch (token)
            {
                case 0:
                    if(rdr.Read())
                    {
                        UserInfo me = new UserInfo((int)rdr["index"], (string)rdr["name"],(int)rdr["age"], (int)rdr["depart"], (int)rdr["grade"], (string)rdr["address"], (int)rdr["gender"], (string)rdr["id"]);
                        thing = me;
                        break;
                    }
                    thing = null;  
                    break;
                case 1:
                    rdr.Read();
                    break;
                case 2:
                    List<DepartmentInfo> departments = new List<DepartmentInfo>();
                    while (rdr.Read())
                    {
                        DepartmentInfo department = new DepartmentInfo((int)rdr["id"],(string)rdr["name"],(int)rdr["manager"]);
                        departments.Add(department);
                    }
                    thing = departments;
                    break;
                case 3:
                    rdr.Read();
                    String str = ((string)rdr["name"]);
                    thing = str;
                    break;
                case 4:
                    rdr.Read();
                    thing = ((string)rdr["id"]);
                    break;
                case 5:
                    if (!rdr.Read())
                        thing = null;
                    else
                    {
                        String startTime = ((string)rdr["startTime"]);
                        thing = startTime;
                    }
                    break;
                case 6:
                    if (!rdr.Read())
                        thing = null;
                    else
                    {
                        String finishTime = ((string)rdr["finishTime"]);
                        thing = finishTime;
                    }
                    break;
                case 8:
                    if (rdr.Read()) return 1;
                    else return 0;
                case 10:
                    rdr.Read();
                    thing = (int)rdr["id"];
                    break;
                case 70: //데이터 그리드뷰로 사원 불러오기
                    DataTable table = new DataTable();

                    table.Load(rdr);
                    return table;
                case 80: //급여 리스트뷰 출력
                    List<string> list = new List<string>();

                    while (rdr.Read())
                    {
                        list.Add(string.Format("{0}", rdr["name"]));
                        list.Add(string.Format("{0}", rdr["date"]));
                        list.Add(string.Format("{0}", rdr["basicPay"]));
                        list.Add(string.Format("{0}", rdr["overtimePay"]));
                        list.Add(string.Format("{0}", rdr["nighttimePay"]));
                        list.Add(string.Format("{0}", rdr["holidayPay"]));
                        list.Add(string.Format("{0}", rdr["totalPay"]));
                        list.Add(string.Format("{0}", rdr["deduction"]));
                        list.Add(string.Format("{0}", rdr["actualPay"]));
                    }
                    thing = list;
                    return thing;
                case 81: //총급여 계산
                    rdr.Read();
                    thing = string.Format("{0}", rdr["sumpays"]);
                    return thing;
                case 82: // 총급여 가져오기
                    while (rdr.Read())
                    {
                        thing = string.Format("{0}", rdr["totalPay"]);
                    }
                    return thing;
                case 83:
                    List<string> list1 = new List<string>();
                    while (rdr.Read())
                    {
                        list1.Add(string.Format("{0}", rdr["month"]));
                        list1.Add(string.Format("{0}", rdr["totalPay"]));
                    }
                    thing = list1;
                    return thing;
                case 84:
                    string date = "";
                    while (rdr.Read())
                    {
                        date = string.Format("{0}", rdr["date"]);
                    }
                    return date;
                case 85: //주말인지 아닌지 알아내기
                    rdr.Read();
                    thing = string.Format("{0}", rdr["dayofweek"]);
                    break;
                case 86:// X-Y(날짜) 초로 가져오기
                    string get_sectime = "";
                    while (rdr.Read())
                    {
                        get_sectime = string.Format("{0}", rdr["sectime"]);
                    }
                    thing = get_sectime;
                    break;
                case 87:
                    rdr.Read();
                    thing = string.Format("{0}",rdr["id"]);
                    break;
                case 88:
                    DepartmentInfo department_ = new DepartmentInfo(0, "", 0);
                    while (rdr.Read())
                    {
                        department_ = new DepartmentInfo((int)rdr["id"], (string)rdr["name"], (int)rdr["manager"]);
                    }
                    return department_;
                case 89:
                    rdr.Read();
                    thing = string.Format("{0}", rdr["date2"]);
                    break;
                case 181:
                    string totalPay = "";
                    while (rdr.Read())
                    {
                        totalPay = string.Format("{0}", rdr["totalPay"]);
                    }
                    return totalPay;

            }
            rdr.Close();
            conn.Close();
            return thing;
        }

        public List<string> dpt_id_and_name(string query,int token)
        {
            List<string> list = new List<string>();
            MySqlConnection conn = getDBConnetion();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                switch (token)
                {
                    case 0:
                        list.Add(string.Format("{0}", rdr["name"]));
                        list.Add(string.Format("{0}", rdr["depart"]));

                        break;
                    case 1:
                        list.Add(string.Format("{0}", rdr["name"]));
                        break;
                }
            }
            rdr.Close();
            conn.Close();

            return list;
        }

        public string get_department_countid(string query)
        {
            string count = "";
            MySqlConnection conn = getDBConnetion();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                count = string.Format("{0}", rdr["id"]);
            }

            return count;
        }

        public List<string> revise_userlist(string sql)
        {
            List<string> list = new List<string>();
            MySqlConnection conn = getDBConnetion();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                list.Add(string.Format("{0}", rdr["name"]));
                list.Add(string.Format("{0}", rdr["manager"]));
                list.Add(string.Format("{0}", rdr["description"]));
            }
            rdr.Close();
            conn.Close();
            return list;
        }

        public List<string> search_userlist(string sql)
        {
            List<string> list = new List<string>();
            MySqlConnection conn = getDBConnetion();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                list.Add(string.Format("{0}",rdr["name"]));
                list.Add(string.Format("{0}", rdr["grade"]));
            }
            rdr.Close();
            conn.Close();
            return list;
        }

        public List<string> get_departlist(string query)
        {
            List<string> list = new List<string>();
            MySqlConnection conn = getDBConnetion();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                list.Add(string.Format("{0}", rdr["departname"]));
                list.Add(string.Format("{0}", rdr["name"]));
                list.Add(string.Format("{0}", rdr["description"]));
            }
            rdr.Close();
            conn.Close();
            return list;
        }

        public void Update(string sql)
        {
            MySqlConnection conn = getDBConnetion();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public void Insert(string sql)
        {
            MySqlConnection conn = getDBConnetion();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(string sql)
        {
            MySqlConnection conn = getDBConnetion();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
