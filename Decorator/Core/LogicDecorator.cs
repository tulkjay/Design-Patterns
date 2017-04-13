using System;
using Decorator.Setup;

namespace Decorator.Core
{
    public class LogicDecorator : IDecorator
    {
        private readonly EmployeeRegistry _registry = EmployeeRegistry.GetInstance();

        public GetResponse Handle(GetRequest request)
        {
            var employee = _registry.Employees[request.IdToGet];

            Helper.Write($"\tReturning employee {employee.Name}.\n", ConsoleColor.Green);

            return new GetResponse
            {
                Success = true,
                Employee = employee
            };
        }
    }
}