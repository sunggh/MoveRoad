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
        private string nodeKey;
        TreeNode SelectedNode;
        DataTable taskClass;
        TaskClassInfo TaskClassInfo;

        public TaskForm(MainForm main)
        {
            InitializeComponent();
            this.main = main;

            CreateTree();
            //SetTaskMaster();
        }
        private void CreateTree()
        {
            // ID | Name | ParentID | Level
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
                // 노드 추가 매소드 호출
                parentNode = AddTreeNode(parentNode, Convert.ToInt32(rowCollection[i]["ID"]), rowCollection[i]["Name"].ToString());
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
            nodeKey = e.Node.Text;
            if (!string.IsNullOrEmpty(nodeKey))
            {
                Console.WriteLine("선택된 노드 키 : " + nodeKey);
                Console.WriteLine("선택된 노드 태그 : " + e.Node.Tag);
                Console.WriteLine("선택된 노드 레벨 : " + e.Node.Level);
                Console.WriteLine("선택된 노드 부모노드 : " + e.Node.Parent);
            }
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
            

            TaskClassInfo = new TaskClassInfo("", pid, level);  //새로운 노드의 정보 저장해두기
            SelectedNode = newNode; //선택된 노드를 새로운 노드로 대입
            ReviseNodeText(sender, e);          //노드의 name 정하기

            TaskClassInfo.name = SelectedNode.Text;
            //추가된 정보 DB INSERT하기
            string query = "INSERT INTO task_class(name,parent_id,level) VALUES('" + TaskClassInfo.name + "','" + TaskClassInfo.pid + "','" + TaskClassInfo.level + "')";
            DBConnetion.getInstance().Insert(query);
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
            ////바뀐 정보 DB UPDATE하기
            //string query = "UPDATE task_class SET name = '" + SelectedNode.Text + "' WHERE id = '" + SelectedNode.Tag + "'";
            //DBConnetion.getInstance().Update(query);
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
