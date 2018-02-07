namespace Bridge
{
    public class SpecializedServiceProvider : ServiceProvider
    {
        public double RestockingFee { get; set; } = 15;
        public override double GetCost(double rawMaterialCost)
        {
            Implementor.ComputeCost(rawMaterialCost);

            Implementor.ServiceCharge *= 2;

            return Implementor.Total;
        }

        public void RequestRestock()
        {
            Implementor.Total += RestockingFee;
        }
    }
}