namespace EmployeeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot("Kalle");
            Robot robot2 = new Robot("Nisse");

            robot.SetFirstName("Nisse");

            

            //robot.firstname = "";
            //Console.WriteLine(robot.firstname);
        }
    }
}