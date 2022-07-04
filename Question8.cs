using System;

namespace Question8
{
    class Program
    {
        static double [] SumofArray(double [] arr)
        {
            double[] sumArray = new double[arr.Length];
            double add = 0;
            for (int i= 0;i<arr.Length;i++)
            {
                add += arr[i];
                sumArray[i] =add;
            }
            return sumArray;
        }

        static void Main(string[] args)
        {
            double [] n = SumofArray(new double [] {5.8,2.6,9.1,3.4,7.0 });
            foreach (float item in n)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine("Hello World!");
        }
    }
}
