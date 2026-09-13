//https://www.codewars.com/kata/546f922b54af40e1e90001da

using System;
using System.Collections.Generic;
using System.Text;

namespace codewars_solutions.CodeWars._6kyu
{
    public class ReplaceWithAlphabetPosition
    {
        public static string Solution(string text)
        {
            StringBuilder sb = new StringBuilder();

            text = text.ToLower();

            foreach (char c in text)
            {
                int code = (int)c;

                if (code < 97 || code > 122) continue;
                else
                {
                    int forResult = c - 'a' + 1;

                    sb.Append($"{forResult.ToString()} ");
                }
            }

            if (sb.Length > 1)
            {
                sb.Remove(sb.Length - 1, 1);
            }

            return sb.ToString();
        }
    }
}
