using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Many Elements you want to Insert in the Array?");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] numArr = new int[N];
            for (int i=0;i<N ;i++)
            {
                Console.WriteLine($"Enter Element number {i+1}");
                int number = Convert.ToInt32(Console.ReadLine());
                numArr[i] = number;
            }
            int sum = 0;
            int prod = 1;
            foreach (int item in numArr)
            {
                Console.WriteLine($"Your Element are: "+item);
                sum = sum + item;
                prod = prod * item;
            }
            Console.WriteLine($"Sum of all the numbers is {sum}");
            Console.WriteLine($"Product of all the numbers is {prod}");

        }
    }
}
