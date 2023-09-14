namespace EmployeeList
{
    internal class Employee : Object
    {
        public string Name { get;  set; }
        public int Salary { get; }

        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Name: {Name} Salary: {Salary}";
        }


    }
}