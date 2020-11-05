using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVEROAD
{
   public class Address
    {
        public int zonenumber { get; set; }
        public string placename { get; set; }

        public Address (int zoneNumber, string placeName)
        {
            this.zonenumber = zoneNumber;
            this.placename = placeName;
        }
    }
}
