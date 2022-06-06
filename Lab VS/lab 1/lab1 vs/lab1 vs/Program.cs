using System;

namespace lab1_vs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day;
            Console.WriteLine("Enter Today");
            day = Console.ReadLine().ToLower();
            days parsing;
            Enum.TryParse<days>(day, out parsing);
            int value;
            days i;
            switch (parsing)
            {
                case days.satuarday:
                    i = days.satuarday;
                    value = (int)i;
                    Console.WriteLine($"Today is {day} Which is the day no {value}");
                    break;
                case days.sunday:
                    i = days.sunday;
                    value = (int)i;
                    Console.WriteLine($"Today is {day} Which is the day no {value}");
                    break;
                case days.monday:
                    i = days.monday;
                    value = (int)i;
                    Console.WriteLine($"Today is {day} Which is the day no {value}");
                    break;
                case days.tuesday:
                    i = days.tuesday;
                    value = (int)i;
                    Console.WriteLine($"Today is {day} Which is the day no {value}");
                    break;
                case days.wednesday:
                    i= days.wednesday;
                    value = (int)i;
                    Console.WriteLine($"Today is {day} Which is the day no {value}");
                    break;
                case days.thursday:
                    i = days.thursday;
                    value = (int)i;
                    Console.WriteLine($"Today is {day} Which is the day no {value}");
                    break;
            }
            //if(Enum.IsDefined(typeof(days), day))
            //{
                
               // Console.WriteLine($"Today is {day} ");
           // }
           // else
           // {
               // Console.WriteLine("This is't a valid day");
           // }
            
            
        }
        enum days
        {
            satuarday =1,
            sunday,
            monday,
            tuesday,
            wednesday,
            thursday,
            friday
        };
    }
}
