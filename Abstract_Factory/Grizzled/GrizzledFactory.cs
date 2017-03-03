using Abstract_Factory.Core;
using Abstract_Factory.Franks;

namespace Abstract_Factory.Grizzled
{
    public class GrizzledFactory : MeatFactory
    {
        public override GroundBeef ProcessGroundBeef()
        {
            return new ManBurger();
        }

        public override Steak ProcessSteak()
        {
            return new FlintstonesSteak();
        }

        public override Roast ProcessRoast()
        {
            return new PotRoast();
        }
    }
}