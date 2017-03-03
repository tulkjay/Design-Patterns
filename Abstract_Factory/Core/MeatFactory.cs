using Abstract_Factory.Franks;

namespace Abstract_Factory.Core
{
    public abstract class MeatFactory
    {
        public abstract GroundBeef ProcessGroundBeef();

        public abstract Steak ProcessSteak();

        public abstract Roast ProcessRoast();
    }
}