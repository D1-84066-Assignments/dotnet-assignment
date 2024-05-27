namespace Question7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.accept();
            Console.WriteLine(p1.Age()) ;
        }
    }
}
