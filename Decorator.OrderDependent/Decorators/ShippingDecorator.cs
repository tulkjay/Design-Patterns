using System;
using System.Collections.Generic;

namespace Design_Patterns
{
  public class ShippingDecorator : IOrderDecorator
  {
    private const double ShippingPricePerPound = 0.15;
    private List<Item> _items { get; set; }

    public ShippingDecorator(List<Item> items)
    {
        _items = items;
    }

    public double ProcessOrder(double total)
    {
      Console.WriteLine("Processing shipping");
      double weight = 0.0;
      _items.ForEach(x => {
        weight += x.Weight;
      });

      total += (weight * ShippingPricePerPound);
      Console.WriteLine("discountedTotal in shipping " + total);
      return total;
    }
  }
}