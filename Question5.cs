using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] givenArray = { 2, 2, 5, 3, 7, 5 };

            for (int i = 0; i < givenArray.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (givenArray[i] == givenArray[j])
                    {
                        Console.WriteLine(givenArray[j]);
                    }
                }
            }
        }
    }
}
