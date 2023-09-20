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

           // var emp = new Employee(null, 34);

            try
            {
                 main.Run();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            } 
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                main.Run();
            }

            //var res = int.Parse(Console.ReadLine());

            //MockUI mockUI = new MockUI();
            //mockUI.SetInput = "-10";
            //Util.AskForUInt("", mockUI);

            //Skapa en instans av typen PayRoll
            //payRoll = new PayRoll();

           
        }

      

       
    }
}