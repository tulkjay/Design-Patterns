using System;

namespace Mediator.Core
{
    public class Employee : Person
    {
        public string Name { get; set; }

        public Employee(string name, Mediator mediator) : base(mediator)
        {
            Name = name;
            Role = Role.Employee;
        }

        public void Send(string message)
        {
            Mediator.Send(message, this);
        }

        public void SubmitTime(Timesheet timesheet)
        {
            timesheet.WorkerName = Name;
            timesheet.Date = DateTime.Now;
            Mediator.Send(timesheet);
        }

        public override void Notify(string message, params object[] items)
        {
            Console.WriteLine($"Employee {Id} received: {message}");
        }
    }
}