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