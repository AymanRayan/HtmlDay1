using System;

namespace Lab4
{
    internal class Program
    {
        public static void Swap(ref int x,ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        public static int MyPower(int n , int m)
        {
            int result;
            if(m == 0)
            {
                result = 1;
            } else if (m % 2 == 0)
            {
                result = MyPower(n, m / 2) * MyPower(n, m / 2);
            }else
            {
                result = n * MyPower(n, m / 2) * MyPower(n, m / 2);
            }
            return result;

        }
        public static long Fact(long z)
        {
            long result = 1;
            if(z > 1)
            {
                result = z * Fact(z - 1);
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("========Task 1========");
            int a, b;
            Console.WriteLine("Enter Two int for Swaping");
            do
            {
                Console.WriteLine("Enter First Number");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Secound Number");
                b = int.Parse(Console.ReadLine());
            } while (a <= 0 || b <= 0);
            Console.WriteLine("Before Swaping");
            Console.WriteLine($"A = {a}");
            Console.WriteLine($"B = {b}");
            Console.WriteLine("After Swaping");
            Swap(ref a,ref b);
            Console.WriteLine($"A = {a}");
            Console.WriteLine($"B = {b}");
            Console.WriteLine("========Task 2========");
            int m, n;
            Console.WriteLine("Enter Two int for power");
            do
            {
                Console.WriteLine("Enter Base Number");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Power Number");
                m = int.Parse(Console.ReadLine());
            } while (m <= 0 || n <= 0);
            int value = MyPower(n, m);
            Console.WriteLine($"${n} Power {m} = {value}");
            Console.WriteLine("========Task 3========");
            int l;
            do
            {
                Console.WriteLine("Enter The Number");
                l = int.Parse(Console.ReadLine());
                
            } while (l <= 0 || n <= 0);
            long val = Fact(l);
            Console.WriteLine($"The Factorial of {l} = {val}");
        }
    }
}
