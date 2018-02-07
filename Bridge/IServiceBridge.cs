namespace Bridge
{
    public interface IServiceBridge
    {
        double Total { get; set; }
        double ServiceCharge { get; set; }
        string ImplementorType { get; set; }
        double TotalTime { get; set; }

        double ComputeCost(double baseCost);
        void ProvideService(string serviceName, double serviceTime);
        void PrintSummary();
    }
}