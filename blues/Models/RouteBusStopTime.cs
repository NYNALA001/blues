using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blues.Models
{
    public class RouteBusStopTime
    {
        public int RouteBusStopTimeID { get; set; }
        public int BusStopId { get;  set; }
        public int RouteID { get; set; }
        public int TimeSheetId { get; set; }
        public int OrderIndex { get; set; }
    }
}
