using System;
using Bridge.Setup;

namespace Bridge
{
    public class RobotImplementor : IServiceBridge
    {
        public double Total { get; set; }
        public double ServiceCharge { get; set; }
        public string ImplementorType { get; set; } = "robot";
        public double TotalTime { get; set; }

        public double ComputeCost(double baseCost)
        {
            Total += baseCost * 1.1;

            return baseCost * 1.1;
        }

        public void ProvideService(string serviceName, double serviceTime)
        {
            var adjustedServiceTime = serviceTime * .75;
            Console.Write($"{serviceName,-30}{adjustedServiceTime:0.00}");

            TotalTime += adjustedServiceTime;
        }

        public void PrintSummary()
        {
            Helper.Write($"\n\t\t Total Time: {TotalTime:#00.00}   Total Cost: {Total:$#00.00}", ConsoleColor.Yellow);
        }
    }
}