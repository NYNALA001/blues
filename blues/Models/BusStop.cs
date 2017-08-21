using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blues.Models
{
    public class BusStop
    {
        public int BusStopID { get; set; }
        public int GeoInfoID { get; set; }
        public String Name { get; set; }
        public ICollection<RouteBusStopTime> RouteBusStopTimes { get; set; }
    }
}
