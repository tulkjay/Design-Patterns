namespace FactoryDesignPatterns
{
    public abstract class MeatFactory
    {
        public abstract GroundBeef ProcessGroundBeef();

        public abstract Steak ProcessSteak();

        public abstract Roast ProcessRoast();
    }
}