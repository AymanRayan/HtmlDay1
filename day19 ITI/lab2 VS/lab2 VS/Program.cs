using System;

namespace lab2_VS
{
    internal class Program
    {
        public static string reverse(string input)
        {
            char[] chars = input.ToCharArray();
            string output = "";
            for (int i = chars.Length - 1; i > -1; i--)
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
            emp.setName(reName);
            Console.WriteLine("Enter the id");
            int id = int.Parse(Console.ReadLine());
            emp.setId(id);
            Console.WriteLine("Enter the salary");
            double sal = double.Parse(Console.ReadLine());
            emp.setSalary(sal);
            Console.WriteLine("Enter the Position:\n-Enter 1 for developers.\n-Enter 2 for Seniors.\n-Enter 3 for HRs.\n-Enter 4 for Accountants.\n-Enter 5 for Admin.");
            int posValue = int.Parse(Console.ReadLine());
            if (posValue > 0 && posValue < 6)
            {
                emp.setpos(posValue);
                Console.WriteLine("Employ Added successfully");
            }
            else
            {
                Console.WriteLine("Please Enter one of the options");
            }
            return emp;
        }
        static void Print(MyEmp emp)
        {
            string na = emp.getName();
            int id = emp.getId();
            double sa = emp.getsalary();
            string po = emp.getPosition();
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
    public enum posi
    {
        developer = 1,
        senior,
        hr,
        accountant,
        admin
    }
    struct officer
    {
        public string name;
        public int id;
        public double salary;
        public posi position;
    }
    class MyEmp
    {
        private officer emp;
        static int count = 0;
        static string comapanyName;
        public MyEmp()
        {
            ++count;
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
        public void setName(string n)
        {
            emp.name = n;
        }
        public void setId(int i)
        {
            emp.id = i;
        }
        public void setSalary(double s)
        {
            emp.salary = s;
        }
        public void setpos(int v)
        {
            emp.position = (posi)v;
        }
        public string getName()
        {
            return emp.name;
        }
        public int getId()
        {
            return emp.id;
        }
        public double getsalary()
        {
            return emp.salary;
        }
        public string getPosition()
        {
            string po = emp.position.ToString();
            return po;
        }

    }
}
