using System;

namespace Bridge
{
    public class HumanImplementor : IServiceBridge
    {
        public double Total { get; set; }
        public double ServiceCharge { get; set; }
        public string ImplementorType { get; set; } = "human";

        public double TotalTime { get; set; }
        public double ComputeCost(double baseCost)
        {
            Total += baseCost;
            return baseCost;
        }

        public void ProvideService(string serviceName, double serviceTime)
        {
            Console.Write($"{serviceName, -30}{serviceTime:0.00}");
            TotalTime += serviceTime;
            AddServiceTip();
        }

        public void AddServiceTip()
        {
            Total *= 1.18;
        }

        public void PrintSummary()
        {
            Console.WriteLine($"\nTotal cost: {Total:0.00}\t Total Time: {TotalTime:0.00}");
        }
    }
}