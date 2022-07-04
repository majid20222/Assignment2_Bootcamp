using System;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String: ");
            string userinput = Console.ReadLine();
            string vowel = "aeiouAEIOU";
            int vCount = 0;
            for (int i = 0; i < userinput.Length; i++)
            {
                for (int j = 0; j < vowel.Length; j++)
                {
                    if (userinput[i] == vowel[j])
                    {
                        vCount++;
                    }
                }
            }

            Console.WriteLine(" ");
            Console.WriteLine("No. of Vowels in ("+userinput+") are "+vCount+".");
            
        }
    }
}
