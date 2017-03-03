using System;

namespace Mediator.Core
{
    public class Employee : Person
    {
        public Employee(Core.Mediator mediator) : base(mediator)
        {
        }
        public void Send(string message)
        {
            Mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine($"Employee received: {message}");
        }
    }
}