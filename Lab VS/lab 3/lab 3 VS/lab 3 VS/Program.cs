using System;

namespace lab_3_VS
{
   
    internal class Program
    {
        public static string reverse(string input)
        {
            char[] chars = input.ToCharArray();
            string output ="";
            for (int i = chars.Length -1; i > -1; i--)
            {
                output += chars[i];
            }
            return output;
        }
        static MyEmp fillData(MyEmp emp)
        {
            Console.WriteLine("Enter Employee data:");
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();
            string reName = reverse(name);
            emp.Name = reName;
            Console.WriteLine("Enter the id");
            int id = int.Parse(Console.ReadLine());
            emp.Id = id;
            Console.WriteLine("Enter the salary");
            double sal = double.Parse(Console.ReadLine());
            emp.Salary =sal;
            Console.WriteLine("Enter the position");
            string position =Console.ReadLine();
            emp.Position = position;
            return emp;
        }
        static void Print(MyEmp emp)
        {
            string na = emp.Name;
            int id = emp.Id;
            double sa = emp.Salary;
            string po = emp.Position;
            Console.WriteLine($"The name:{na}.\nThe id:{id}.\nThe salary:{sa}.\nThe Position:{po}.\n");
        }
        static void Main(string[] args)
        {
            int c;
            MyEmp obj = new MyEmp();
            fillData(obj);
            Print(obj);
            c = obj.counter();
            Console.WriteLine($"The number of instance is {c}");
            MyEmp obj1 = new MyEmp();
            fillData(obj1);
            Print(obj1);
            c = obj1.counter();
            Console.WriteLine($"The number of instance is {c}");
            
        }
    }
    class MyEmp
    {
        static int count = 0;
        static string comapanyName;
        public string Name { get; set; }
        int id;
        double salary;
        string position;
        public MyEmp()
        {
            ++count;
        }
        public int Id
        {
            get { return id;}
            set { id = value;}
        }
        public double Salary
        {
            get { return salary;}
            set { salary = value;}
        }
        public string Position
        {
            get { return position;}
            set { position = value;}
        }
        public int counter()
        {
            return count;
        }
        public void SetcompanyName(string s)
        {
            comapanyName = s;
        }
        public string companyName()
        {
            return comapanyName;
        }
    }
}
