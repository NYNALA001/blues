using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace blues.Models
{
    public class BusStop
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusStopID { get; set; }
        public String Name { get; set; }
        public String Address { get; set; }
        public int latitude { get; set; }
        public int longitude { get; set; }

        public ICollection<RouteBusStopTime> RouteBusStopTimes { get; set; }
    }
}
