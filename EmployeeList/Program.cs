using EmployeeList.Helpers;
using EmployeeList.UI;
using System.Runtime.InteropServices;

namespace EmployeeList
{
    public class Program
    {

        //Programmets startpunkt
        //Får bara finnas EN!
        static void Main(string[] args)
        {
            IPayRoll payRoll = new PayRoll();
            IUI ui = new ConsoleUI();

            Main main = new Main(ui, payRoll);
            main.Run();



            //MockUI mockUI = new MockUI();
            //mockUI.SetInput = "-10";
            //Util.AskForUInt("", mockUI);

            //Skapa en instans av typen PayRoll
            //payRoll = new PayRoll();

           
        }

      

       
    }
}