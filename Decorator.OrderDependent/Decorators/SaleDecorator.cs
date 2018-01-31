using System;
using System.Collections.Generic;
using static Decorator.OrderDependent.Setup.Helper;

namespace Decorator.OrderDependent.Decorators
{
    public class SaleDecorator : IOrderDecorator
    {
        private int SaleThreshold { get; set; } = 1000;
        private int BonusThreshold { get; set; } = 5000;

        private List<Item> BonusItems { get; set; } = new List<Item>
        {
            //new Item {Name = "Watch", Price = 69.99, Weight = 5},
            //new Item {Name = "Rug", Price = 99.99, Weight = 15},
            new Item {Name = "World Record Sandwich", Price = 9.99, Weight = 85},
        };


        private const double Sale = 0.05;
        private List<Item> Items { get; set; }

        public SaleDecorator(List<Item> items)
        {
            Items = items;
        }

        //Applies sale discount on item, adds bonus item if discount is over 10%
        public double ProcessOrder(double total)
        {
            Set(ConsoleColor.Red);
            Write("\tProcessing sale discount on items");
            if (total >= BonusThreshold)
            {
                var itemIndex = new Random();
                var bonusItem = BonusItems[itemIndex.Next() % BonusItems.Count];

                Write($"\tYou spent over ${BonusThreshold:0.00} and got an bonus item! {bonusItem.Name}");

                Items.Add(bonusItem);
            }

            if (total >= SaleThreshold)
            {
                Write($"\tYou spent over ${SaleThreshold:0.00} and got a %{Sale*100} discount!");
                total *= (1 - Sale);
            }

            Set(ConsoleColor.Cyan);
            return total;
        }
    }
}