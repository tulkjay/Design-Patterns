using System.Collections.Generic;

namespace Design_Patterns
{
  public static class Global
  {
    public static double SalesTax { get; set; } = 0.1;
    public static List<Item> StoreItems = new List<Item>{
            new Item{Name = "Eggs", Price = 2.89, Weight = 3},
            new Item{Name = "Car", Price = 23998.26, Weight = 3},
            new Item{Name = "Boat", Price = 42182.99, Weight = 3},
            new Item{Name = "Shoes", Price = 59.99, Weight = 3},
            new Item{Name = "Keyboard", Price = 89.99, Weight = 3},
            new Item{Name = "Computer", Price = 2399.00, Weight = 3},
        };
  }
}