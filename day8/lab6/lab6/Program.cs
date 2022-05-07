using System;

namespace lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employee employee = FillData();
            PrintEmployee(employee);
            
        }
        static employee FillData()
        {
            employee TheEmployee = new employee();
            int id;
            string name;
            float salary;
            Console.WriteLine("Enter the Employ Data");
            Console.WriteLine("Enter the Name:-");
            name = Console.ReadLine();
            Console.WriteLine("Enter the Id:-");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Salary:-");
            salary = float.Parse(Console.ReadLine());
            TheEmployee.SetId(id);
            TheEmployee.SetName(name);
            TheEmployee.SetSalary(salary);
            return TheEmployee;
        }
        static void PrintEmployee(employee e)
        {
            Console.WriteLine();
            Console.WriteLine("Employee Data:-");
            Console.WriteLine("------------------");
            Console.WriteLine($"Name is {e.GetName()} ,the Id is {e.GetId()} and the Salary is {e.GetSalary()}");
        }
    }
    class employee
    {
        private int id;
        private string name;
        private float salary;
        public int GetId()
        {
            return id;
        }
        public string GetName()
        {
            return name;
        }
        public float GetSalary()
        {
            return salary;
        }
        public void SetId(int i)
        {
            id = i;
        }
        public void SetName(string x)
        {
            name = x;
        }
        public void SetSalary(float y)
        {
            salary = y;
        }
    }
}
