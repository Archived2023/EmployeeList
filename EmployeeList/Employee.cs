namespace EmployeeList
{
    internal class Employee
    {
        public string Name { get;  set; }
        public int Salary { get; }

        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}