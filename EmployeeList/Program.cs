using System.Runtime.InteropServices;
using Testing;

namespace EmployeeList
{
    public class Program
    {
        private static  PayRoll payRoll;

        static void Main(string[] args)
        {

            Program p = new Program();
            Program p2 = new Program();
            Program p3 = new Program();
            p.payRoll


             payRoll = new PayRoll();

            Robot robot = new Robot("K", 23);
            Robot robot2 = new Robot("K", 23);
            Robot robot3 = new Robot("K", 23);
            Robot robot4 = new Robot("K", 23);
            Console.WriteLine(Robot.Count);

            Console.WriteLine("Hej");
            
            
         
        }

       
    }
}