using System;
using System.Diagnostics;
using Mediator.Core;

namespace Mediator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var mediator = new MessageMediator();
            var employee = new Employee(mediator);
            var manager = new Manager(mediator);

            mediator.Manager = manager;
            mediator.Employee = employee;

            manager.Send("Testing.");
            employee.Send("Testing again.");

            Console.WriteLine("\nDone\n");

            if (Debugger.IsAttached)
                Console.Write("Press Enter to exit... ");
                Console.ReadLine();
        }
    }
}
