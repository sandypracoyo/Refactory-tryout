using System;

namespace MirrorString
{
    class Program
    {
        static void Main(string[] args)
        {
            Mirror("--vv"); // Output: --vvvv--
        }

        static string Mirror(string text)
        {
            char[] reversedString = text.ToCharArray();
            Array.Reverse(reversedString);
            Console.WriteLine(text + new String(reversedString));
            return "";
        }
    }
}