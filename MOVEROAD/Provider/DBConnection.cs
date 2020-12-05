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
        private string dbip = "121.150.220.47";
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
                string con = "Server=" + dbip + ";Database=" + dbname + ";Uid=" + dbid + ";Pwd=" + dbpass + ";Charset=utf8";
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
                    if (rdr.Read())
                    {
                        UserInfo me = new UserInfo((int)rdr["index"], (string)rdr["name"], (int)rdr["age"], (int)rdr["depart"], (int)rdr["grade"], (string)rdr["address"], (int)rdr["gender"], (string)rdr["account_id"]);
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
                        DepartmentInfo department = new DepartmentInfo((int)rdr["index"], (string)rdr["name"], (int)rdr["manager"]);
                        departments.Add(department);
                    }
                    thing = departments;
                    break;
                case 3:
                    rdr.Read();
                    string str = ((string)rdr["name"]);
                    thing = str;
                    break;
                case 4:
                    DataTable taskClassInfo = new DataTable();
                    //열 생성
                    taskClassInfo.Columns.Add("ID", typeof(int));   //table내에서 부여한 고유 ID
                    taskClassInfo.Columns.Add("Name", typeof(string));    //이름
                    taskClassInfo.Columns.Add("ParentID", typeof(int));       //상위 class의 ID
                    taskClassInfo.Columns.Add("Level", typeof(int));          //대분류 = 1 중분류 = 2 소분류 = 3
                    taskClassInfo.Columns.Add("DepartID", typeof(int));

                    while (rdr.Read())
                    {
                        taskClassInfo.Rows.Add((int)rdr["index"], (string)rdr["name"], (int)rdr["parent_id"], (int)rdr["level"], (int)rdr["depart_id"]);                        
                    }
                    thing = taskClassInfo;
                    break;
                case 5:
                    thing = rdr.Read();
                    break;
                case 6:
                    List<Message> messages = new List<Message>();
                    while (rdr.Read())
                    {
                        messages.Add(new Message((string)rdr["mfrom"], (string)rdr["mto"], (string)rdr["title"], (string)rdr["text"], (int)rdr["index"], (DateTime)rdr["date"], (int)rdr["reads"]));
                    }
                    thing = messages;
                    break;
                case 21:
                    rdr.Read();
                    thing = ((string)rdr["id"]);
                    break;
                case 22:
                    if (rdr.Read())
                    {
                        String startTime = ((string)rdr["startTime"]);
                        thing = startTime;
                        break;
                    }
                    thing = "";
                    break;
                case 23:
                    if (rdr.Read())
                    {
                        String finishTime = ((string)rdr["finishTime"]);
                        thing = finishTime;
                        break;
                    }
                    thing = "";
                    break;
                /*                case 4:
                    rdr.Read();
                    thing = ((string)rdr["id"]);
                    break;
                case 5:
                    if (rdr.Read())
                    {
                        String startTime = ((string)rdr["startTime"]);
                        thing = startTime;
                        break;
                    }
                    thing = null;
                    break;
                case 6:
                    if (rdr.Read())
                    {
                        String finishTime = ((string)rdr["finishTime"]);
                        thing = finishTime;
                        break;
                    }
                    thing = null;
                    break;*/
                case 28:
                    if (rdr.Read()) thing= 1;
                    else thing = 0;
                    break;
                case 20:
                    if (rdr.Read())
                    {
                        thing = (int)rdr["id"];
                        break;
                    }
                    else
                    {
                        thing = -1;
                        break;
                    }
                case 13:
                    DataTable taskHours = new DataTable();
                    //열 생성
                    taskHours.Columns.Add("StartTime", typeof(int));
                    taskHours.Columns.Add("FinishTime", typeof(int));

                    while (rdr.Read())
                    {
                        DateTime st = Convert.ToDateTime(rdr["startTime"]);
                        DateTime ft = Convert.ToDateTime(rdr["finishTime"]);
                        TimeSpan startTime = st.TimeOfDay;
                        TimeSpan finishTime = ft.TimeOfDay;
                        int stSec = (int)startTime.TotalSeconds;
                        int ftSec = (int)finishTime.TotalSeconds;

                        taskHours.Rows.Add(stSec, ftSec);
                    }
                    if (taskHours.Rows.Count == 0)
                        thing = null;
                    else
                        thing = taskHours;
                    break;
                case 14:
                    List<UserInfo> userInfos = new List<UserInfo>();

                    while (rdr.Read())
                    {
                        UserInfo user = new UserInfo((int)rdr["index"], (string)rdr["name"]);
                        userInfos.Add(user);
                    }
                    thing = userInfos;
                    break;
                case 15:
                    DataTable task = new DataTable();
                    //열 생성
                    task.Columns.Add("ID", typeof(int));
                    task.Columns.Add("업무", typeof(string));    //이거 이따가 string으로 바꿔야 함
                    task.Columns.Add("날짜", typeof(string));
                    task.Columns.Add("이름", typeof(string));
                    task.Columns.Add("업무내용", typeof(string));
                    task.Columns.Add("시작시간", typeof(string));
                    task.Columns.Add("종료시간", typeof(string));

                    while (rdr.Read())
                    {
                        string startTime = string.Format("{0:HH:mm:ss}", rdr["startTime"]);
                        string finishTime = string.Format("{0:HH:mm:ss}", rdr["finishTime"]);
                        string user_id = Convert.ToString((int)rdr["user_id"]);
                        string taskName;
                        if(rdr["task"] == System.DBNull.Value)
                        {
                            taskName = "삭제된 업무";
                        }
                        else
                        {
                            taskName = (string)rdr["task"];
                        }
                        //퇴사한 유저는 굳이 안보여줘도 될듯
                        if(rdr["user"] == null)
                        {
                            continue;
                        }
                        task.Rows.Add((int)rdr["index"], taskName, string.Format("{0:yyyy-MM-dd}",rdr["date"]), ((string)rdr["user"] + "(" + user_id + ")"), (string)rdr["text"], startTime, finishTime);
                    }
                    thing = task;
                    break;
                case 16:
                    List<string> recentlytask = new List<string>();
                    while (rdr.Read())
                    {
                        string taskName;
                        if (rdr["task"] == System.DBNull.Value)
                        {
                            continue;
                        }

                        taskName = (string)rdr["task"] + " : " + (string)rdr["text"];

                        recentlytask.Add(taskName);
                    }
                    thing = recentlytask;
                    break;
                case 7:
                    try
                    {
                        rdr.Read();
                        String memo = ((string)rdr["memo"]);
                        thing = memo;
                    }
                    catch
                    {
                        MessageBox.Show("반려 내역이 없습니다.", "확인");
                    }
                    break;
                case 9:
                    rdr.Read();
                    String text = ((string)rdr["text"]);
                    thing = text;
                    break;
                case 10:
                    rdr.Read();
                    DateTime date = ((DateTime)rdr["date"]);
                    thing = date;
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
                    break;
                case 81: //총급여 계산
                    if (rdr.Read())
                        thing = rdr["sumpays"].ToString();
                    else
                        thing = "0";
                    break;
                case 82: // 총급여 가져오기
                    if (rdr.Read())
                        thing = rdr["totalPay"].ToString();
                    else
                        thing = "0";
                    break;
                case 83:
                    List<string> list1 = new List<string>();
                    while (rdr.Read())
                    {
                        list1.Add(string.Format("{0}", rdr["month"]));
                        list1.Add(string.Format("{0}", rdr["totalPay"]));
                    }
                    thing = list1;
                    break;
                case 84:
                    if (rdr.Read())
                        thing = rdr["date"].ToString();
                    else
                        thing = "";
                    break;
                case 85: //주말인지 아닌지 알아내기
                    if (rdr.Read())
                        thing = rdr["dayofweek"].ToString();
                    else
                        thing = "8";
                    break;
                case 86:// X-Y(날짜) 초로 가져오기
                    if (rdr.Read())
                        thing = rdr["sectime"].ToString();
                    else
                        thing = "0";
                    break;
                case 87:
                    rdr.Read();
                    thing = string.Format("{0}", rdr["id"]);
                    break;
                case 88:
                    DepartmentInfo department_ = new DepartmentInfo(0, "", 0);
                    while (rdr.Read())
                    {
                        department_ = new DepartmentInfo((int)rdr["id"], (string)rdr["name"], (int)rdr["manager"]);
                    }
                    thing = department_;
                    break;
                case 89:
                    while (rdr.Read())
                    {
                        thing = rdr["date2"].ToString();
                    }
                    break;
                case 181:
                    if (rdr.Read())
                        thing = rdr["totalPay"].ToString();
                    else
                        thing = "0";
                    break;
                case 11:
                        rdr.Read();
                        string count = (rdr["count(*)"].ToString());
                        thing = count;
                    break;
            }
            rdr.Close();
            conn.Close();
            return thing;
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
        public List<string> dpt_id_and_name(string query, int token)
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
                        list.Add(string.Format("{0}", rdr["index"]));
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
                list.Add(string.Format("{0}", rdr["index"]));
                list.Add(string.Format("{0}", rdr["name"]));
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

        public DataTable getDBTable(string sql) // 사원정보 데이터 그리드뷰에 넣는거
        {
            using (MySqlConnection conn = getDBConnetion())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                DataTable table = new DataTable();

                table.Load(rdr);
                return table;
            }
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
        public int InsertNewNode(string sql)
        {
            MySqlConnection conn = getDBConnetion();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            long id = cmd.LastInsertedId;
            Console.WriteLine("넣은 마지막 id : " + id);
            conn.Close();

            return (int)id;
        }

    }
}
