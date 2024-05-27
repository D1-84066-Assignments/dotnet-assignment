using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;

namespace Question5
{
    internal class Program
    {
        static void Main(string[] args)
        {



            /*#region assignment code

            Student[] student = null;
            CreateArray(ref student);
            Acceptinfo(ref student);

            Console.WriteLine("Before reversing");
            Printinfo(ref student);
            ReverseArray(ref student);
            Console.WriteLine("After Reversing ");
            Printinfo(ref student); 
            #endregion*/
            string filepath = @"C:\Data\Something.txt";
            FileStream fs = new FileStream(filepath,
                                            FileMode.OpenOrCreate,
                                            FileAccess.Write);

  
            BinaryFormatter writer = new BinaryFormatter();

            Student student = new Student()
                student.acceptDetails();
            writer.Serialize(fs, student);

            writer = null;
            fs.Close();

        }
        private static void CreateArray(ref  Student [] students)
        {
            Console.WriteLine("Enter Size of an Array To be formed ");
            int size =Convert.ToInt32(Console.ReadLine());
            students = new Student[size];

            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
            }
        }

        private static void Acceptinfo(ref Student[] student ) {

            for (int i = 0; i < student.Length; i++)
            {

                student[i].acceptDetails();
            }
        
        }

        private static void Printinfo(ref Student[] student )
        {
            foreach ( Student s in student )
            {
                s.printDetails();
            }
        }
        
        private static void ReverseArray(ref Student[] students)
        {
            Student[] temp = new Student[students.Length];
             
            int j = students.Length-1;
            for (int i = 0;i < temp.Length;i++)
            {
                temp[i] = students[j--];
            }
            students = temp;
        }

    }
}
