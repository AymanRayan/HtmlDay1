using System;

namespace Lab2Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double x1 , x2 ,check;
            string message;
            Console.WriteLine("Enter coefficients and constant where (ax^2 + bx + c)");
 
            Console.WriteLine("a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("c:");
            c = int.Parse(Console.ReadLine());
    
            check = (b * b) - (4 * a * c);

            if(check != 0 && check > 0)
            {
                x1 = (-b + Math.Sqrt(check) ) / (2 * a);
                x2 = (-b ) / (2 * a);

                message = $"x1 = {x1} \nx2 = {x2}";
            }else
            {
                if(check == 0)
                {
                    x1 = x2 = -b / (2 * a);
                    message = $"x1 = {x1} \nx2 = {x2}";
                }
                else
                {
                    double real, img;
                    real = -b / (2 * a);
                    img = Math.Sqrt(check * -1);

                    message = $"x1 ={real} + {img}i. \nx2 ={real} - {img}i";

                }   
            }

            Console.WriteLine($"The Variables of the Equ are:-\n{message}");
        }
    }
}
