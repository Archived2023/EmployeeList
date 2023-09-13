namespace EmployeeList
{
    public class Robot
    {
        private  string firstname;

        private int salary;

        public int Salary
        {
            get { return salary; }
            set 
            { 
                if(value < 0)
                {
                    salary = 0;
                }
                salary = value; 
            }
        }

        // public int Salary { get; set; }
        public int Salary2;


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

        public void SetFirstName(string value)
        {
            //Validate
            firstname = value;
        }

        public string GetFirstName()
        {
            return firstname;
        }
    }
}