using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            string name;
            bool result;
            Console.WriteLine("Enter Your name:");
            name = Console.ReadLine();
            do
            {
                Console.WriteLine("hello {0} Please Enter your age:", name);
                string str = Console.ReadLine();
                result = int.TryParse(str, out age);
            } while (result == false || age < 0);
            int BirthYear = GetBirthYear(age);
            Console.WriteLine("Well {0} .. I Think you were born in {1}",name,BirthYear);
        }
        static int GetBirthYear(int x)
        {
            int year = 2022 - x;
            return year;
        }
    }
}
