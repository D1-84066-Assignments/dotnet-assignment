namespace question4
{


    struct Student
    {
         String name;
         bool gender;
         int age;
         int std;
         char div;
         double marks;

        public Student()
        {
            name = "new Student";
            gender= false;
            age = 0;    
            std = 0;
            div = 'z';
            marks = 0;

        }

        public Student(String name , bool gender ,int age , int std , char div , double marks)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;

        }


        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int Std
        {
            get { return std; }
            set { std = value; }
        }

        public char Div
        {
            get { return div; }
            set { div = value; }
        }

        public double Marks
        { 
           get { return marks; }
           set { marks = value; }
        }


        public void acceptDetails()
        {
            Console.WriteLine("Enter Your Name =");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter Your gender = (1=M /0=F) ");
            this.gender = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter your age =");
            this.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your std=");
            this.std= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your div=");
            this.div = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter your marks =");
            this.marks = Convert.ToDouble(Console.ReadLine());
        }

        public void printDetails()
        {
            Console.WriteLine("Name :");
            Console.WriteLine(this.name);
            Console.WriteLine("Gender :");
            if (this.gender == true)
            {
                Console.WriteLine("Male");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.WriteLine("Age :");
            Console.WriteLine(this.age);
            Console.WriteLine("Std :");
            Console.WriteLine(this.age);
            Console.WriteLine("Div :");
            Console.WriteLine(this.div);
            Console.WriteLine("Marks :");
            Console.WriteLine(this.marks);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
            Student s = new Student();
            /*s.name= "Deep"    can not access member of Struct in DOTNET are bydefault private */ 
            s.acceptDetails();
            s.printDetails();
        }
    }
}
