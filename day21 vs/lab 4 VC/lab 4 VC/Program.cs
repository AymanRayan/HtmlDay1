using System;

namespace lab_4_VC
{
    public delegate int MathDelegate(int x,int y);
    public class Math
    {
        public static int add(int x ,int y)
        {
            return x + y;
        }
        public static int subtract(int x, int y)
        {
            return x - y;
        }
        public static int multiple(int x, int y)
        {
            return x * y;
        }
        public static int div(int x, int y)
        {
            int res;
            try
            {
              res = x / y;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot divide by zero");
                res = 0;
            }
            catch (InvalidOperationException e)
            {
                Console.Write("Invalid operation.");
                res = 0;
            }
            catch(Exception e)
            {
                Console.Write("Somthing Wrong happen!");
                res = 0;
            }
            return res;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b ,c;
            Console.WriteLine("Enter the first number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the secound number");
            b = int.Parse(Console.ReadLine());
            do { 
                Console.WriteLine("-Enter 1 for Add.\n-Enter 2 for Subtraction.\n-Enter 3 for Multiplay.\n-Enter 4 for Division.");
                c = int.Parse(Console.ReadLine());
            }while (c <= 0 || c > 4);

            int res =0;
            switch (c)
            {
                case 1:
                    MathDelegate add = new MathDelegate(Math.add);
                    res = add(a, b);
                    break;
                case 2:
                    MathDelegate subt = new MathDelegate(Math.subtract);
                    res = subt(a, b);
                    break;
                case 3:
                    MathDelegate mult = new MathDelegate(Math.multiple);
                    res = mult(a, b);
                    break;
                case 4:
                    MathDelegate div = new MathDelegate(Math.div);
                    res = div(a, b);
                    break;
            }
            Console.WriteLine($"The Result is {res}");


        }
    }
}
