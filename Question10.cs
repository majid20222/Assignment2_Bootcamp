using System;

namespace Question10
{
    class Program
    {
        static int[] SeperateEO(int[] arr)
        {
            int evenCount = 0;
            int oddCount = 0;
            //int merge = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            int[] evenArray = new int[evenCount];
            int[] oddArray = new int[oddCount];
            int e = 0;
            int o = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenArray[e] = arr[i];
                    e++;
                }
                else
                {
                    oddArray[o]= arr[i];
                    o++;
                }
                
            }
            int merge = evenArray.Length;
            Array.Resize(ref evenArray,arr.Length);
            for (int i=0;i<oddArray.Length; i++)
            {
                evenArray[merge+i]= oddArray[i];
            }
            return evenArray;
        }
        static void Main(string[] args)
        {
            int[] n = SeperateEO(new int[] { 5, 2, 3, 7, 8, 9,10,16 });
            foreach (int item in n)
            {
                Console.WriteLine(item);

            }
        }
    }
}
