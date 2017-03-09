using System;
using static Mediator.Setup.Helper;

namespace Mediator.Core
{
    public class Timekeeper : Person
    {
        private Payroll Payroll { get; } = new Payroll();

        public Timekeeper(Mediator mediator) : base(mediator)
        {
            Role = Role.Timekeeper;
        }

        public void SubmitPayroll()
        {
            Mediator.Send("Payroll has been submitted", this);
        }

        public void Send(string message)
        {
            Mediator.Send(message, this);
        }

        public override void Notify(string message, params object[] items)
        {
            Console.WriteLine($"Timekeeper received: {message}");

            if (items == null || items.Length <= 0) return;

            foreach (var item in items)
            {
                var time = Convert.ChangeType(item, typeof(Timesheet)) as Timesheet;
                Payroll.Timesheets.Add(time);
            }
        }

        public void PrintPayroll()
        {
            Write("Printing payroll: \n", ConsoleColor.Yellow);

            Payroll.Timesheets.ForEach(x => 
            {
                Write($"\t{x.WorkerName} worked {x.HoursWorked} hours on week ending {x.Date : dd MMMM yyyy} ", ConsoleColor.Green);
            });            
        }

    }
}