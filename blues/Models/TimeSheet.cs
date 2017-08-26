using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace blues.Models
{
    public class TimeSheet
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TimeSheetID { get; set; }
        public DateTime FirstBus { get; set; }
        public DateTime LastBus { get; set; }
        public DateTime FirstBusInHour { get; set; }
        public DateTime SecondBusInHour { get; set; }

        public ICollection<RouteBusStopTime> RouteBusStopTimes { get; set; }
    }
}
