using System;

namespace Design_Patterns
{
  public class MembershipDecorator : IOrderDecorator
  {
    private Membership _membership { get; set; }

    public MembershipDecorator(Membership membership = null)
    {
      _membership = membership;
    }

    public double ProcessOrder(double total)
    {
        Console.WriteLine("Processing membership " + total);
        double discount = 0;

        if(_membership != null) {
            discount = _membership.Discount * total;
        }

        var discountedTotal = total - discount;
        Console.WriteLine("discountedTotal in mem " + discountedTotal);
        return discountedTotal;
    }
  }
}