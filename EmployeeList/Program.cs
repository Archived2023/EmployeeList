using System.Runtime.InteropServices;
using Testing;

namespace EmployeeList
{
    public class Program
    {
        private static  PayRoll payRoll;

        //Programmets startpunkt
        //Får bara finnas EN!
        static void Main(string[] args)
        {
            //Skapa en instans av typen PayRoll
            payRoll = new PayRoll();


            Employee kalle = new Employee("Kalle", 35000);
           

            payRoll.AddEmployee(kalle);

            List<Employee> employees = payRoll.GetEmployees();

            Console.WriteLine(employees[0].Name);

            // employees[0] = new Employee("Anna", 35);
            employees[0].Name = "Anna";

            List<Employee> after = payRoll.GetEmployees();

            Console.WriteLine(after[0].Name);












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
                Console.WriteLine(employee);
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
            payRoll.AddEmployee("Anna", 30000);
            payRoll.AddEmployee("Bengt", 50000);
            payRoll.AddEmployee("Pelle", 60000);
            payRoll.AddEmployee("Sara", 70000);
        }
    }
}