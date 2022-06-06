using System;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Number;
            
            Console.WriteLine("How many Numbers you want?");
            Number = int.Parse(Console.ReadLine());
            Console.WriteLine("The Numbers");
            int max = 0;
            int min = 999999999;
            for (int i = 1; i <= Number; i++)
            {
                int N =int.Parse(Console.ReadLine());
               if(N > max)
                {
                    max = N;
                }
               if (N < min)
                {
                    min = N;
                }
      
            }
            Console.WriteLine($"The max number is {max}");
            Console.WriteLine($"The min number is {min}");

            Console.WriteLine("============TASK 02=============");
            int size;
            double res;
            do
            {
                Console.WriteLine("Enter the size of the Box");
                size = int.Parse(Console.ReadLine());
                res = size % 2;
            } while (res == 0 || size <= 0);
            int r = 1;
            double c = (size + 1) * 0.5;
            Console.WriteLine($"Num = 1 r = {r} c = {c}");
            for (int j = 2; j <=(size * size); j++)
            { 
                double rem = (j - 1) % size;
                if(rem == 0)
                {
                    r++;
                    if(r > size)
                    {
                        r = 1;  
                    }
                }
                else
                {
                    r--;
                    c--;
                    if(r < 1)
                    {
                        r = size;
                    }
                    if(c < 1)
                    {
                        c = size;
                    }
                }
                Console.WriteLine($"Num = {j} r = {r} c = {c}");
            }
        }
    }
}
