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
        public string roadname { get; set; }

        public Address (int zoneNumber, string placeName, string roadName)
        {
            this.zonenumber = zoneNumber;
            this.placename = placeName;
            this.roadname = roadName;
        }
    }
}
