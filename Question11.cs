using System;

namespace Question11
{
    class Program
    {
        static int [] Swapping(int [] arr)
        {
            int i = 0;
            int m = arr[i];
            arr[i] =arr[arr.Length-1];
            arr[arr.Length-1] = m;
            return arr;
        }
        static void Main(string[] args)
        {
            int [] swapped=Swapping(new int [] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            foreach (int i in swapped)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
