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

        public DepartmentInfo (int id, string name, int manager)
        {
            this.id = id;
            this.name = name;
            this.manager = manager;
        }
    }
}
