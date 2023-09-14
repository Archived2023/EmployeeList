using EmployeeList.Helpers;
using System.Runtime.InteropServices;

namespace EmployeeList
{
    public class Program
    {
        private static  PayRoll payRoll = new PayRoll();

        //Programmets startpunkt
        //Får bara finnas EN!
        static void Main(string[] args)
        {
            //Skapa en instans av typen PayRoll
            //payRoll = new PayRoll();

            SeedData();

            do
            {
                ShowMainMeny();
                string input = Console.ReadLine()!;

                switch (input)
                {
                    case MenyHelpers.Add:
                        AddEmployee();
                        break;
                    case MenyHelpers.Print: 
                        PrintEmployees();
                        break;  
                    case MenyHelpers.Quit:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }


            } while (true);
        }

        private static void AddEmployee()
        {
            string name = Util.AskForString("Name");
            uint salary = Util.AskForUInt("Salary");

            payRoll.AddEmployee(name, salary);
        }

        private static void PrintEmployees()
        {
            List<Employee> employees = payRoll.GetEmployees();

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
               // Console.WriteLine("Name: " + employee.Name + "Salary: " + employee.Salary);
            }
        }

        private static void ShowMainMeny()
        {
            Console.WriteLine($"{MenyHelpers.Add}. Add");
            Console.WriteLine($"{MenyHelpers.Print}. Print");
            Console.WriteLine($"{MenyHelpers.Quit}. Quit");
        }

        private static void SeedData()
        {
            payRoll.AddEmployee("Anna", 30000);
            payRoll.AddEmployee("Bengt", 50000);
            payRoll.AddEmployee("Pelle", 60000);
            payRoll.AddEmployee("Sara", 70000);
        }
    }
}