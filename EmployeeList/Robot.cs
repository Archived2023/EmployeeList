namespace EmployeeList
{
    public class Robot
    {
        private  string firstname;

        //public Robot()
        //{

        //}
        public Robot(string name)
        {
            //Validate
           // Validate(name);
            firstname = name;
        }

        public void SetFirstName(string name)
        {
            //Validate
            firstname = name;
        }
    }
}