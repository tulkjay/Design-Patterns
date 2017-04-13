using System.Collections.Generic;

namespace Decorator.Core
{
    public class EmployeeRegistry
    {
        private static EmployeeRegistry _registry;
        public List<int> ManagerIds { get; set; }
        public Dictionary<int, Employee> Employees { get; set; }

        private EmployeeRegistry()
        {
            Employees = new Dictionary<int, Employee>
            {
                [15363] = new Employee { EmployeeId = 15363, Name = "Gertrude Higgenbotham", IsManager = true },
                [12365] = new Employee { EmployeeId = 12365, Name = "Fernando Frankling" },
                [98065] = new Employee { EmployeeId = 98065, Name = "Bertram Tennabaum" },
                [01563] = new Employee { EmployeeId = 01563, Name = "Edgar Hamm", IsManager = true },
                [80502] = new Employee { EmployeeId = 80502, Name = "Tippy Bingus" },
                [45613] = new Employee { EmployeeId = 45613, Name = "Ronald McArthur", IsManager = true },
                [01569] = new Employee { EmployeeId = 01569, Name = "Minkus Yearman" },
            };
        }

        public static EmployeeRegistry GetInstance() => _registry ?? (_registry = new EmployeeRegistry());
    }
}