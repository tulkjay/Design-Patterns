namespace Decorator.Core
{
    public class AuthorizationDecorator : IDecorator
    {
        private readonly EmployeeRegistry _registry = EmployeeRegistry.GetInstance();

        public GetResponse Handle(GetRequest request)
        {
            if (_registry.Employees.ContainsKey(request.User.EmployeeId))
            {
                if (_registry.Employees[request.User.EmployeeId].IsManager)
                {
                    return new ValidationDecorator().Handle(request);
                }
            }

            return new GetResponse
            {
                Success = false,
                Message = $"\t{request.User.Name} is not authorized to make this request.\n"
            };
        }
    }
}