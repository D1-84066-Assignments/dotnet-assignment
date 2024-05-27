using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String choice;
            do
            {
                Console.WriteLine("1.Add to Numbers ");
                Console.WriteLine("2.Subtract two Numbers");
                Console.WriteLine("3.Divide two Numbers");
                Console.WriteLine("4.Multiply two Numbers");
                Console.WriteLine("0.EXIT"); 
                Console.WriteLine("Enter Your choice :");
                 choice = Console.ReadLine();
                Console.WriteLine("Enter value of Num1");
              
                switch (choice)
                {
                    case "1":
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter value of Num2");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(a+b);
                        break;
                    case "2":
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter value of Num2");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(c-d);
                        break;
                    case "3":
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter value of Num2");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(e/f);
                        break;
                    case "4":
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter value of Num2");
                        int h = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(g*h);
                        break;
                    default:Console.WriteLine("Enter valid choice");
                        break;
                }

                

            } while (choice != "0");
            
        }
    }
}
