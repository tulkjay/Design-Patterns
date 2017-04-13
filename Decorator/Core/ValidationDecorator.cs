namespace Decorator.Core
{
    public class ValidationDecorator : IDecorator
    {
        private readonly EmployeeRegistry _registry = EmployeeRegistry.GetInstance();

        public GetResponse Handle(GetRequest request)
        {
            if (request.IdToGet < 1)
            {
                return new GetResponse
                {
                    Success = false,
                    Message = "Employee Id is required."
                };
            }

            if (!_registry.Employees.ContainsKey(request.IdToGet))
            {
                return new GetResponse
                {
                    Success = false,
                    Message = $"\tEmployee with Id {request.IdToGet} not found.\n"
                };
            }

            return new LogicDecorator().Handle(request);
        }
    }
}