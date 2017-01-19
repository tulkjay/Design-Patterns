using static FactoryDesignPatterns.Helper;

namespace FactoryDesignPatterns
{
    public class Steak : Beef
    {
        public override string Name { get; set; } = "Steak";
    }

    public class SteakFactory : BeefFactory
    {
        public override Beef ProcessBeef()
        {
            Write("Cutting backstrap section");
            Write("Slicing backstrap into steaks");
            return new Steak();
        }
    }
}