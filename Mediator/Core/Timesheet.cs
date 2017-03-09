using System;

namespace Mediator.Core
{
    public class Timesheet
    {
        public double HoursWorked { get; set; }

        public string WorkerName { get; set; }

        public DateTime Date { get; set; }

        public Timesheet(double hoursWorked = 0)
        {
            HoursWorked = hoursWorked;
        }
    }
}