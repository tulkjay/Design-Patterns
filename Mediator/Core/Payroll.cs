using System.Collections.Generic;

namespace Mediator.Core
{
    public class Payroll
    {
        public List<Timesheet> Timesheets { get; set; } = new List<Timesheet>();
    }
}