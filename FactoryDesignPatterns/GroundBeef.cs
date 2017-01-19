using static FactoryDesignPatterns.Helper;

namespace FactoryDesignPatterns
{
    public class GroundBeef : Beef
    {
        public override string Name { get; set; } = "Ground Beef";
    }

    public class GroundBeefFactory : BeefFactory
    {
        public override Beef ProcessBeef()
        {
            Write("Cutting chuck section");
            Write("Grinding");
            return new GroundBeef();
        }
    }
}