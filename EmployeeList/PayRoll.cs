namespace EmployeeList
{
    internal class PayRoll
    {
        private List<Employee> employees;

        public PayRoll()
        {
            employees = new List<Employee>();
        }

        internal void AddEmplyees(string name, int salary)
        {
            employees.Add(new Employee(name, salary));
        }

        internal List<Employee> GetEmployees()
        {
            //ToDo: Fix not good!
            return employees;
        }
    }
}