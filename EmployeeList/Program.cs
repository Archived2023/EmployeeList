using System.Runtime.InteropServices;
using Testing;

namespace EmployeeList
{
    public class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot("Kalle");
            Robot robot2 = new Robot("Nisse");

            Class1 c = new Class1();

            robot.SetFirstName("Nisse");

            

            //robot.firstname = "";
            //Console.WriteLine(robot.firstname);
        }
    }
}