using static FactoryDesignPatterns.Helper;

namespace FactoryDesignPatterns
{
    public class Roast : Beef
    {
        public override string Name { get; set; } = "Roast";
    }

    public class RoastFactory : BeefFactory
    {
        public override Beef ProcessBeef()
        {
            Write("Cutting rump roast section"); ;
            return new Roast();
        }
    }
}