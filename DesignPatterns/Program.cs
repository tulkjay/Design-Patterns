using System;
using FactoryDesignPatterns.Setup;

namespace DesignPatterns
{
    public class Program
    {
        public static void Main()
        {
            Helper.Set(Helper.Options.G, true);

            Console.ReadLine();
        }
    }
}