using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        TcpListener server = null;
        TcpClient client = null;
        static int counter = 0;

        public Form1()
        {
            InitializeComponent();
            Thread t = new Thread(InitSocket);
            t.IsBackground = true;
            t.Start();
        }
        TcpClient clientSocket;
        private void InitSocket()
        {
            server = new TcpListener(IPAddress.Any, 9999);
            client = default(TcpClient);
            server.Start();
            NetworkStream stream = null;
            while (true)
            {
                try
                {
                    counter++;
                    client = server.AcceptTcpClient();
                    stream = clientSocket.GetStream();
                  
                }
                catch (SocketException se)
                {
                  //  Trace.WriteLine(string.Format("InitSocket - SocketException : {0}", se.Message));
                }
                catch (Exception ex)
                {
                   // Trace.WriteLine(string.Format("InitSocket - Exception : {0}", ex.Message));
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
