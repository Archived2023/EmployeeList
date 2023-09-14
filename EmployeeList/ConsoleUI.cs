using EmployeeList.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList
{
    public class ConsoleUI : IUI
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
    
    public class MockUI : IUI
    {
        public string SetInput { private get; set; } = "1";
        public void Print(string message){}
        public string GetInput()
        {
            return SetInput;
        }
    }
}
