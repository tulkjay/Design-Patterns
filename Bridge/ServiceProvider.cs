namespace Bridge
{
    public class ServiceProvider
    {
        public IServiceBridge Implementor { set; get; }

        public void ProvideService(string serviceName, double serviceTime)
        {
            Implementor.ProvideService(serviceName, serviceTime);
        }

        public virtual double GetCost(double rawMaterialCost)
        {
            return Implementor.ComputeCost(rawMaterialCost);
        }

        public void ShowResults()
        {
            Implementor.PrintSummary();
        }
    }
}