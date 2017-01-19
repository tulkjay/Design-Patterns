using System;
using static FactoryDesignPatterns.Helper;

namespace FactoryDesignPatterns
{
    public class Program
    {
        public static void Main()
        {
            Set(new[] { Options.G, Options.Simple }, true);

            var simpleFactory = new SimpleMeatFactory();
            var chuckBeef = simpleFactory.GetMeat(Grade.Chuck);
            var mediumBeef = simpleFactory.GetMeat(Grade.Medium);
            var leanBeef = simpleFactory.GetMeat(Grade.Lean);

            Write($"The simple factory made: {chuckBeef.Name} for ${chuckBeef.Price}/lb\n");

            Set(new[] { Options.C });

            Write($"The simple factory made: {mediumBeef.Name} for ${mediumBeef.Price}/lb\n");

            Set(new[] { Options.B });

            Write($"The simple factory made: {leanBeef.Name} for ${leanBeef.Price}/lb\n");

            Console.ReadLine();
        }
    }
}