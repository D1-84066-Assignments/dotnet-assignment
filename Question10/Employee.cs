using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question10
{
    abstract class Employee
    {
        public String Designation { get; private set; }

        public Employee(String designation = "Supervisor") { 
              Designation = designation;
        }

        public override string ToString()
        {
            return $"Designation :{Designation}"; 
        }
    }
}
