using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Question12

{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Designation { get; private set; }

        public Employee(int id, string name, double salary, string designation = "Employee")
        {
            Id = id;
            Name = name;
            Salary = salary;
            Designation = designation;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary}, Designation: {Designation}";
        }
    }

}
