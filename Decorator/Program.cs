using System;
using System.Diagnostics;
using Decorator.Core;
using static Decorator.Setup.Helper;

namespace Decorator
{
    public class Program
    {
        private static readonly EmployeeRegistry Registry = EmployeeRegistry.GetInstance();
        private static Employee _user;

        public static void Main()
        {
            SetTitle();

            _user = Registry.Employees[80502];

            Write($"\tYou have logged in as {_user.Name}.\n", ConsoleColor.Blue);

            Write("\tAttempting to get employee...", ConsoleColor.Yellow);

            var request = new GetRequest
            {
                User = _user,
                IdToGet = 1
            };

            MakeRequest(request);

            Write("\tUh oh, better opt out of authorization for now...\n", ConsoleColor.Yellow);

            MakeRequest(request, false);

            Write("\tAlright, using a valid employee id...\n", ConsoleColor.Yellow);

            request.IdToGet = 98065;

            MakeRequest(request, false);

            Write("\n\tDone\n");

            if (Debugger.IsAttached)
            {
                Console.Write("Press Enter to exit... ");
                Console.ReadLine();
            }
        }

        private static void MakeRequest(GetRequest request, bool withAuthorization = true)
        {
            Hr();
            Write("\tMaking request...\n", ConsoleColor.Yellow);
            var response = withAuthorization
                ? new AuthorizationDecorator().Handle(request)
                : new ValidationDecorator().Handle(request);

            if (response.Success)
            {
                Hr();
                Write("\tResponse received: \n", ConsoleColor.Yellow);

                Write($"\tEmployee {request.IdToGet}\n" +
                      $"\tId: {response.Employee.EmployeeId}\n" +
                      $"\tName: {response.Employee.Name}", ConsoleColor.Green);
            }
            else
            {
                Write(response.Message, ConsoleColor.Red);
            }
        }
    }
}