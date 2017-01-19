using System;

namespace FactoryDesignPatterns
{
    public class SimpleMeatFactory
    {
        public GroundBeef GetMeat(Grade grade)
        {
            switch (grade)
            {
                case Grade.Lean:
                    return new Lean();

                case Grade.Medium:
                    return new Medium();

                case Grade.Chuck:
                    return new Chuck();

                default:
                    throw new ArgumentOutOfRangeException(nameof(grade), grade, null);
            }
        }
    }
}