using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList
{
    public class ConsoleUI
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }

        public string GetInput()
        {
            return Console.ReadLine()!;
        }
    }
}
