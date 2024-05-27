using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    internal class Person
    {
        String name;
        bool gender;
        Date dob;
        String address;

        public Person()
        {
            dob = new Date();   
        }

        public Person(String name , bool gender ,Date dob , String address)
        {
            this.name = name;
            this.gender = gender;
            this.dob = dob;
            this.address = address;
        }
        public String Name
        {
            get {return name;} 
            set { name = value;}
        }

        public bool Gender
        { 
            get { return gender;} 
            set {  gender = value;} 
        }
        public String Address
        {
            get { return address;}
            set { address = value;}
        }
        public Date  DOB
        {
            get { return dob;}
            set { dob = value;}
        }

         public int Age() {
            return DateTime.Now .Year - dob.Year;
        }

        public void accept()
        {
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            Console.WriteLine("for setting gender press 'm' for male or 'f' for female");
            String ip = Console.ReadLine();
            if(ip == "m") { gender = true; } else { gender = false; }
            dob.acceptDate();
            Console.WriteLine("Enter Your Address :");
            address = Console.ReadLine();
        }

        public void print()
        {
            Console.WriteLine("name :");
            Console.WriteLine(name);
            Console.WriteLine("Gender:");
            if(gender)
            {
                Console.WriteLine("Male");
            }
            else { 
                Console.WriteLine("Female");
            }
            dob.Printdate();
            Console.WriteLine("Address:");
            Console.WriteLine(address);

            
        }
        public override string ToString()
        {
            return name +" "+ gender+" "+dob+" "+address;
        }
    }
}
