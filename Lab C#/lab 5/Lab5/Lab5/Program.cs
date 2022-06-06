using System;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======Task 01==========");
            int[] numbers;
             numbers = new int[5];
             Console.WriteLine("Enter five numbers");
             int max = 0;
             int min = 9999999;
             int maxi = 0, mini = 0;
             for (int i = 0; i < 5; i++)
             {
                 numbers[i] = int.Parse(Console.ReadLine());
                 if (numbers[i] > max)
                 {
                     max = numbers[i];
                     maxi = i;
                 }
                 if (numbers[i] < min)
                 {
                     min = numbers[i];
                     mini = i;
                 }
             }
             Console.WriteLine($"The max number is {max} and it's index equal {maxi}");
             Console.WriteLine($"The max number is {min} and it's index equal {mini}");
            
            
             Console.WriteLine("=======Task 02==========");
             int[,] class1;
             class1 = new int[3, 4];
             int col, row;
             int[] total;
             total = new int[3];
             float[] average ;
             average = new float[4];
             for(row = 0; row < 3; row++)
             {
                 for(col = 0; col < 4; col++)
                 {
                    Console.WriteLine($"Enter the grades for the subject no {col + 1} for student no {row +1}");
                    class1[row,col] = int.Parse(Console.ReadLine());
                     total[row] += class1[row,col]; 
                 }
                 Console.WriteLine($"The total for student no {row + 1} equal {total[row]}");
             }

             for (col = 0; col < 4; col++)
             {
                 for (row = 0; row < 3; row++)
                 {
                     average[col] += class1[row, col];
                 }
                 Console.WriteLine($"The average for subject no {col +1 } equal {average[col] * 0.25}");
             }
             
            Console.WriteLine("=======Task 03==========");
            int[][] class2;
            class2 = new int[3][];
            int[] sum;
            sum = new int[3];
            int no =0 , r,c;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter the number of subject you have:-");
                no = int.Parse(Console.ReadLine());
                class2[i] = new int[no];
            }
            for (r = 0; r < 3; r++)
            {
                for (c = 0; c < class2[r].Length; c++)
                {
                    Console.WriteLine($"Enter the grades for the subject no {c +1} for student no {r +1}");
                    class2[r] [c] = int.Parse(Console.ReadLine());
                    sum[r] += class2[r][c];
                }
                Console.WriteLine($"The total for student no {r + 1} equal {sum[r]}");
            }
        }
    }
}
