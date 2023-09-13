using System.Runtime.InteropServices;
using Testing;

namespace EmployeeList
{
    public class Program
    {
        private static  PayRoll payRoll;

        static void Main(string[] args)
        {

            payRoll = new PayRoll();
            SeedData();

            do
            {
                ShowMainMeny();
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":

                        break;  
                    case "2":
                        PrintEmployees();
                        break;  
                    case "Q":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }


            } while (true);
        }

        private static void PrintEmployees()
        {
            List<Employee> employees = payRoll.GetEmployees();

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name} Salary: {employee.Salary}");
               // Console.WriteLine("Name: " + employee.Name + "Salary: " + employee.Salary);
            }
        }

        private static void ShowMainMeny()
        {
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Print");
            Console.WriteLine("Q. Quit");
        }

        private static void SeedData()
        {
            payRoll.AddEmplyees("Anna", 30000);
            payRoll.AddEmplyees("Bengt", 50000);
            payRoll.AddEmplyees("Pelle", 60000);
            payRoll.AddEmplyees("Sara", 70000);
        }
    }
}