using System;

namespace Mediator.Core
{
    public class Manager : Person
    {
        public Manager(Mediator mediator) : base(mediator)
        {
            Role = Role.Manager;
        }

        public void Send(string message)
        {
            Mediator.Send(message, this);
        }

        public override void Notify(string message, params object[] items)
        {
            Console.WriteLine($"Manager received: {message}");
        }
    }
}