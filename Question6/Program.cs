namespace Question6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example usage
            Date date1 = new Date();
            date1.acceptDate();
            Date date2 = new Date(15, 5, 2022);

            date1.Printdate();
            date2.Printdate();

            Console.WriteLine("Is date1 valid? " + date1.IsValid());
            Console.WriteLine("Is date2 valid? " + date2.IsValid());

            Console.WriteLine("Difference in years: " + (date1 - date2));
        }
    }
}
