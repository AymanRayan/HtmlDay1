using System;

namespace Lab2Task1 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,d,e;
            Console.WriteLine("Enter Five Number");
            Console.WriteLine("a:");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("b:");
            b=int.Parse(Console.ReadLine());
            Console.WriteLine("c:");
            c =int.Parse(Console.ReadLine());
            Console.WriteLine("d:");
            d =int.Parse(Console.ReadLine());
            Console.WriteLine("e:");
            e =int.Parse(Console.ReadLine());
            int max, min;
            if (a > b && a > c && a > d && a > e)
            {
                max = a;
            } else
            {
                if (b > c && b > d && b > e)
                {
                    max=b;
                } else
                {
                    if(c > d && c > e)
                    {
                        max = c;
                    }else
                    {
                        if(d > e)
                        {
                            max = d;
                        }else
                        {
                            max = e;
                        }
                    }
                }
            }
            if (a < b && a < c && a < d && a < e)
            {
                min = a;
            }
            else
            {
                if (b < c && b < d && b < e)
                {
                    min = b;
                }
                else
                {
                    if (c < d && c < e)
                    {
                        min = c;
                    }
                    else
                    {
                        if (d < e)
                        {
                            min = d;
                        }
                        else
                        {
                            min = e;
                        }
                    }
                }
            }
            Console.WriteLine($"The Max number is {max}");
            Console.WriteLine($"The Min number is {min}");

        }
    }
}


