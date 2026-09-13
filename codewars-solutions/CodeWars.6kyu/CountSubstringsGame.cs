//https://www.codewars.com/kata/61cefe34d9596f000ea7411b

using System;
using System.Collections.Generic;
using System.Text;

namespace codewars_solutions.CodeWars._6kyu
{
    public class CountSubstringsGame
    {
        public static string Solution(string word)
        {
            List<char> consonants = new List<char>()
        { 'q', 'w', 'r', 't', 'p', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm'};

            List<char> vowels = new List<char>()
        {'a', 'e', 'i', 'o', 'u'};

            word = word.ToLower();

            int scoreDom = 0;
            int scoreSara = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (consonants.Contains(word[i]))
                {
                    scoreDom += word.Length - i;
                }
                else if (vowels.Contains(word[i]))
                {
                    scoreSara += word.Length - i;
                }
                else
                {
                    scoreDom += word.Length - i;
                }
            }

            string result = "Draw";

            if (scoreDom > scoreSara)
            {
                result = $"Dom {scoreDom}";
            }
            else if (scoreDom < scoreSara)
            {
                result = $"Sara {scoreSara}";
            }

            return result;
        }
    }
}
