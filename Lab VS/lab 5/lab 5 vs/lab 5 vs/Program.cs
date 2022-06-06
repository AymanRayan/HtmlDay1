using System;

namespace lab_5_vs
{
    public delegate void action(string s);
    public class sender{
        public int I;
        public event action  Low;
        public event action High;
        public void ReadDate()
        {
            I = int.Parse(Console.ReadLine());
            if(I < 1)
            {
                if(Low != null)
                {
                    Low("Out of Range, Number is too small");
                }
                else
                {
                    if(I > 100)
                    {
                        if(High != null)
                        {
                            Console.WriteLine("Out of Range, Number is too large");
                            High("Out of Range, Number is too large");
                        }
                    }
                }
            }
        }

        }
    internal class Program
    {
        static void Main(string[] args)
        {
            sender s = new sender();
            
            s.Low += new action(OnLow);
            s.High += new action(OnHeigh);
            s.ReadDate();

            //Console.WriteLine("Hello World!");
        }
        public static void OnLow(string str)
        {
            Console.WriteLine($"{str}");
        }
        public static void OnHeigh(string s)
        {
            Console.WriteLine($"{s}");
        }
    }
}
