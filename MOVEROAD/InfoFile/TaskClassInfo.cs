using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVEROAD.InfoFile
{
    public class TaskClassInfo
    {
        public int id;
        public string name;
        public int pid; //parent_id
        public int level;
        public int did; //depart_id
        
        public TaskClassInfo(int id, string name, int pid, int level)
        {
            this.id = id;
            this.name = name;
            this.pid = pid;
            this.level = level;
        }
        public TaskClassInfo(string name, int pid, int level, int did, int flag)
        {
            this.name = name;
            this.pid = pid;
            this.level = level;
            this.did = did;
        }
    }
}
