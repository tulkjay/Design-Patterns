namespace Mediator.Core
{
    public abstract class Person
    {
        protected Core.Mediator Mediator;

        protected Person(Core.Mediator mediator)
        {
            Mediator = mediator;
        }
    }
}