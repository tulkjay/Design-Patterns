using System;
using System.Collections.Generic;
using Decorator.OrderDependent.Decorators;
using static Decorator.OrderDependent.Setup.Helper;

namespace Decorator.OrderDependent
{
  public class DiscountManager
  {
    private MyCart _cart;
    public List<IOrderDecorator> DecoratorList = new List<IOrderDecorator>();

    public DiscountManager(List<IOrderDecorator> decorators = null)
    {
      if (decorators != null)
      {
        DecoratorList = decorators;
      }
    }

    private void Process(IOrderDecorator decorator) {
      var startingValue = _cart.Total;
      Write("\nApplying: " + decorator.GetType().Name, ConsoleColor.Magenta);

      _cart.Total = decorator.ProcessOrder(_cart.Total);

      Console.WriteLine($"\nTotal changed from ${startingValue:0.00} to ${_cart.Total:0.00} ({(_cart.Total - startingValue):0.00})\n");
    }

    public double ApplyDiscounts(MyCart cart)
    {
      _cart = cart;

      DecoratorList.ForEach(Process);

      return _cart.Total;
    }
  }
}