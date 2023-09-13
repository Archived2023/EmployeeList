using System.Runtime.InteropServices;
using Testing;

namespace EmployeeList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot("Kalle", 2);
            Robot robot2 = new Robot("Nisse",5);

            Class1 c = new Class1();

            robot.SetFirstName("Nisse");
            robot.Salary = 10;

            

            //robot.firstname = "";
            Console.WriteLine(robot.GetFirstName());
        }
    }
}