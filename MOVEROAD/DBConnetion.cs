using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVEROAD
{
    public class DBConnetion
    {
        private string DBIp = "localhost";
        private string DBId = "root";
        private string DBPass = "root";
        private string DBName = "project";
        private static DBConnetion instance_ = new DBConnetion();
        public static DBConnetion getInstance()
        {
            return instance_;
        }

        public MySqlConnection getDBConnetion()
        {
            try
            {
                string con = "Server=" + DBIp + ";Database=" + DBName + ";Uid=" + DBId + ";Pwd=" + DBPass + ";Charset=euckr";
                MySqlConnection conn = new MySqlConnection(con);
                conn.Open();
                conn.Close();
                return conn;
            }
            catch
            {
                return null;
            }
        }
    }
}
