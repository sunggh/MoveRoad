using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVEROAD
{
    public class UserInfo
    {
        public int index { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int age { get; set; }
        public int grade { get; set; }
        public int depart { get; set; }
        public int gender { get; set; }

        public UserInfo(int index ,string name, int age, int depart, int grade, string address,int gender)
        {
            this.index = index;
            this.name = name;
            this.address = address;
            this.age = age;
            this.grade = grade;
            this.depart = depart;
            this.gender = gender;
        }
    }
}
