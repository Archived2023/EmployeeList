namespace EmployeeList
{
    internal class PayRoll
    {
        private List<Employee> employees;

        public PayRoll()
        {
            employees = new List<Employee>();
        }

        internal void AddEmployee(string name, uint salary)
        {
            employees.Add(new Employee(name, salary));
        } 
        
        internal void AddEmployee(Employee employee)
        {
           employees.Add(employee);
        }

        internal List<Employee> GetEmployees()
        {
            //ToDo: Fix not good!
            return employees.ToList();
        }
    }
}