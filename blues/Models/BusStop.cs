using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace blues.Models
{
    public class BusStop
    {
        public int BusStopID { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }

        public ICollection<RouteBusStopTime> RouteBusStopTimes { get; set; }
    }
}
