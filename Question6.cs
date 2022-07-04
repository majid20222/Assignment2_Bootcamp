using System;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Many Integers you want to check?");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] numArr = new int[N];
            float sum = 0;
            int posCount = 0;
            int negCount = 0;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Enter Element number {i + 1}");
                int number = Convert.ToInt32(Console.ReadLine());
                sum += number;
                int takeAbsolute = Math.Abs(number);

              
                
                if (takeAbsolute == number)
                {
                    posCount++;
                }
                else
                {
                    negCount++;
                }

            }
            /*Console.WriteLine($"Enter Element number {N}");*/
            float average = sum / N;

            Console.WriteLine($"Positive numbers entered are {posCount}");
            Console.WriteLine($"Negative numbers entered are {negCount}");
            Console.WriteLine($"Sum is {sum}");
            Console.WriteLine($"Average of numbers is {average.ToString("0.000")}");


        }
    }
}
