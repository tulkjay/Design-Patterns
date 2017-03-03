using Abstract_Factory.Core;

namespace Abstract_Factory.Franks
{
    public class FranksFactory : MeatFactory
    {
        public override GroundBeef ProcessGroundBeef()
        {
            return new FranksPatty();
        }

        public override Steak ProcessSteak()
        {
            return new HomestyleSteak();
        }

        public override Roast ProcessRoast()
        {
            return new MomsRoast();
        }
    }
}
