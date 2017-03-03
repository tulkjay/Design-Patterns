using System;

namespace Mediator.Core
{
    public class Manager : Person
    {
        public Manager(Core.Mediator mediator) : base(mediator)
        {
        }
        public void Send(string message)
        {
            Mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine($"Manager received: {message}");
        }
    }
}