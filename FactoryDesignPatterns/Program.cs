using System;
using System.Collections.Generic;
using static FactoryDesignPatterns.Helper;

namespace FactoryDesignPatterns
{
    public class Program
    {
        public static void Main()
        {
            Set(new[] { Options.G, Options.Method }, true);

            var groundBeefFactory = new GroundBeefFactory();
            var steakFactory = new SteakFactory();
            var roastFactory = new RoastFactory();

            const int groundBeefOrder = 3;
            const int steakOrder = 2;
            const int roastOrder = 4;

            var beefPile = new List<Beef>();
            for (var i = 1; i <= groundBeefOrder; i++)
            {
                beefPile.Add(groundBeefFactory.ProcessBeef());
            }

            Set(new[] { Options.C });
            Console.WriteLine($"\nThe warehouse just processed {beefPile.Count} units of ground beef.\n");

            Set(new[] { Options.G });
            beefPile.Clear();

            for (var i = 1; i <= steakOrder; i++)
            {
                beefPile.Add(steakFactory.ProcessBeef());
            }

            Set(new[] { Options.C });
            Console.WriteLine($"\nThe warehouse just processed {beefPile.Count} units of steak.\n");

            Set(new[] { Options.G });
            beefPile.Clear();

            for (var i = 1; i <= roastOrder; i++)
            {
                beefPile.Add(roastFactory.ProcessBeef());
            }

            Set(new[] { Options.C });
            Console.WriteLine($"\nThe warehouse just processed {beefPile.Count} units of roast.\n");

            Set(new[] { Options.B });
            beefPile.Clear();

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}