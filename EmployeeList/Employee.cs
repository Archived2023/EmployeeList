namespace EmployeeList
{
    internal class Employee : Object
    {
        public string Name { get;  set; } 
        public uint Salary { get; }

        public Employee(string name, uint salary)
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