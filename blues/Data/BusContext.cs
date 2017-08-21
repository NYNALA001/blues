using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using blues.Models;
namespace blues.Data
{
    public class BusContext : DbContext
        {
        public BusContext(DbContextOptions<BusContext> options) : base(options)
            {
            }
            public DbSet<BusStop> BusStops { get; set; }
            public DbSet<GeoInfo> GeoInfos { get; set; }
            public DbSet<Route> Routes { get; set; }
            public DbSet<RouteBusStopTime> RouteBusStopTimes { get; set; }
            public DbSet<RouteSection> RouteSections { get; set; }
            public DbSet<TimeSheet> TimeSheets { get; set; }
    }
}
