using System;

namespace PalindromeDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            // Please read the palindrome definition
            Console.WriteLine(IsPalindrome("ipsum")); // false
            Console.WriteLine(IsPalindrome("malam")); // true
            Console.WriteLine(IsPalindrome("tidur")); // false
            Console.WriteLine(IsPalindrome("kasur rusak")); // true
            Console.WriteLine(IsPalindrome("ibu ratna antar ubi")); // true
        }

        static bool IsPalindrome(string text)
        {
            int pjgText = text.Length;
            for (int i = 0; i < pjgText / 2; i++)
            {
                if (text[i] != text[pjgText - i - 1])
                    return false;
            }
            return true;
        }
    }
}
