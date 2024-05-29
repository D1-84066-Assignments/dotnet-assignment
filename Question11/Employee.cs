using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Question11
{
    internal class Employee
    {
        public String Designation {  get; private set; }

        public Employee(String designation = "supervisor") 
        { 
           Designation = designation;   
        }

        public override string ToString()
        {
            return $"Designation : {Designation}";
        }
    }
}
