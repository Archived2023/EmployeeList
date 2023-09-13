using System.Runtime.InteropServices;
using Testing;

namespace EmployeeList
{
    public class Program
    {
        static void Main(string[] args)
        {
            PayRoll payRoll = new PayRoll();
            payRoll.Employees = new List<Employee>();
            
            payRoll.Employees.Add(new Employee("Kalle", 3000));
        }
    }
}