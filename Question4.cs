using System;
using System.Linq;
namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] givenArray = { 2, 3, 5, 3, 7, 5 };

            for (int i = 0; i < givenArray.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (givenArray[i] == givenArray[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    Console.WriteLine(givenArray[i]);

                }
            }
        }

          
            


        }

    
    }

