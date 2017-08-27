using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace blues.Models
{
    public class Route
    {
        public int RouteID { get; set; }
        public String Name { get; set; }

        public RouteSection RouteSectionID { get; set; }
        public ICollection<RouteBusStopTime> RouteBusStopTimes { get; set; }
    }
}
