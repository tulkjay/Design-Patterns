using System.Collections.Generic;

namespace Design_Patterns
{
  public class DiscountManager
  {
    private SaleDecorator _saleDecorator;
    private ShippingDecorator _shippingDecorator;
    private MembershipDecorator _membershipDecorator;
    private List<Item> _items;
    public List<IOrderDecorator> DecoratorList;

    public DiscountManager(List<IOrderDecorator> decorators = null)
    {
      if (decorators != null)
      {
        DecoratorList = decorators;
      }
      else
      {
        DecoratorList = new List<IOrderDecorator>
        {
        };
      }
    }

    private string _analysis = "Analysis";

    public double ApplyDiscounts(MyCart cart)
    {
      System.Console.WriteLine("Applying discounts in manager" + cart.StartingTotal);
      DecoratorList.ForEach(x =>
      {
        cart.Total = x.ProcessOrder(cart.Total);
      });
      return cart.Total;
    }
    public void ReportAnalysis()
    {
      System.Console.WriteLine(_analysis);
    }
  }
}