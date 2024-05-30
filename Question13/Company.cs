namespace Question13
{
    public class Company
    {
        private string name;
        private string address;
        private LinkedList<Employee> empList;
        private double salaryExpense;

        public Company()
        {
            empList = new LinkedList<Employee>();
            salaryExpense = 0.0;
        }

        public Company(string name, string address) : this()
        {
            this.name = name;
            this.address = address;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public LinkedList<Employee> EmpList
        {
            get { return empList; }
            set { empList = value; }
        }

        public double SalaryExpense
        {
            get { return salaryExpense; }
            set { salaryExpense = value; }
        }

        public void Accept()
        {
            Console.Write("Enter company name: ");
            Name = Console.ReadLine();
            Console.Write("Enter company address: ");
            Address = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
            PrintEmployees();
        }

        public void CalculateSalaryExpense()
        {
            salaryExpense = 0;
            foreach (var emp in empList)
            {
                salaryExpense += emp.Salary;
            }
        }

        public void AddEmployee(Employee e)
        {
            empList.AddLast(e);
            CalculateSalaryExpense();
        }

        public bool RemoveEmployee(int id)
        {
            var node = FindEmployee(id);
            if (node != null)
            {
                empList.Remove(node);
                CalculateSalaryExpense();
                return true;
            }
            return false;
        }

        public LinkedListNode<Employee> FindEmployee(int id)
        {
            var current = empList.First;
            while (current != null)
            {
                if (current.Value.Id == id)
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        public override string ToString()
        {
            return $"Company Name: {Name}, Address: {Address}, Salary Expense: {SalaryExpense}";
        }

        public void PrintEmployees()
        {
            Console.WriteLine("Employees:");
            foreach (var emp in empList)
            {
                Console.WriteLine(emp.ToString());
            }
        }


    }
 }
    

