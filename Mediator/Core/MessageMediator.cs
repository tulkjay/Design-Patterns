namespace Mediator.Core
{
    public class MessageMediator : Mediator
    {
        private Manager _manager;
        private Employee _employee;

        public Manager Manager
        {
            set { _manager = value; }
        }

        public Employee Employee
        {
            set { _employee = value; }
        }

        public override void Send(string message, Person recipient)
        {
            if (recipient == _manager)
            {
                _manager.Notify(message);
            }
            else
            {
                _employee.Notify(message);
            }
        }
    }
}