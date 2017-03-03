using System;
using System.Collections.Generic;
using System.Linq;
using Abstract_Factory.Helpers;

namespace Abstract_Factory.Core
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
            Helper.Set(Helper.Options.C);

            for (var i = 0; i < order.UnitsOfGroundBeef; i++)
            {
                itemList.Add(Factory.ProcessGroundBeef());
                Helper.Write($"Processing {itemList.Last().Name}");
            }
            Helper.Set(Helper.Options.B);

            for (var i = 0; i < order.UnitsOfSteak; i++)
            {
                itemList.Add(Factory.ProcessSteak());
                Helper.Write($"Processing {itemList.Last().Name}");
            }
            Helper.Set(Helper.Options.G);

            for (var i = 0; i < order.UnitsOfRoast; i++)
            {
                itemList.Add(Factory.ProcessRoast());
                Helper.Write($"Processing {itemList.Last().Name}");
            }
            Helper.Set(Helper.Options.C);

            Console.WriteLine($"\nThe order has been filled: {itemList.Count} items ordered");
            Helper.Set(Helper.Options.G);
        }
    }
}