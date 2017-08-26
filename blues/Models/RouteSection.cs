using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace blues.Models
{
    public class RouteSection
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RouteSectionID { get; set; }
        public String Name { get; set; }
        public String Details { get; set; }

        public ICollection<Route> Routes { get; set; }
    }
}
