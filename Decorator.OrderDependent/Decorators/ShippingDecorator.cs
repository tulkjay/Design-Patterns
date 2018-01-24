using System;
using System.Collections.Generic;
using System.Linq;
using static Decorator.OrderDependent.Setup.Helper;

namespace Decorator.OrderDependent.Decorators
{
    public class ShippingDecorator : IOrderDecorator
    {
        private const double ShippingPricePerPound = 12;
        private List<Item> Items { get; set; }

        public ShippingDecorator(List<Item> items)
        {
            Items = items;
        }

        public double ProcessOrder(double total)
        {
            Set(ConsoleColor.Green);
            Write($"\tProcessing shipping cost at ${ShippingPricePerPound:0.00} per pound");

            var weight = 0;
            weight = Items.Select(x => x.Weight).Aggregate((x, y) => x + y);
            total += (weight * ShippingPricePerPound);

            Write($"\tTotal Weight: {weight}");

            Set(ConsoleColor.Cyan);
            return total;
        }
    }
}