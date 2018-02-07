using System;
using System.Diagnostics;
using static System.ConsoleColor;
using static Bridge.Services;
using static Bridge.Setup.Helper;

namespace Bridge
{
    public static class Program
    {
        public static void Main()
        {
            SetTitle();

            var serviceProvider = new ServiceProvider {Implementor = new HumanImplementor()};

            RunStandardService(serviceProvider);

            serviceProvider.Implementor = new RobotImplementor();
            RunStandardService(serviceProvider);

            var specializedServiceProvider = new SpecializedServiceProvider
            {
                Implementor = new HumanImplementor()
            };

            RunSpecializedService(specializedServiceProvider);

            specializedServiceProvider.Implementor = new RobotImplementor();

            RunSpecializedService(specializedServiceProvider);

            if (Debugger.IsAttached)
            {
                Console.ReadLine();
            }
        }

        private static void RunStandardService(ServiceProvider provider)
        {
            Set(DarkYellow);
            Console.WriteLine($"\nProviding {provider.Implementor.ImplementorType} standard services\n");
            Set(Magenta);
            Console.WriteLine($"{"Service",-30}{"Time(min)",-20}Cost");
            Hr(false);

            StandardServiceList.ForEach(x =>
            {
                provider.ProvideService(x.Name, x.Time);
                var cost = provider.GetCost(x.Cost);
                Console.WriteLine($"\t\t  {cost:$0.00}");
            });
            provider.ShowResults();
        }

        private static void RunSpecializedService(SpecializedServiceProvider provider)
        {
            Set(Green);
            Console.WriteLine($"\nProviding {provider.Implementor.ImplementorType} specialized services\n");
            Set(Cyan);
            Console.WriteLine($"{"Service", -30}{"Time(min)", -20}Cost");
            Hr(false);

            SpecializedServiceList.ForEach(x =>
            {
                provider.ProvideService(x.Name, x.Time);
                provider.RequestRestock();
                var cost = provider.GetCost(x.Cost);
                Write($"\t\t  {cost:$0.00}");
            });
            provider.ShowResults();
        }
    }
}