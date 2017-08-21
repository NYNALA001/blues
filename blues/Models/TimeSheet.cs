using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blues.Models
{
    public class TimeSheet
    {
        public int TimeSheetID { get; set; }
        public DateTime FirstBus { get; set; }
        public DateTime LastBus { get; set; }
        public DateTime FirstBusInHour { get; set; }
        public DateTime SecondBusInHour { get; set; }

        public ICollection<RouteBusStopTime> RouteBusStopTimes { get; set; }
    }
}
