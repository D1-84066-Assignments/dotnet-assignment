
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question9
{
    internal class Manager:Employee
    {
        private double _bonus;

        public double Bonus
        {
            get { return _bonus; }
            set { _bonus = value; }
        }

        public Manager():base()
        {
            _bonus = 0;
        }
        public Manager(double bonus,String name, bool gender, Date dob, String address, double sal, String designation, DepartmentType department):base(name ,gender,dob,address,sal,designation,department)
        {
            this ._bonus = bonus;
        }

        
    }
}
