using System.ComponentModel.DataAnnotations.Schema;

namespace blues.Models
{
    public class RouteBusStopTime
    {
        public int RouteBusStopTimeID { get; set; }
        public int OrderIndex { get; set; }

        public BusStop BusStopID { get;  set; }
        public Route RouteID { get; set; }
        public TimeSheet TimeSheetID { get; set; }
        
    }
}
