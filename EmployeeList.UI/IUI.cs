namespace EmployeeList.UI
{
    //Interface namnkonvention att namnet startar med I.
    //Klasser som implementerar IUI måste implementera GetInput() samt Print(string message)
    //Interfacet talar om vad vi kan göra inte hur vi gör det. Hur vi gör det hanteras av den/de klasser som implementerar interfacet
    public interface IUI
    {
        string GetInput();
        void Print(string message);
    }
}