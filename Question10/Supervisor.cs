using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question10
{
    internal class Supervisor:Employee
    {
        private int subordinates;

        public Supervisor() { 
             this.subordinates = 0;
        }
        public Supervisor(int subordinates)
        {
            this.subordinates = subordinates;
        }

        public int Subordinates
        {
            get { return this.subordinates; }
            set { this.subordinates = value; }
        }
        public void Accept()
        {
            Console.WriteLine("Enter number of Assistance for Supervisor:");
            subordinates = Convert.ToInt32(Console.ReadLine());
        }
        public void print()
        {
            Console.WriteLine(this.ToString()); 
        }
        public override string ToString()
        {
            return base.ToString()+$" Subordinates : {subordinates}";
        }
    }
}
