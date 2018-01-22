using System;
using System.Collections.Generic;

namespace Design_Patterns
{
  public interface IOrderDecorator
  {
    double ProcessOrder(double total);
  }
}