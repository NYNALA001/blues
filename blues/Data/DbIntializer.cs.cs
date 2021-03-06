﻿using blues.Models;
using System;
using System.Linq;
namespace blues.Data
{
    public class DbIntializer
    {

        public static void Initialize(BusContext context)
        {
            context.Database.EnsureCreated();
            // Look for any students.
            if (context.RouteBusStopTimes.Any())
            {
                return; // DB has been seeded
            }

            var routeBusStopTimes = new RouteBusStopTime[]
            {
                new RouteBusStopTime{RouteBusStopTimeID=1, RouteID=1, BusStopId=1, OrderIndex=1, TimeSheetId=1}
            };

            foreach (RouteBusStopTime s in routeBusStopTimes)
            {
                context.RouteBusStopTimes.Add(s);
            }
            context.SaveChanges();

            var busStops = new BusStop[]
            {
                new BusStop{ GeoInfoID= 1, Name= "Forest Hill"}
            };

            foreach (BusStop b in busStops)
            {
                context.BusStops.Add(b);
            }
            context.SaveChanges();

            var routes = new Route[]
            {
                new Route { Name="Forest Hill", RouteSectionID = 0}
            };

            foreach (Route r in routes)
            {
                context.Add(r);
            }
            context.SaveChanges();

            var routeSections = new RouteSection[]
            {
                new RouteSection { Details ="FH-UP", Name="FH-UP"}
            };

            foreach (RouteSection r in routeSections)
            {
                context.Add(r);
            }
            context.SaveChanges();

            var timeSheets = new TimeSheet[]
            {
                new TimeSheet { FirstBus =DateTime.Parse("09:30"), FirstBusInHour=DateTime.Parse("10:30"), SecondBusInHour=DateTime.Parse("11:30"), LastBus=DateTime.Parse("20:30") }
            };

            foreach (TimeSheet t in timeSheets)
            {
                context.Add(t);
            }
            context.SaveChanges();

            var geoInfos = new GeoInfo[]
            {
                new GeoInfo { Address= "Forest Hill", latitude=10, longitude=15}
            };
            foreach (GeoInfo g in geoInfos)
            {
                context.Add(g);
            }
            context.SaveChanges();
        }
    }
}