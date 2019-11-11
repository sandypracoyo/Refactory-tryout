using System;

namespace CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            CountWords("Hello"); // Output: 1
            CountWords("Hello World"); // Output: 2
            CountWords("Lorem ipsum dolor sit amet"); // Output: 5
        }

        static int CountWords(string value)
        {
            // Make this method to be able counting words
            int kata, i;
            kata = 1;
            for (i = 0; i <= value.Length - 1;)
            {
                if (value[i] == ' ')
                {
                    kata++;
                }
                i++;
            }
            Console.WriteLine(kata);
            return 0;
        }
    }
}
