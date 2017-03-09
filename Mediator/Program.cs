using System;
using System.Collections.Generic;
using System.Diagnostics;
using Mediator.Core;
using static Mediator.Setup.Helper;

namespace Mediator
{
    public class Program
    {
        public static readonly PayrollMediator Mediator = new PayrollMediator();

        public static void Main(string[] args)
        {
            SetTitle();
                        
            var employee1 = new Employee("Bob", Mediator);
            var employee2 = new Employee("Ethel", Mediator);
            var employee3 = new Employee("Jimmy", Mediator);
            var employee4 = new Employee("Gregory", Mediator);
            var employee5 = new Employee("Phyllis", Mediator);

            var timekeeper = new Timekeeper(Mediator);

            Mediator.RegisterRecipients(new List<Person> {employee1, employee2, employee3, employee4, employee5, timekeeper});

            employee1.Send("Good Morning everyone!");

            Hr();

            employee1.SubmitTime(new Timesheet(24));         
            employee2.SubmitTime(new Timesheet(38));         
            employee3.SubmitTime(new Timesheet(14));         
            employee4.SubmitTime(new Timesheet(35));         
            employee5.SubmitTime(new Timesheet(42));

            Hr();

            timekeeper.PrintPayroll();
            Write("\nDone\n");

            if (Debugger.IsAttached)
                Console.Write("Press Enter to exit... ");
            Console.ReadLine();
        }
    }
}