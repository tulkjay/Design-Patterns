using System.Collections.Generic;

namespace Design_Patterns
{
  public class MyCart
  {
    public List<Item> Items { get; set; } = new List<Item>();
    public Membership Membership { get; set; }
    public double StartingTotal { get; set; }
    public double Total { get; set; }
    private DiscountManager _discountManager;

    public MyCart(List<Item> items)
    {
      Items = items;

      Items.ForEach(x => {
        StartingTotal += x.Price;
      });

      Total = StartingTotal;
      _discountManager = new DiscountManager();
    }
    public void SetDiscountOrder(List<IOrderDecorator> decorators)
    {
      _discountManager.DecoratorList = decorators;
    }

    public void Checkout()
    {
      Total = _discountManager.ApplyDiscounts(this);
      System.Console.WriteLine(StartingTotal + ". Now your total is: " + Total);
    }
  }
}