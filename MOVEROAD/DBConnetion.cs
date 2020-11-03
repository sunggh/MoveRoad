using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOVEROAD
{
    public class DBConnetion
    {
        private string DBIp = "211.229.51.172";
        private string DBId = "project";
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
                MessageBox.Show("dd");
                return null;
            }
        }
    }
}
