using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question9
{
    public class Date
    {
        private int day;
        private int month;
        private int year;


        public Date()
        {
            day = 1;
            month = 1;
            year = 2001;
        }
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }


        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }

        }

        public void acceptDate()
        {
            Console.WriteLine("Enter day :");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month :");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Year :");
            year = Convert.ToInt32(Console.ReadLine());
        }

        public void Printdate()
        {
            Console.WriteLine(day + "/" + month + "/" + year);
        }

        public bool IsValid()
        {
            if (day <= 31 && day > 0)
            {
                return true;
            }
            else if (month <= 12 && month > 0)
            {
                return true;
            }
            else if (year <= 3000 && year >= 2000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return day + "/" + month + "/" + year;
        }

        static int Yeardiff(Date d1, Date d2)
        {
            return Math.Abs(d1.Year - d2.Year);
        }

        public static int operator -(Date d1, Date d2)
        {
            return Math.Abs(d1.Year - d2.Year);
        }
    }
}

