using System;
using System.Collections.Generic;

namespace Design_Patterns
{
  public class SaleDecorator : IOrderDecorator
  {
    private int SaleThreshold { get; set; } = 100;
    private int BonusThreshold { get; set; } = 200;
    private List<Item> BonusItems { get; set; } = new List<Item> {
            new Item { Name="Watch", Price=49.99 },
            new Item { Name="Watch", Price=49.99 },
            new Item { Name="Watch", Price=49.99 },
             };


    public double Sale = 0.03;
    private List<Item> _items { get; set; }

    public SaleDecorator(List<Item> items)
    {
      _items = items;
    }

    //Applies sale discount on item, adds bonus item if discount is over 10%
    public double ProcessOrder(double total)
    {
      Console.WriteLine("Processing sales");
      if (total >= BonusThreshold)
      {
        var itemIndex = new Random();
        _items.Add(BonusItems[itemIndex.Next() % BonusItems.Count]);
      }

      if (total >= SaleThreshold)
      {
        total *= Sale;
      }
      Console.WriteLine("discountedTotal in sale " + total);
      return total;
    }
  }
}