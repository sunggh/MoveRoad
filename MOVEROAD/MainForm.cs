using MOVEROAD.InfoFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOVEROAD
{
    public partial class MainForm : Form
    {
        private Point mousePoint;
        public UserInfo me { get; set; }
        public Form lastPanel;
        public List<DepartmentInfo> departments = new List<DepartmentInfo>();
        private BackgroundWorker backgroundWorker;
        private static Messenger ms;
        public int messagecheck = 0;
        TcpClient clientSocket = new TcpClient();
        public NetworkStream stream = default(NetworkStream);
        string message = string.Empty;
        public Dictionary<int,UserInfo> onlines = new Dictionary<int,UserInfo>();
        public Dictionary<int, int> room = new Dictionary<int, int>();
        public Dictionary<UserInfo, List<string>> room_msg = new Dictionary<UserInfo, List<string>>();
        public MainForm(UserInfo me)
        {
            this.me = me;
            ms = new Messenger(this);
            ms.TopLevel = false;
            ms.Hide();
            InitializeComponent();

            
            
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += new DoWorkEventHandler(BackgroundWorkerDoWork);
            backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(BackgroundWorkerRunWorkerCompleted);
            backgroundWorker.RunWorkerAsync();
            importDepartmentInfo();
            DashBoard dashBoard = new DashBoard(me, this);
            dashBoard.TopLevel = false;
            dashBoard.Show();
            this.MainPanel.Controls.Clear();
            this.MainPanel.Controls.Add(dashBoard);
            lastPanel = dashBoard;
            try 
            {
                clientSocket.Connect("211.229.51.245", 80);//211.229.51.245
                stream = clientSocket.GetStream();
                message = "1|"+me.index;
                byte[] buffer = Encoding.Unicode.GetBytes(message);
                stream.Write(buffer, 0, buffer.Length);
                stream.Flush();
                Thread t_handler = new Thread(GetMessage);
                t_handler.IsBackground = true;
                t_handler.Start();
            }
            catch (Exception e2)
            {
                MessageBox.Show("채팅서버가 오프라인입니다.");
            } 
        }
        private void GetMessage()
        {
            message = "1|" + me.index;
            byte[] buffers = Encoding.Unicode.GetBytes(message);
            stream.Write(buffers, 0, buffers.Length);
            stream.Flush();
            while (true)
            {
                stream = clientSocket.GetStream();
                            
                int BUFFERSIZE = clientSocket.ReceiveBufferSize;
                byte[] buffer = new byte[BUFFERSIZE];
                int bytes = stream.Read(buffer, 0, buffer.Length);
                string message = Encoding.Unicode.GetString(buffer, 0, bytes);
                chathandler(message);
               
                
            }
        }
        public int room_id;
        private void chathandler(string message)
        {
            string[] str = message.Split(new string[] { "|" }, StringSplitOptions.None);
            int opcode = int.Parse(str[0]);
            int cur_room = -1;
            int user_id;
            int to_id;
            UserInfo user;
            string msg;
            string sql;
            switch (opcode)
            {
                case 0: // 기존에 있던 유저 등록
                    int count = int.Parse(str[1]);
                    for(int i = 2; i<count+2; i++)
                    {
                        user_id = int.Parse(str[i]);
                        sql = "SELECT * FROM user where `index` = '" + user_id + "'";
                        user = (UserInfo)DBConnetion.getInstance().Select(sql, 0);
                        onlines.Add(user_id, user);
                    }
                    break;
                case 1: // 접속 (1|유저아이디)
                    user_id = int.Parse(str[1]);
                    sql = "SELECT * FROM user where `index` = '"+ user_id + "'";
                    user = (UserInfo)DBConnetion.getInstance().Select(sql, 0);
                    onlines.Add(user_id,user);
                    break;
                case 2: // 로그아웃 (2|유저아이디)
                    user_id = int.Parse(str[1]);
                    var roomnum = -1;
                    room_id = -1;
                    foreach (var r in room)
                    {
                        if(r.Value == user_id)
                        {
                            roomnum = r.Key;
                            break;
                        }
                    }
                    if(room.ContainsKey(roomnum))
                    {
                        room.Remove(roomnum);
                    }
                    if (room_msg.ContainsKey(onlines[user_id]))
                    {
                        room_msg.Remove(onlines[user_id]);
                    }
                    reloadNameBox();
                    onlines.Remove(user_id);
                    break;
                case 3:
                    cur_room = int.Parse(str[1]);
                    to_id = int.Parse(str[2]);
                    if (room.ContainsKey(cur_room))
                    {
                        if (!room_msg.ContainsKey(onlines[to_id]))
                        {
                            room_msg.Add(onlines[to_id], new List<string>());
                        }
                        break;
                    }
                    room_id = cur_room;
                    room.Add(room_id, to_id);
                    ms.to_user = onlines[to_id];
                    room_msg.Add(onlines[to_id], new List<string>());
                    break;
                case 4:
                    cur_room = int.Parse(str[1]);
                    to_id = int.Parse(str[2]);
                    msg = str[3];
                    string mss="";
                    if (!room.ContainsKey(cur_room))
                    {
                        room.Add(cur_room, to_id);
                    }
                    if (!room_msg.ContainsKey(onlines[to_id]))
                    {
                        room_msg.Add(onlines[to_id], new List<string>());
                    }
                    mss = onlines[room[cur_room]].name + "|" + msg;
                    room_msg[onlines[to_id]].Add(mss);
                    if(ms.nameBOX.Text == onlines[to_id].name)
                        DisplayText(mss);
                    break;
            }
        }
        public void DisplayText(string text)
        {
            if (ms.flowLayoutPanel1.InvokeRequired)
            {
                ms.flowLayoutPanel1.BeginInvoke(new MethodInvoker(delegate
                {
                    ms.addchat(text);
                }));
            }
            else
            {
                ms.flowLayoutPanel1.BeginInvoke(new MethodInvoker(delegate
                {
                    ms.addchat(text);
                }));
            }
        }
        public void reloadNameBox()
        {
            if (ms.nameBOX.InvokeRequired)
            {
                ms.onlineList.BeginInvoke(new MethodInvoker(delegate
                {
                    ms.nameBOX.Text = "";
                }));
            }
            else
            {
                ms.nameBOX.BeginInvoke(new MethodInvoker(delegate
                {
                    ms.nameBOX.Text = "";
                }));
            }
        }

        private void BackgroundWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            string sql = "SELECT `reads` FROM `message` where `mto` = '" + this.me.id + "' AND `reads` = '0' AND receivevisible= '1'";
            if ((bool)DBConnetion.getInstance().Select(sql, 5))
            {
                e.Result = (bool)true;
                
            } else
            {
                e.Result = (bool)false;
            }
            Thread.Sleep(500);
        }
        private void BackgroundWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if((bool)e.Result)
            {
                Message.BackgroundImage = Properties.Resources.그림22;
            } else
            {
                Message.BackgroundImage = Properties.Resources.그림11;
            }
            backgroundWorker.RunWorkerAsync();
        }
   

        private void importDepartmentInfo()
        {
            string sql = "SELECT id, name, manager FROM department WHERE id != 99999";
            departments = (List<DepartmentInfo>)DBConnetion.getInstance().Select(sql,2);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lastPanel.Dispose();
            HRForm hR = new HRForm(this);
            hR.TopLevel = false;
            hR.Show();
            lastPanel = hR;
            this.MainPanel.Controls.Clear();
            this.MainPanel.Controls.Add(hR);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lastPanel.Dispose();
            attendance_card AC = new attendance_card(this);
            AC.TopLevel = false;
            AC.Show();
            lastPanel = AC;
            this.MainPanel.Controls.Clear();
            this.MainPanel.Controls.Add(AC);
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonTask_Click(object sender, EventArgs e)
        {
            lastPanel.Dispose();
            TaskForm task = new TaskForm(this, me);
            task.TopLevel = false;
            task.Show();
            lastPanel = task;
            this.MainPanel.Controls.Clear();
            this.MainPanel.Controls.Add(task);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lastPanel.Dispose();
            DashBoard dashBoard = new DashBoard(me ,this);
            dashBoard.TopLevel = false;
            dashBoard.Show();
            this.MainPanel.Controls.Clear();
            this.MainPanel.Controls.Add(dashBoard);
            lastPanel = dashBoard;
        }

        private void buttonSign_Click(object sender, EventArgs e) //결재 버튼 클릭 시
        {
            lastPanel.Dispose();
            SignForm SF = new SignForm(this);
            SF.TopLevel = false;
            SF.Show();
            lastPanel = SF;
            this.MainPanel.Controls.Clear();
            this.MainPanel.Controls.Add(SF);
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
           
            ms.Show();
            this.MainPanel.Controls.Clear();
            this.MainPanel.Controls.Add(ms);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBoxForm message = new MessageBoxForm(this);
            message.TopLevel = false;
            message.Show();
            lastPanel = message;
            this.MainPanel.Controls.Clear();
            this.MainPanel.Controls.Add(message);
        }
    }
}
