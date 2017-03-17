using System.Collections.Generic;
using System.Linq;
using Mediator.Setup;
using static System.ConsoleColor;

namespace Mediator.Core
{
    public class PayrollMediator : Mediator
    {
        private readonly List<Person> _recipients = new List<Person>();

        public int RecipientCount { get; set; } = 1;

        public override void Send(string message, Person person)
        {
            Helper.Write($"{person.Role} {person.Id} sent: {message}\n", Yellow);

            _recipients.Where(x => x.Id != person.Id)
                .ToList()
                .ForEach(x => x.Notify(message));
        }

        public override void Send(Timesheet timesheet)
        {
            _recipients.Where(x => x.Role == Role.Timekeeper)
                .ToList()
                .ForEach(x => x.Notify("New timesheet", timesheet));
        }

        public void AddRecipient(Person person)
        {
            person.Id = RecipientCount;

            _recipients.Add(person);

            RecipientCount++;
        }

        public void RegisterRecipients(List<Person> persons)
        {
            persons.ForEach(AddRecipient);            
        }
    }
}