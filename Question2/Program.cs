using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First number");
            String int1 =Console.ReadLine();
            int a = Convert.ToInt32(int1);
            Console.WriteLine("Enter Second number");
            String int2 = Console.ReadLine();
            int b = Convert.ToInt32(int2);

            Console.WriteLine("Select operation to perform (* , + , / ,- )");

            String operand = Console.ReadLine();

            switch (operand)
            {
                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "/":
                    Console.WriteLine(a / b);
                    break;
                case "%":
                    Console.WriteLine(a % b);
                    break;  
                case "-":
                    Console.WriteLine(a % b);
                        break;
                case "+":
                     Console.WriteLine(a + b);
                    break;
                default:
                    Console.WriteLine("Enter valid choice");
                    break;
            }
            Console.WriteLine("Press any key to Exit...");
            Console.ReadLine();
        }
    }
}
