using System;
using System.Collections.Generic;

namespace Design_Patterns
{
  public static class Program
  {
    public static void Main(string[] args)
    {

        var cart = new MyCart(Global.StoreItems);
        cart.Membership =  new GoldMembership();

        var defaultDecoratorOrder = new List<IOrderDecorator> {
            new MembershipDecorator(cart.Membership),
            new SaleDecorator(cart.Items),
            new ShippingDecorator(cart.Items),
        };
            
        cart.SetDiscountOrder(defaultDecoratorOrder);
        cart.Checkout();

        Console.WriteLine("Hello World!");
    }
  }
}

/*
    Decorators: 
        Membership discount
        Weight discount
        Sale discount

    Add items to cart
    Assign membership card
    Checkout:
        Give list of decorators for discount order
            Default
                Membership discount
                    Apply correct card discount
                    Apply cashback

                Weight discount
                    calculate cart weight
                    Add cost

                Sale discount
                    If order is over certain $$, add discount
                    If discount if over 10%, add free item

    Manager takes decorator order, applies decorators, and returns total/prints report.
 */
