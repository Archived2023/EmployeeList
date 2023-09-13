using System.Runtime.InteropServices;
using Testing;

namespace EmployeeList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Kalle", 30000);
            emp.Name = "Pelle";
        }
    }
}