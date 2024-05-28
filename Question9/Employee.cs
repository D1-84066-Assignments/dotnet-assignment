using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Question9
{
    internal class Employee : Person
    {
      private static int genrator = 1000;
       private int id;
       private double salary;
       private string designation;
        private DepartmentType department;

        public Employee():base()
        {
            id = ++genrator;
        }
        public Employee(String name ,bool gender ,Date dob,String address,double sal,String designation,DepartmentType department): base(name, gender, dob, address)
        {
            this.id = genrator++;
            this.salary = sal;
            this.designation = designation;
            this.department = department;

        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public int Id
        {
            get { return id; }
        }

        public DepartmentType Department
        { 
          get { return department; } 
          set {  department = value; } 
        }

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }


        public void accept()
        {
            base.accept();
            Console.WriteLine("Enter Salary :");
            this.salary = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Enter Designation :");
            this.designation = Console.ReadLine();
            Console.WriteLine("Enter for Department");
            Console.WriteLine("press 0: HR");
            Console.WriteLine("press 1: Sales");
            Console.WriteLine("Press 2: Marketing");
            Console.WriteLine("press 3: Finance");
            int choice = Convert.ToInt32( Console.ReadLine());
            department = (DepartmentType)Convert.ToInt32(Console.ReadLine());
        }

        public void print()
        {
            base.print();
            Console.WriteLine("Id :" + id);
            Console.WriteLine("Sal : " + salary);
            Console.WriteLine("Designation :" + designation);
            Console.WriteLine("Department :" + department.ToString());
        }
    }

   
}
