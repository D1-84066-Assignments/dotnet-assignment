namespace Question12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            company.Accept();  // Accept company data from the console

            // Adding employees
            company.AddEmployee(new Employee(1, "Doe", 5000));

            company.Print();   // Print company data and employee list
        }
    }
}
