using System;
using System.Collections;

namespace Substitution
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have some word collection ...
            var censoredWords = new ArrayList();
            censoredWords.Add("imperdiet");
            censoredWords.Add("dolor");
            censoredWords.Add("duo");

            // and a paragraph.
            var paragraph = "Lorem ipsum dolor sit amet, imperdiet vituperata duo in, nonumy.";

            // Censor the words in paragraph by using * symbol.
            // Output example:
            // Lorem ipsum ***** sit amet, ********* vituperata *** in, nonumy.

            //explode paragraph ke array
            //cocokkan satu persatu kata array paragraph dengan kata kunci di censoredWord
            //jika ada yang cocok dengan censoredWord, ganti dengan *
            //jika sudah implode array menjadi satu.

            string[] newParagraph = paragraph.Split(' ');
            string bintang = "";
            for (int i = 0; i < censoredWords.Count; i++)
            {
                for (int a = 0; a < censoredWords[i].Length; a++)
                {
                    bintang += "*";
                }
                Console.WriteLine(bintang);
            }


        }


    }
}
