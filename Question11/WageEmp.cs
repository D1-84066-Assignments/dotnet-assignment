using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question11
{
    internal class WageEmp:Employee
    {
        private int hours;
        private int rate;

        public WageEmp()
        {
            hours = 0;  
            rate = 0;   
        }
        public WageEmp(int hours , int rate)
        {
            this.hours = hours;
            this.rate = rate;
        }
        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public int Rate
        {
            get { return rate; }
            set { rate = value; }   
        }

        public void Accept()
        {
            Console.WriteLine("Enter working hours :");
            hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Rate per Hour :");
            rate = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return base.ToString() + $"\n working hours :{hours} \n Rate/Hour: {Rate}";
        }

        public void print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
