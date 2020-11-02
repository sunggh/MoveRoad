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
        private string DBIp = "3.138.172.1";
        private string DBId = "root";
        private string DBPass = "root";
        private string DBName = "dbproject";
        private static DBConnetion instance_ = new DBConnetion();
        TcpClient clientSocket;
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
        public void InitSocket()
        {
            try
            {
                clientSocket.Connect(DBIp, 9999);
                MessageBox.Show("서버 연결 완료");
            }
            catch (SocketException se)
            {
             
            }
            catch (Exception ex)
            {
                
            }
        }

    }
}
