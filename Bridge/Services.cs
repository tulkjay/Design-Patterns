using System.Collections.Generic;

namespace Bridge
{
    public class Service
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public double Time { get; set; }
    }
    public static class Services
    {
        public const string RoomService = "Room Service";
        public const string CheckOutService = "Check Out Service";
        public const string CheckInService = "Check In Service";
        public const string DryCleaningService = "Dry Cleaning Service";
        public const string BreakfastService = "Breakfast Service";
        public const string DinnerService = "Dinner Service";

        public static readonly List<Service> StandardServiceList = new List<Service>
        {
            new Service{Name = DryCleaningService, Cost = 5, Time = 50},
            new Service{Name = BreakfastService, Cost = 10, Time = 15},
            new Service{Name = DinnerService, Cost = 30, Time = 45},
        };

        public static readonly List<Service> SpecializedServiceList = new List<Service>
        {
            new Service{Name = DryCleaningService, Cost = 5, Time = 50},
            new Service{Name = BreakfastService, Cost = 10, Time = 15},
            new Service{Name = DinnerService, Cost = 30, Time = 45},
        };
    }
}