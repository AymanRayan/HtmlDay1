using System;

namespace lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            theApp();
        }
        static void theApp()
        {
            int choose;
            Console.WriteLine("Hello!");
            do
            {
                Console.WriteLine("Enter 1 for Employee.\nEnter 2 for Customer.\nEnter 0 for Exit.");
                choose = int.Parse(Console.ReadLine());
            } while (choose != 1 && choose != 2 && choose != 0);
            if (choose == 1)
            {
                Employee employee = fillEmpData();
                employee.printData();
                theApp();
            }
            else if (choose == 2)
            {
                Customer customer = fillCusData();
                customer.printData();
                theApp();
            }
            else
            {
                Console.WriteLine("Good Bye!");
            }
        }

        static Employee fillEmpData()
        {
            Employee emp;
            string answer;
            do
            {
                Console.WriteLine("Do You Want to fill the data (yes/No)?");
                answer = Console.ReadLine();
            } while (answer != "yes" && answer != "no");
            if (answer == "yes")
            {
                int id;
                string name;
                string position;
                Console.WriteLine("The Employee Data:-");
                Console.WriteLine("The Id:-");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("The Name:-");
                name = Console.ReadLine();
                Console.WriteLine("The Position:-");
                position = Console.ReadLine();
                emp = new Employee(id, name, position);

            }
            else
            {
                emp = new Employee();
            }
            return emp;
        }
        static Customer fillCusData()
        {
            Customer cus;
            string answer;
            do
            {
                Console.WriteLine("Do You Want to fill the data (yes/No)?");
                answer = Console.ReadLine();
            } while (answer != "yes" && answer != "no");
            if (answer == "yes")
            {
                int id;
                string name;
                float accountNum;
                Console.WriteLine("The Customer Data:-");
                Console.WriteLine("The Id:-");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("The Name:-");
                name = Console.ReadLine();
                Console.WriteLine("The Account Number:-");
                accountNum = float.Parse(Console.ReadLine());
                cus = new Customer(id, name, accountNum);
            }
            else
            {
                cus = new Customer();
            }
            return cus;
        }
        //static void print(Person pe)
       // {
           // pe.printData();
        //}
    }
    class Person
    {
        protected int id;
        protected string name;
        public Person()
        {
            id = 0;
            name = "Person1";
        }
        public Person(int x, string n)
        {
            id = x;
            name = n;
        }
        public int GetId()
        {
            return id;
        }
        public string GetName()
        {
            return name;
        }
        public void SetId(int i)
        {
            id = i;
        }
        public void SetName(string s)
        {
            name = s;
        }
        public virtual void printData() {}

    }
    class Employee : Person
    {
        protected string position;
        public Employee()
        {
            position = "Junior";
        }
        public Employee(int i, string n, string p) : base(i, n)
        {
            position = p;
            id = i;
            name = n;
        }
        public string GetPosition()
        {
            return position;
        }
        public void SetPosition(string po)
        {
            position = po;
        }
        public override void printData()
        {
            string name = GetName();
            int id = GetId();
            string position = GetPosition();
            Console.WriteLine();
            Console.WriteLine($"The Employee's Id = {id}");
            Console.WriteLine($"The Employee's Name = {name}");
            Console.WriteLine($"The Employee's position = {position}");
        }

    }
    class Customer : Person
    {
        protected float account_number;
        public Customer()
        {
            account_number = 0;
        }
        public Customer(int i, string n, float a) : base(i, n)
        {
            account_number = a;
            id = i;
            name = n;
        }
        public float GetAccNum()
        {
            return account_number;
        }
        public void SetAccNum(float an)
        {
            account_number = an;
        }
        public override void printData()
        {
            string name = GetName();
            int id = GetId();
            float accountNumber = GetAccNum();
            Console.WriteLine();
            Console.WriteLine($"The Customer's Id = {id}");
            Console.WriteLine($"The Customer's Name = {name}");
            Console.WriteLine($"The Customer's Account Number = {accountNumber}");
        }
    }

}

