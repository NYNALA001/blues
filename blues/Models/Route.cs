using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blues.Models
{
    public class Route
    {
        public int RouteID { get; set; }
        public int RouteSectionID { get; set; }
        public String Name { get; set; }

        public ICollection<RouteBusStopTime> RouteBusStopTimes { get; set; }
    }
}
