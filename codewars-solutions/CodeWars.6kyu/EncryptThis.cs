//https://www.codewars.com/kata/5848565e273af816fb000449

using System;
using System.Collections.Generic;
using System.Text;

namespace codewars_solutions.CodeWars._6kyu
{
    public class EncryptThis
    {
        public static string Solution(string input)
        {
            if (input.Length == 0) return string.Empty;

            StringBuilder resultBuilder = new StringBuilder();

            string[] words = input.Split();

            foreach (var word in words)
            {
                StringBuilder sb = new StringBuilder(word);

                if (word.Length > 1)
                {
                    var lastLetter = sb[sb.Length - 1];
                    sb[sb.Length - 1] = sb[1];
                    sb[1] = lastLetter;
                }

                string firstPart = $"{(int)sb[0]}";

                sb.Remove(0, 1);
                sb.Insert(0, firstPart);

                resultBuilder.Append($"{sb.ToString()} ");
            }

            resultBuilder.Remove(resultBuilder.Length - 1, 1);

            return resultBuilder.ToString();
        }
    }
}
