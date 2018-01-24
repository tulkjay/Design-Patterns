using System;
using System.Collections.Generic;
using System.Diagnostics;
using Decorator.OrderDependent.Decorators;
using static Decorator.OrderDependent.Setup.Helper;

namespace Decorator.OrderDependent
{
    public static class Program
    {
        public static void Main()
        {
            var items = new List<Item>
            {
                new Item {Name = "Eggs", Price = 2.89, Weight = 3},
                new Item {Name = "Toupé", Price = 3998.26, Weight = 1},
                new Item {Name = "Cufflinks", Price = 2182.99, Weight = 6},
                new Item {Name = "Shoes", Price = 59.99, Weight = 9},
                new Item {Name = "Keyboard", Price = 89.99, Weight = 5},
                new Item {Name = "Computer", Price = 2399.00, Weight = 20},
            };

            SetTitle();
            var cart = new MyCart(items)
            {
                Membership = new GoldMembership(),
            };

            var defaultDecoratorOrder = new List<IOrderDecorator>
            {
                new MembershipDecorator(cart.Membership),
                new SaleDecorator(cart.Items),
                new ShippingDecorator(cart.Items),
            };

            cart.SetDiscountOrder(defaultDecoratorOrder);
            cart.Checkout();

            if (Debugger.IsAttached)
            {
                Console.ReadLine();
            }
        }
    }
}