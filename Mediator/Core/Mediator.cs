namespace Mediator.Core
{
    public abstract class Mediator
    {
        public abstract void Send(string message, Person person);

        public abstract void Send(Timesheet timesheet);
    }
}