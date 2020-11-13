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
        private string nodeKey;
        MainForm main;

        public TaskForm(MainForm main)
        {
            InitializeComponent();
            this.main = main;

            SetTaskMaster();
        }
        //일일 업무 마스터 treeview
        private void SetTaskMaster()
        {
            //대분류
            //중분류
            //소분류     
            /*
            treeViewTaskMaster.Nodes.Add("음식");

            treeViewTaskMaster.Nodes[0].Nodes.Add("바나나");
            treeViewTaskMaster.Nodes[0].Nodes.Add("키위");
            treeViewTaskMaster.Nodes[0].Nodes.Add("블루베리");
            treeViewTaskMaster.Nodes[0].Nodes.Add("딸기");

            treeViewTaskMaster.Nodes[0].Nodes[0].Nodes.Add("구운바나나");
            treeViewTaskMaster.Nodes[0].Nodes[0].Nodes.Add("삶은바나나");

            treeViewTaskMaster.Nodes.Add("음식");

            treeViewTaskMaster.Nodes[1].Nodes.Add("바나나");
            treeViewTaskMaster.Nodes[1].Nodes.Add("키위");
            treeViewTaskMaster.Nodes[1].Nodes.Add("블루베리");
            treeViewTaskMaster.Nodes[1].Nodes.Add("딸기");

            treeViewTaskMaster.Nodes[1].Nodes[0].Nodes.Add("구운바나나");
            treeViewTaskMaster.Nodes[1].Nodes[0].Nodes.Add("삶은바나나");
            // 모든 트리 노드를 보여준다
            treeViewTaskMaster.ExpandAll();
            */
            string query = "SELCT * FROM department";
            //DBConnetion.getInstance().Select(query, 5);

            

        }

        private void treeViewTaskMaster_AfterSelect(object sender, TreeViewEventArgs e)
        {
            nodeKey = e.Node.Text;
            if (!string.IsNullOrEmpty(nodeKey))
            {
                Console.WriteLine("선택된 노드 키 : " + nodeKey);
            }
        }
        //클릭을 하고 오른쪽을 눌러야 해당 키가 select가 됨.
        private void treeViewTaskMaster_MouseClick(object sender, MouseEventArgs e)
        {
            //오른쪽 클릭일 경우
            if (e.Button.Equals(MouseButtons.Right))
            {
                //선택된 아이템의 Text를 저장해 놓습니다.
                //int i = 0;
                //if (treeViewTaskMaster.Selected.Count > 0)
                //{
                //    coffee.Id = Convert.ToInt32(listViewCoffee.Items[listViewCoffee.SelectedItems[i].Index].SubItems[0].Text);
                //    coffee.Type = listViewCoffee.Items[listViewCoffee.SelectedItems[i].Index].SubItems[1].Text;
                //    coffee.Price = Convert.ToInt32(listViewCoffee.Items[listViewCoffee.SelectedItems[i].Index].SubItems[2].Text);
                //    i++;
                //}
                TreeNode node = treeViewTaskMaster.GetNodeAt(e.X, e.Y);
                treeViewTaskMaster.SelectedNode = node;

                //오른쪽 메뉴를 만듭니다
                ContextMenu menu = new ContextMenu();

                //메뉴에 들어갈 아이템을 만듭니다
                MenuItem m1 = new MenuItem();
                MenuItem m2 = new MenuItem();

                m1.Text = "변경";
                m2.Text = "삭제";

                //각 메뉴를 선택했을 떄의 이벤트 핸들러
                //변경
                m1.Click += (senders, es) =>
                {
                    //외부 함수에 아까 선택했던 아이템의 정보를 넘겨준다.
                    //ReviseCoffee(coffee);
                };
                //삭제
                m2.Click += (senders, es) =>
                {
                    //외부 함수에 아까 선택했던 아이템의 정보를 넘겨준다.
                    //DeleteCoffee(selectedCoffee);
                };

                menu.MenuItems.Add(m1);
                menu.MenuItems.Add(m2);

                //현재 마우슥 위치한 장소에 메뉴를 띄워줍니다.
                menu.Show(treeViewTaskMaster, new Point(e.X, e.Y));

            }
        }
    }
}
