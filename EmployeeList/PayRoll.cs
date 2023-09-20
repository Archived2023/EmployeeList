namespace EmployeeList
{
    public class PayRoll : IPayRoll
    {
        private List<Employee> employees;

        public PayRoll()
        {
            employees = new List<Employee>();
        }

        public void AddEmployee(string name, uint salary)
        {
            if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            employees.Add(new Employee(name, salary));
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            //ToDo: Fix not good!
            return employees.ToArray();
        }
    }

    public class SqlPayRoll : IPayRoll
    {
        public void AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void AddEmployee(string name, uint salary)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }
    }
}