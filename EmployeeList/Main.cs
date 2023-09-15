using EmployeeList.Helpers;
using EmployeeList.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList
{
    public class Main
    {
        private readonly IUI ui;
        private readonly IPayRoll payRoll;

        public Main(IUI ui, IPayRoll payRoll)
        {
            this.ui = ui;
            this.payRoll = payRoll;
        }

        public void Run()
        {
            SeedData();

            do
            {
                ShowMainMeny();
                string input = ui.GetInput().ToUpper();

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

        private  void AddEmployee()
        {
            string name = Util.AskForString("Name", ui);
            uint salary = Util.AskForUInt("Salary", ui);

            payRoll.AddEmployee(name, salary);
        }

        private  void PrintEmployees()
        {
            IEnumerable<Employee> employees = payRoll.GetEmployees();

            foreach (Employee employee in employees)
            {
                ui.Print(employee.ToString());
                // Console.WriteLine("Name: " + employee.Name + "Salary: " + employee.Salary);
            }
        }

        private  void ShowMainMeny()
        {
            ui.Print($"{MenyHelpers.Add}. Add");
            ui.Print($"{MenyHelpers.Print}. Print");
            ui.Print($"{MenyHelpers.Quit}. Quit");
        }

        private  void SeedData()
        {
            payRoll.AddEmployee("Anna", 30000);
            payRoll.AddEmployee("Bengt", 50000);
            payRoll.AddEmployee("Pelle", 60000);
            payRoll.AddEmployee("Sara", 70000);
        }
    }
}
