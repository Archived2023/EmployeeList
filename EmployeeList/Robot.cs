namespace EmployeeList
{
    public class Robot
    {
        private  string firstname;

        private int salary;

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }


        //public Robot()
        //{

        //}
        public Robot(string name, int salary)
        {
            //Validate
           // Validate(name);
            firstname = name;
            Salary = salary;
        }

        public void SetFirstName(string name)
        {
            //Validate
            firstname = name;
        }

        public string GetFirstName()
        {
            return firstname;
        }
    }
}