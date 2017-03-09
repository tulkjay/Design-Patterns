using System;

namespace Mediator.Core
{
    public abstract class Person
    {
        protected Mediator Mediator;

        public int Id { get; set; }

        public Role Role { get; set; }

        protected Person(Mediator mediator)
        {
            Mediator = mediator;
        }

        public abstract void Notify(string message, params object[] items);        
    }
}