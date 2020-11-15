using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVEROAD
{
    public class Message
    {
        public string from_name { get; set; }
        public string to_name { get; set; }
        public string messege { get; set; }
        public DateTime date { get; set; }
        public string title { get; set; }
        public int index { get; set; }
        public int reads { get; set; }


        public Message(string from, string to, string title, string messege, int index, DateTime date, int read)
        {
            this.from_name = from;
            this.to_name = to;
            this.title = title;
            this.messege = messege;
            this.index = index;
            this.date = date;
            this.reads = read;
        }
    }
}
