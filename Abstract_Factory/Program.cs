using System;
using Abstract_Factory.Core;
using Abstract_Factory.Franks;
using Abstract_Factory.Grizzled;
using static Abstract_Factory.Helpers.Helper;

namespace Abstract_Factory
{
    public class Program
    {
        public static void Main()
        {
            Set(Options.G, true);

            //Frank's Order
            var franksOrder = new Order(4, 3, 5);

            var franksFactory = new FranksFactory();
            var processor = new MeatOrder(franksFactory);

            processor.Fill(franksOrder);

            //Grizzled's Order
            var grizzledOrder = new Order(2, 6, 1);

            var grizzledFactory = new GrizzledFactory();
            processor = new MeatOrder(grizzledFactory);

            processor.Fill(grizzledOrder);

            Console.ReadLine();
        }
    }
}
