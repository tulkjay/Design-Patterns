using System.Collections.Generic;
using Decorator.OrderDependent.Decorators;
using static Decorator.OrderDependent.Setup.Helper;

namespace Decorator.OrderDependent
{
    public class MyCart
    {
        public List<Item> Items { get; set; }
        public Membership Membership { get; set; }
        private double StartingTotal { get; set; }
        public double Total { get; set; }
        private readonly DiscountManager _discountManager;

        public MyCart(List<Item> items)
        {
            Items = items;
            Items.ForEach(x => { StartingTotal += x.Price; });

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
            Hr(false);

            Write("\tCart: ");
            Write("\tPrice($)\tWeight\tItem");

            Items.ForEach(x =>
            {
                Write($"\t{x.Price:0.00}\t\t{x.Weight}\t{x.Name}");
            });

            Write($"\nYour starting price is: ${StartingTotal:0.00}");
            Write($"Your final total is: ${Total:0.00}");

            var diff = StartingTotal - Total;
            Write($"You {(diff < 0 ? "added" : "saved")} ${(diff < 0 ? diff * -1 : diff):0.00}!");
        }
    }
}