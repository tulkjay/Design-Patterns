using static Factory_Method.Setup.Helper;

namespace Factory_Method.Core
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