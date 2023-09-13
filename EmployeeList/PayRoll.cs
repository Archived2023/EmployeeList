namespace EmployeeList
{
    internal class PayRoll
    {
        public List<Employee> Employees { get; set; }

        public PayRoll()
        {
            Employees = new List<Employee>();
        }
    }
}