using static Factory_Method.Setup.Helper;

namespace Factory_Method.Core
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