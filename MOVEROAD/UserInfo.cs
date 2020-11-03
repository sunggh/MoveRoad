using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVEROAD
{
    public class UserInfo
    {
        private string name;
        private string address;
        private int age;
        private int grade;
        private int depart;

        public UserInfo(string name, string address, int age, int grade, int depart)
        {
            this.name = name;
            this.address = address;
            this.age = age;
            this.grade = grade;
            this.depart = depart;
        }
        public string getName()
        {
            return this.name;
        }
        public string getAddress()
        {
            return this.address;
        }
        public int getAge()
        {
            return this.age;
        }
        public int getGrade()
        {
            return this.grade;
        }
        public int getDepart()
        {
            return this.depart;
        }
    }
}
