namespace Mediator.Core
{
    public abstract class Mediator
    {
        public abstract void Send(string message, Person employee);
    }
}