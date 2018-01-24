using System;
using static Decorator.OrderDependent.Setup.Helper;

namespace Decorator.OrderDependent.Decorators
{
    public class MembershipDecorator : IOrderDecorator
    {
        private Membership Membership { get; set; }

        public MembershipDecorator(Membership membership = null)
        {
            Membership = membership;
        }

        public double ProcessOrder(double total)
        {
            Set(ConsoleColor.Yellow);
            Write($"\tProcessing membership discount{(Membership != null ? $" for {Membership.Name} card (%{Membership.Discount*100})" : "")}");

            double discount = 0;

            if (Membership != null)
            {
                discount = Membership.Discount * total;
            }

            var discountedTotal = total - discount;

            Set(ConsoleColor.Cyan);
            return discountedTotal;
        }
    }
}