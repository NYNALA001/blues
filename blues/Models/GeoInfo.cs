using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blues.Models
{
    public class GeoInfo
    {
        public int GeoInfoID { get; set; }
        public int latitude { get; set; }
        public int longitude { get; set; }
        public String Address { get; set; }
    }
}
