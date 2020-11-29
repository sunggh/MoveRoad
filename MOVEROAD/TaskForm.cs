using MOVEROAD.InfoFile;
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
    public partial class TaskForm : Form
    {
        MainForm main;
        UserInfo me;
        TreeNode SelectedNode;  //업무 마스터에서 선택된 노드
        DataTable taskClass;    //select에서 datatable 받아온 것
        TaskClassInfo TaskClassInfo;    //id | name | parent_id | level | dapartment_id
        int subID;
        DateTime startTime;
        DateTime finishTime;

        //대분류 -> 중분류 -> 소분류 dataTable
        DataTable department = new DataTable();
        DataTable middleClass = new DataTable();
        DataTable subClass = new DataTable();

        List<DepartmentInfo> departmentInfos = new List<DepartmentInfo>();   //부서들 저장해 두는 리스트
        List<UserInfo> userInfos;                                            //시원들 저장해 두는 리스트

        public TaskForm(MainForm main, UserInfo me)
        {
            InitializeComponent();
            this.main = main;
            this.me = me;

            //업무 마스터 등록
            CreateTree();

            //일일 업무 등록
            CreateClassficationTable();
            setDepartmentCbItem();

            initDateTimepicker();

            //일일 업무 검색
            setTaskKeyword();
            setRegistrant();
        }
        private void CreateClassficationTable()
        {
            // ID | Name | ParentID | Level | DepartID
            string query = "SELECT * FROM task_class";
            taskClass = (DBConnetion.getInstance().Select(query, 4)) as DataTable;

            //대분류 생성
            department.Columns.Add("ID", typeof(int));   //table내에서 부여한 고유 ID
            department.Columns.Add("Name", typeof(string));    //이름
            department.Columns.Add("ParentID", typeof(int));       //상위 class의 ID
            //중분류 생성
            middleClass.Columns.Add("ID", typeof(int));   //table내에서 부여한 고유 ID
            middleClass.Columns.Add("Name", typeof(string));    //이름
            middleClass.Columns.Add("ParentID", typeof(int));       //상위 class의 ID
            //소분류 생성
            subClass.Columns.Add("ID", typeof(int));   //table내에서 부여한 고유 ID
            subClass.Columns.Add("Name", typeof(string));    //이름
            subClass.Columns.Add("ParentID", typeof(int));       //상위 class의 ID

            for (int i = 0; i < taskClass.Rows.Count; i++)
            {
                DataRow row = taskClass.Rows[i];
                int level = Convert.ToInt32(row["Level"]);
                if (level == 1)
                {
                    department.Rows.Add((int)row["ID"], (string)row["Name"], (int)row["ParentID"]);
                }
                else if (level == 2)
                {
                    middleClass.Rows.Add((int)row["ID"], (string)row["Name"], (int)row["ParentID"]);
                }
                else if (level == 3)
                {
                    subClass.Rows.Add((int)row["ID"], (string)row["Name"], (int)row["ParentID"]);

                }
                //Console.WriteLine((int)row["ID"] + (string)row["Name"] + (int)row["ParentID"]);
            }
        }
        #region 업무마스터관리
        private void CreateTree()
        {
            // ID | Name | ParentID | Level | DepartID
            string query = "SELECT * FROM task_class";
            taskClass = (DBConnetion.getInstance().Select(query, 4)) as DataTable;

            TreeNode rootNode = new TreeNode();
            //pid가 0인 최상위 노드 검색 -> 부서
            DataRow[] rows = taskClass.Select("ParentID = 0");
            rootNode.Text = rows[0]["Name"].ToString();
            rootNode.Tag = rows[0]["ID"].ToString();                      

            //하위 노드가 있는지 확인하도록 메소드 호출
            rootNode = ChkHasSubNode(rootNode);

            //완성된 노드를 TreeView에 추가
            treeViewTaskMaster.Nodes.Add(rootNode);

            // 모든 트리 노드를 보여준다
            treeViewTaskMaster.ExpandAll();
        }
        private TreeNode ChkHasSubNode(TreeNode parentNode)
        {
            int parentId = Convert.ToInt32(parentNode.Tag);
            // ParentNodeID가 parentNode의 parentId와 동일한 아이템을 조회
            DataRow[] rowCollection = taskClass.Select("ParentID = " + parentId);

            // 여러개일 수 있으므로 for문으로 실행
            for (int i = 0; i < rowCollection.Length; i++)
            {
                int id = Convert.ToInt32(rowCollection[i]["ID"]);
                string name = rowCollection[i]["Name"].ToString();
                int level = Convert.ToInt32(rowCollection[i]["level"]);
                int departID = Convert.ToInt32(rowCollection[i]["DepartID"]);
                if( level == 1)
                {
                    DepartmentInfo departmentInfo = new DepartmentInfo(id, name, departID, 1);
                    departmentInfos.Add(departmentInfo);
                    //Console.WriteLine("부서 아이디 : " + departmentInfo.subID);    //subID -> department table에서의 부서 id
                }
                // 노드 추가 매소드 호출
                parentNode = AddTreeNode(parentNode, id,name );
            }

            // 하위 노드가 없을경우 또는 for문을 완료한 경우 상위 노드 return
            return parentNode;
        }
        private TreeNode AddTreeNode(TreeNode parentNode, int id, string name)
        {
            // 추가할 노드 생성
            TreeNode node = new TreeNode();
            node.Text = name;
            node.Tag = id.ToString();
            // 상위 노드에 추가
            parentNode.Nodes.Add(node);

            // 현재 추가한 노드가 가진 하위노드 수를 조회하여 1개 이상을 가지고 있을경우 ChkHasSubNode매소드 호출
            if (taskClass.Select("ParentID = " + id).Length > 0)
                ChkHasSubNode(node);

            // 추가할 하위 노드가 없을경우 return
            return parentNode;
        }
        private void treeViewTaskMaster_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //nodeKey = e.Node.Text;
            //if (!string.IsNullOrEmpty(nodeKey))
            //{
            //    Console.WriteLine("선택된 노드 키 : " + nodeKey);
            //    Console.WriteLine("선택된 노드 태그 : " + e.Node.Tag);
            //    Console.WriteLine("선택된 노드 레벨 : " + e.Node.Level);
            //    Console.WriteLine("선택된 노드 부모노드 : " + e.Node.Parent);
            //}
            SelectedNode = treeViewTaskMaster.SelectedNode;
        }
        private void treeViewTaskMaster_MouseClick(object sender, MouseEventArgs e)
        {
            //오른쪽 클릭일 경우
            if (e.Button.Equals(MouseButtons.Right))
            {
                SelectedNode = treeViewTaskMaster.GetNodeAt(e.X, e.Y);
                treeViewTaskMaster.SelectedNode = SelectedNode;

                //오른쪽 메뉴를 만듭니다
                ContextMenu menu = new ContextMenu();

                //메뉴에 들어갈 아이템을 만듭니다
                MenuItem m1 = new MenuItem();
                MenuItem m2 = new MenuItem();
                MenuItem m3 = new MenuItem();

                m1.Text = "추가";
                m2.Text = "수정";
                m3.Text = "삭제";

        
                //각 메뉴를 선택했을 떄의 이벤트 핸들러
                //추가
                m1.Click += (senders, es) =>
                {                    
                    AddNewNode(senders, es);
                };
                //수정
                m2.Click += (senders, es) =>
                {
                    ReviseNodeText(senders, es);
                };
                //삭제
                m3.Click += (senders, es) =>
                {
                    DeleteNode(senders, es);
                };

                menu.MenuItems.Add(m1);
                menu.MenuItems.Add(m2);
                menu.MenuItems.Add(m3);

                //현재 마우슥 위치한 장소에 메뉴를 띄워줍니다.
                menu.Show(treeViewTaskMaster, new Point(e.X, e.Y));

            }
        }
        //ToDoList
        //1. 추가 했을 때 바뀐 이름으로 저장이 안됨.
        //2. 자칫 잘못해서 부서(root)가 삭제되는 경우 예외처리 확실히 하기
        //insert / update해야하는 위치 (label이 편집되고 나서 db에 접근해야 하는데 그전에 먼저 insert가 되는 상황 발생) 알아보기
        //일단 진도가 너무 안나가니까 다른거부터 하기

        private void AddNewNode(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(SelectedNode.Tag);    //선택된 노드의 id 가 새로운 노드의 parent_id
            int level = Convert.ToInt32(SelectedNode.Parent.Tag);

            if (level == 1) //선택된 노드의 parent id가 1이면, 새로운 노드는 lv = 2 
            {
                level = 2;
            }
            else    //선택된 노드의 parent id가 1이 아니면, 새로운 노드는 lv = 3
            { 
                level = 3;
            }

            TreeNode newNode = new TreeNode();  //새 노드
            newNode.Text = "입력하시오";        //임시 이름
            SelectedNode.Nodes.Add(newNode);    //선택된 노드 하위에 추가

            DepartmentInfo department = departmentInfos.Find(d => d.id == pid); //id -> taskclass에서의 id
            int departID = department.subID;                                    //subID -> department에서의 id

            TaskClassInfo = new TaskClassInfo("", pid, level, departID);  //새로운 노드의 정보 저장해두기
            treeViewTaskMaster.SelectedNode = newNode; //선택된 노드를 새로운 노드로 대입
            Console.WriteLine("AddNewNode : 선택된 노드의 이름 : " + SelectedNode.Name);
            ReviseNodeText(sender, e);          //노드의 name 정하기
            
            if (SelectedNode.IsEditing)
            {
                TaskClassInfo.name = SelectedNode.Text;
                Console.WriteLine("선택된 노드의 text : " + SelectedNode.Text);
                Console.WriteLine("업무 노드의 이름 : " + TaskClassInfo.name);
                //추가된 정보 DB INSERT하기
                string query = "INSERT INTO task_class(name,parent_id,level,depart_id) VALUES('" + TaskClassInfo.name + "','" + TaskClassInfo.pid + "','" + TaskClassInfo.level + "','" + TaskClassInfo.did + "')";
                DBConnetion.getInstance().Insert(query);
            }
        }
        private void ReviseNodeText(object sender, EventArgs e)
        {
            if (SelectedNode != null && SelectedNode.Parent != null)
            {
                treeViewTaskMaster.SelectedNode = SelectedNode;
                treeViewTaskMaster.LabelEdit = true;
                if (!SelectedNode.IsEditing)
                {
                    SelectedNode.BeginEdit();
                }
            }
            else
            {
                MessageBox.Show("선택한 업무가 없거나 선택한 업무는 수정할 수 없습니다.", "Invalid selection");
            }
        }

        private void treeViewTaskMaster_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label != null)
            {
                if (e.Label.Length > 0)
                {
                    if (e.Label.IndexOfAny(new char[] { '@', '.', ',', '!' }) == -1)
                    {
                        // Stop editing without canceling the label change.
                        e.Node.EndEdit(false);
                    }
                    else
                    {
                        /* Cancel the label edit action, inform the user, and
                           place the node in edit mode again. */
                        e.CancelEdit = true;
                        MessageBox.Show("'@','.', ',', '!' 특수문자는 입력할 수 없습니다.",
                           "Node Label Edit");
                        e.Node.BeginEdit();
                    }
                }
                else
                {
                    /* Cancel the label edit action, inform the user, and
                       place the node in edit mode again. */
                    e.CancelEdit = true;
                    MessageBox.Show("값을 입력해주세요.",
                       "Node Label Edit");
                    e.Node.BeginEdit();
                }
            }
            //바뀐 정보 DB UPDATE하기
            string query = "UPDATE task_class SET name = '" + SelectedNode.Text + "' WHERE id = '" + SelectedNode.Tag + "'";
            DBConnetion.getInstance().Update(query);
        }
        private void DeleteNode(object sender, EventArgs e)
        {
            if (SelectedNode != null && SelectedNode.Parent != null) { 
                if (MessageBox.Show(SelectedNode.Text + " 업무를 삭제하시겠습니까?\n삭제시 하위 정보도 모두 삭제됩니다.", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(SelectedNode.Tag);
                    string query = "DELETE FROM task_class WHERE parent_id = '" + id + "' OR id = '" + id + "'";

                    if (id != 1)
                    {   //혹시라도 root가 지워질 경우 방지  
                        DBConnetion.getInstance().Delete(query);
                        SelectedNode.Remove();
                    }
                }
            }
            else
            {
                MessageBox.Show("선택한 업무가 없거나 선택한 업무는 삭제할 수 없습니다.", "Invalid selection");
            }

        }
        #endregion
        #region 일일 업무 등록

        //부서선택 -> 1 업무구분선택 -> 2 업무선택 -> 3        
        int classflag = 0;  //아무것도 선택안 했을 때 1    
        
        private void comboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxDepartment.SelectedItem != null)
            {
                if (classflag > 1)
                {
                    comboBoxMiddleClass.SelectedItem = null;
                    comboBoxSubClass.SelectedItem = null;
                    comboBoxSubClass.Items.Clear();
                }
                classflag = 1;
                //int departID = comboBoxDepartment.SelectedIndex + 2;    //index는 0부터 시작 & 부서 제외
                //setMiddleCbItem(departID);
                string depart = comboBoxDepartment.SelectedItem as string;
                try
                {
                    DataRow[] rows = department.Select("Name = '" + depart + "'");
                    int departID = Convert.ToInt32(rows[0]["ID"]);
                    setMiddleCbItem(departID);

                }
                catch (EvaluateException ee)
                {
                    Console.WriteLine("오류 : " + ee);
                }
            }
        }
        private void comboBoxMiddleClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMiddleClass.SelectedItem != null && classflag >= 1)
            {
                if(classflag == 3)
                {
                    comboBoxSubClass.SelectedItem = null;
                    comboBoxSubClass.Items.Clear();
                }
                classflag = 2;
                string middleclass =  comboBoxMiddleClass.SelectedItem as string;
                try
                {
                    DataRow[] rows = middleClass.Select("Name = '" + middleclass + "'");
                    int middleID = Convert.ToInt32(rows[0]["ID"]);
                    setSubCbItem(middleID);

                }
                catch(EvaluateException ee)
                {
                    Console.WriteLine("오류 : " + ee);
                }
            }
        }
        private void comboBoxSubClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSubClass.SelectedItem != null && classflag >= 2)
            {
                classflag = 3;
                string subclass = comboBoxSubClass.SelectedItem as string;
                try
                {
                    DataRow[] rows = subClass.Select("Name = '" + subclass + "'");
                    subID = Convert.ToInt32(rows[0]["ID"]);
                }
                catch (EvaluateException ee)
                {
                    Console.WriteLine("오류 : " + ee);
                }
            }
        }
        private void setDepartmentCbItem()
        {
            for (int i = 0; i < department.Rows.Count; i++)
            {
                DataRow row = department.Rows[i];
                comboBoxDepartment.Items.Add(row["Name"].ToString());
            }
        }
        private void setMiddleCbItem(int departID)
        {
            if(classflag == 1)
            {
                comboBoxMiddleClass.Items.Clear();
                for (int i = 0; i < middleClass.Rows.Count; i++)
                {
                    int pid = Convert.ToInt32(middleClass.Rows[i]["ParentID"]);
                    if (pid == departID)
                        comboBoxMiddleClass.Items.Add(middleClass.Rows[i]["Name"].ToString());
                }
            }            
        }
        private void setSubCbItem(int middleID)
        {
            if (classflag == 2)
            {
                comboBoxSubClass.Items.Clear();
                for (int i = 0; i < subClass.Rows.Count; i++)
                {
                    int pid = Convert.ToInt32(subClass.Rows[i]["ParentID"]);
                    if (pid == middleID)
                        comboBoxSubClass.Items.Add(subClass.Rows[i]["Name"].ToString());
                }
            }
        }
        //endTime - startTime = 0 이하일 경우 등록 안되게하고
        //디비에서 업무시간이 겹치는게 있을 때 안되게 해야 함.
        private void initDateTimepicker()
        {
            dateTimePickerStartTime.ShowUpDown = true;
            dateTimePickerFinshTime.ShowUpDown = true;
        }
        private void dateTimePickerStartTime_ValueChanged(object sender, EventArgs e)
        {
            //기본설정
            DateTime dateTime = dateTimePickerStartTime.Value;
            dateTime = dateTime.AddHours(1);
            dateTimePickerFinshTime.Value = dateTime;
        }
        private bool haveTimeOverlap()
        {
            string date = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
            string query = "SELECT startTime,finishTime FROM task WHERE date = '" + date + "'";
            DataTable TaskHours = (DBConnetion.getInstance().Select(query, 13)) as DataTable;
            
            //datetime -> 초시간
            TimeSpan st = startTime.TimeOfDay;
            TimeSpan ft = finishTime.TimeOfDay;
            int nowStSec = (int)st.TotalSeconds;
            int nowFtSec = (int)ft.TotalSeconds;

            for(int i = 0; i < TaskHours.Rows.Count; i++)
            {
                int pastStSec = Convert.ToInt32(TaskHours.Rows[i]["StartTime"]);
                int pastFcSec = Convert.ToInt32(TaskHours.Rows[i]["FinishTime"]);
                //과거시작시간 < 현재시작시간 < 과거종료시간 이거나 과거시작시간 < 현재종료시간 < 과거종료시간 일때 겹침
                if ((pastStSec < nowStSec && nowStSec < pastFcSec) || (pastStSec < nowFtSec && nowFtSec < pastFcSec))
                {
                    return true;    //겹친다
                }
            }
            return false;   //안 겹친다
        }
        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            startTime = dateTimePickerStartTime.Value;
            finishTime = dateTimePickerFinshTime.Value;

            //datetime에 시간만 넣고 싶은데 왜 안되는 것이냐
            //startTime = string.Format("{0:g}", st.TimeOfDay); //->이거 나중에 시간 겹쳤는지 확인 할 때 쓰기
            //finishTime = string.Format("{0:g}", ft.TimeOfDay);
            string st = string.Format("{0:yyyy-MM-dd HH:mm:ss}", startTime);
            string ft = string.Format("{0:yyyy-MM-dd HH:mm:ss}", finishTime);

            //업무를 선택하지 않았을 경우
            //업무 내용을 적지 않았을 경우?
            // + 업무 시간이 겹치는 경우 && 종료시간이 시작시간보다 작은 경우)
            if (classflag != 3)
            {
                MessageBox.Show("업무를 선택하시오.");
            }
            else if (DateTime.Compare(startTime, finishTime) == 1 || haveTimeOverlap()) // st 보다 ft가 더 작으면
            {
                MessageBox.Show("업무시간을 확인하시오.");
            }
            else
            {
                //같은 날짜 다른 업무시간과 겹칠때 확인
                var result = MessageBox.Show("해당 업무를 등록하시겠습니까?", "업무 등록",MessageBoxButtons.YesNo);
                
                if (result == DialogResult.Yes)
                {
                    insertTask(st, ft);

                    //모든 상태 초기화
                    //comboBoxDepartment.Text = "";
                    comboBoxDepartment.SelectedItem = null;
                    comboBoxMiddleClass.SelectedItem = null;
                    comboBoxSubClass.SelectedItem = null;

                    textBoxTask.Text = "상세 업무 내용 기재";
                }
            }
        }
        private void insertTask(string startTime, string finishTime)
        {
            //업무    subID
            //날짜    datetime.now -> string date = string.Format("{0:yyyy-MM-dd}", datetime);
            //이름    me.name
            //업무내용  textBoxTask.Text
            //시작시간 종료시간 -> string.Format("{0:HH:mm:ss}", datetime
            try
            {
                string date = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
                string query = "INSERT INTO task(sub_id,date,name,text,startTime,finishTime) VALUES('" + subID + "','" + date + "','" + me.name + "','" + textBoxTask.Text + "','" + startTime + "','" + finishTime + "')";
                DBConnetion.getInstance().Insert(query);

                MessageBox.Show("업무가 등록되었습니다.");
            }
            catch
            {
                MessageBox.Show("디비 서버에 접근할 수 없습니다.");
            }
        }
        #endregion
        #region 일일 업무 검색 / 수정 / 삭제
        private void setTaskKeyword()
        {
            comboBoxTaskKeword.Items.Clear();
            for (int i = 0; i < subClass.Rows.Count; i++)
            {
                comboBoxTaskKeword.Items.Add(subClass.Rows[i]["Name"].ToString());
            }
        }
        private void setRegistrant()
        {
            string query = "SELECT * FROM user";
            userInfos = (DBConnetion.getInstance().Select(query, 14)) as List<UserInfo>;

            comboBoxRegistrant.Items.Clear();
            foreach(UserInfo user in userInfos)
            {
                comboBoxRegistrant.Items.Add(user.name);
            }
        }
        private void comboBoxTaskKeword_SelectedIndexChanged(object sender, EventArgs e)
        {            
            //날짜 + 키워드
            string date = string.Format("{0:yyyy-MM-dd}", dateTimePickerSearchTask.Value);
            try
            {
                //선택된 아이템의 id 찾기
                string name = comboBoxTaskKeword.SelectedItem as string;
                DataRow[] rows = subClass.Select("Name = '" + name + "'");
                int taskID = Convert.ToInt32(rows[0]["ID"]);

                string query = "SELECT * FROM task WHERE sub_id = '" + taskID + "' AND date = '" + date + "'";
                DataTable table = DBConnetion.getInstance().Select(query, 15) as DataTable;

                dataGridViewTask.DataSource = table;
                dataGridViewTask.Columns[0].Width = 50;
                dataGridViewTask.Columns[0].ReadOnly = true;
                dataGridViewTask.Columns[1].ReadOnly = true;
                dataGridViewTask.Columns[2].ReadOnly = true;
                dataGridViewTask.Columns[3].ReadOnly = true;
            }
            catch(IndexOutOfRangeException re)
            {
                Console.WriteLine("예외 : " + re);
            }
        }
        private void comboBoxRegistrant_SelectedIndexChanged(object sender, EventArgs e)
        {
            //선택된 아이템의 id 찾기
            string name = comboBoxRegistrant.SelectedItem.ToString();

            string query = "SELECT * FROM task WHERE name = '" + name + "'";
            DataTable table = DBConnetion.getInstance().Select(query, 15) as DataTable;
            
            dataGridViewTask.DataSource = table;
            dataGridViewTask.Columns[0].Width = 50;
            dataGridViewTask.Columns[0].ReadOnly = true;
            dataGridViewTask.Columns[1].ReadOnly = true;
            dataGridViewTask.Columns[2].ReadOnly = true;
            dataGridViewTask.Columns[3].ReadOnly = true;
        }

        private void buttonReviseTask_Click(object sender, EventArgs e)
        {
            try
            {
                Application.UseWaitCursor = false;

                DataTable dtChanges = new DataTable();
                DataTable dtProcessFlag = (DataTable)dataGridViewTask.DataSource;

                //Added 하면 젠체애들 다 업데이트 해주긴 함
                dtChanges = dtProcessFlag.GetChanges(DataRowState.Modified);

                string revisedIndex = "";
                if(dtChanges != null)
                {
                    for(int i = 0; i < dtChanges.Rows.Count; i++)
                    {
                        int id = (int)dtChanges.Rows[i]["ID"];
                        string text = dtChanges.Rows[i]["업무내용"] as string;
                        string date = dtChanges.Rows[i]["날짜"] as string;

                        string st = date + " " + dtChanges.Rows[i]["시작시간"];
                        string ft = date + " " + dtChanges.Rows[i]["종료시간"];

                        Console.WriteLine("시작시간 : " + st);
                        string query = "UPDATE task SET text = '" + text +"', startTime ='" + st + "', finishTime = '" + ft + "' WHERE id = '" + id + "'";
                        DBConnetion.getInstance().Update(query);

                        revisedIndex += id + " ";
                    }
                }
                MessageBox.Show("[ " +revisedIndex + " ] 업무 수정이 완료 되었습니다.");
                dtChanges = null;

                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                Console.WriteLine("오류 : " + ex);
                MessageBox.Show("입력 형식이 잘못되었습니다. 확인하고 다시 시도하십시오.");
            }
        }

        #endregion
        //일일 업무 마스터 treeview
        /*
        private void SetTaskMaster()
        {
            //대분류 (depertment) 생성
            string query = "SELECT * FROM department";
            List<DepartmentInfo> departments = (DBConnetion.getInstance().Select(query, 2)) as List<DepartmentInfo>;

            int i = 0;
            foreach(DepartmentInfo dpt in departments)
            {
                treeViewTaskMaster.Nodes.Add(dpt.name);
            }

            //중분류 (middle_class) 생성
            query = "SELECT * FROM middle_class";
            List<MiddleClassInfo> middleClass = (DBConnetion.getInstance().Select(query, 4)) as List<MiddleClassInfo>;
            
            foreach (MiddleClassInfo mc in middleClass)
            {
                //Node는 0부터 id는 1부터
                int depart = mc.depart -1 ;

                //[depart].[middle] 위치의 노드
                mc.middle = departments[mc.depart].subClassCount++;  //자신의 대분류 하위 인덱스 번호
                treeViewTaskMaster.Nodes[depart].Nodes.Add(mc.name);             //추가
            }

            //소분류 (sub_class) 생성
            query = "SELECT * FROM sub_class";
            List<SubClassInfo> SubClasses = (DBConnetion.getInstance().Select(query, 5)) as List<SubClassInfo>;

            foreach (SubClassInfo sc in SubClasses)
            {
                MiddleClassInfo highmc = new MiddleClassInfo(); //sub_Class의 상위 middle_Class                
                foreach (MiddleClassInfo mc in middleClass) {
                    if (sc.mcid == mc.id)
                        highmc = mc;
                }
                int depart = highmc.depart - 1;
                int middle = highmc.middle;            

                treeViewTaskMaster.Nodes[depart].Nodes[middle].Nodes.Add(sc.name);
            }
            
            // 모든 트리 노드를 보여준다
            treeViewTaskMaster.ExpandAll();
        }   
        */
    }
}
