using System;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = {2,3,4,55,7,8,11,116};
            int large = 0;
            int SecLargest = 0;
            for (int i=0;i<numArr.Length ;i++)
            {
                if (numArr[i]>large)
                {
                    SecLargest = large;
                    large = numArr[i];
                }

            }
          
            Console.WriteLine("  ");

            Console.WriteLine($"Largest Number in an Array is {large}");
            Console.WriteLine("  ");
            Console.WriteLine($"2nd Largest Number in an Array is {SecLargest}");
        }
    }
}
