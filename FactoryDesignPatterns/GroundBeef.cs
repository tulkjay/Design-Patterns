using static FactoryDesignPatterns.Helper;

namespace FactoryDesignPatterns
{
    public enum Grade
    {
        Lean, Chuck, Medium
    }

    public abstract class GroundBeef
    {
        public abstract string Name { get; }
        public abstract double Price { get; set; }
    }

    public class Lean : GroundBeef
    {
        public override string Name { get; } = "Lean Ground Beef";
        public override double Price { get; set; } = 4.95;
    }

    public class Medium : GroundBeef
    {
        public override string Name { get; } = "Medium Ground Beef";
        public override double Price { get; set; } = 3.49;
    }

    public class Chuck : GroundBeef
    {
        public override string Name { get; } = "Chuck Ground Beef";
        public override double Price { get; set; } = 2.79;
    }
}