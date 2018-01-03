using System;
using System.Diagnostics;
using static Mediator.Setup.Helper;

namespace Strategy
{
    public static class Program
    {
        public static void Main()
        {
            SetTitle();
            Write("Welcome");

            var strat1 = new StrategyA();
            var strat2 = new StrategyB();
            var context = new Context();

            context.SetStrategy(strat1);
            context.Execution();

            context.SetStrategy(strat2);
            context.Execution();

            if (Debugger.IsAttached) Console.ReadLine();
        }
    }

    public static class States
    {
        public const string Louisiana = "LA";
        public const string Mississippi = "MS";
        public const string Texas = "TX";
        public const string Florida = "FL";
    }

    public class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy = null)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Execution()
        {
            _strategy.Execute();
        }
    }

    public interface IStrategy
    {
        void Execute();
    }
    public class StrategyA : IStrategy
    {
        public void Execute()
        {
            Write("Strategy A");
        }
    }
    public class StrategyB : IStrategy
    {
        public void Execute()
        {
            Write("Strategy B");
        }
    }
}
