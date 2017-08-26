using Microsoft.EntityFrameworkCore;
using blues.Models;

namespace blues.Data
{
    public class BusContext : DbContext
        {
        public BusContext(DbContextOptions<BusContext> options) : base(options)
            {

            }
            public DbSet<BusStop> BusStops { get; set; }

            public DbSet<Route> Routes { get; set; }

            public DbSet<RouteBusStopTime> RouteBusStopTimes { get; set; }

            public DbSet<RouteSection> RouteSections { get; set; }

            public DbSet<TimeSheet> TimeSheets { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                  modelBuilder.Entity<BusStop>().ToTable("BusStop");
                  modelBuilder.Entity<Route>().ToTable("Route");
                  modelBuilder.Entity<RouteBusStopTime>().ToTable("RouteBusStopTime");
                  modelBuilder.Entity<RouteSection>().ToTable("RouteSection");
                  modelBuilder.Entity<TimeSheet>().ToTable("TimeSheet");
            }
    }
}
