namespace EmployeeList.Helpers
{
    public static class Util
    {
        public static string AskForString(string prompt, IUI ui) 
        {

            bool success = false;
            string answer;

            do
            {
                ui.Print($"{prompt}: ");
                answer = ui.GetInput();

                if (string.IsNullOrWhiteSpace(answer))
                {
                    ui.Print($"You must enter a valid {prompt}");
                }
                else
                {
                    success = true;
                }

            } while (!success);

            return answer;
        }

        public static uint AskForUInt(string prompt, IUI ui)
        {
            do
            {
                string input = AskForString(prompt,ui);

                if(uint.TryParse(input, out uint result))
                {
                    return result;
                }

            } while (true);
        }
    }
}