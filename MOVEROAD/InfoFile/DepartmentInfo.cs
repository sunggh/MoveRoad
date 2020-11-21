using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVEROAD.InfoFile
{
    public class DepartmentInfo
    {
        public int id { get; set; }
        public string name { get; set; }
        public int manager { get; set; }
        public int subClassCount { get; set; }  //하위 클래스(중분류) 개수 middle_class의 노드 위치를 알려주는 역할
        public int subID { get; set; }  //부서 관리 했을 때 task_class에서 활용하는 id

        public DepartmentInfo (int id, string name, int manager)
        {
            this.id = id;
            this.name = name;
            this.manager = manager;
            this.subClassCount = 0; //생성할 땐 하위 클래스 갯수 0으로 초기화 추후에 늘려감
        }
        public DepartmentInfo(int id, string name, int subID, int flag)
        {
            this.id = id;
            this.name = name;
            this.subID = subID;
        }
    }
}
