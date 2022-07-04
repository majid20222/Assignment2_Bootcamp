using System;

namespace Question3
{
    class Program
    {
        static bool isPrime(int x)
        {
            bool v = false;
            int y = x;
            while (y != 2)
            {
                y--;
                if (x % y == 0)
                {
                    v = true;
                }

            }
            return v;
        }
        static int[] delPrime(int[] arr)
        {
            int pCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (isPrime(arr[i]))
                {
                    pCount++;
                }
            }
            int[] newArr = new int[pCount];
            int c = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (isPrime(arr[j]))
                {
                    newArr[c] = arr[j];
                    c++;
                }
            }
            return newArr;
        }

        static void Main(string[] args)
        {
            foreach (int p in delPrime(new int[] {2,33,4,5,6,7,8,9,11,32}))
            {
                Console.WriteLine(p);
            }
        }
    }
}
