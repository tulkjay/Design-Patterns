using System;
using System.Collections.Generic;
using System.Linq;
using static FactoryDesignPatterns.Helper;

namespace FactoryDesignPatterns
{
    public class MeatOrder
    {
        private MeatFactory Factory { get; }

        public MeatOrder(MeatFactory factory)
        {
            Factory = factory;
        }

        public void Fill(Order order)
        {
            var itemList = new List<Item>();
            Set(Options.C);

            for (var i = 0; i < order.UnitsOfGroundBeef; i++)
            {
                itemList.Add(Factory.ProcessGroundBeef());
                Write($"Processing {itemList.Last().Name}");
            }
            Set(Options.B);

            for (var i = 0; i < order.UnitsOfSteak; i++)
            {
                itemList.Add(Factory.ProcessSteak());
                Write($"Processing {itemList.Last().Name}");
            }
            Set(Options.G);

            for (var i = 0; i < order.UnitsOfRoast; i++)
            {
                itemList.Add(Factory.ProcessRoast());
                Write($"Processing {itemList.Last().Name}");
            }
            Set(Options.C);

            Console.WriteLine($"\nThe order has been filled: {itemList.Count} items ordered");
            Set(Options.G);
        }
    }
}