//https://www.codewars.com/kata/587731fda577b3d1b0001196

using System;
using System.Collections.Generic;
using System.Text;

namespace codewars_solutions.CodeWars._6kyu
{
    public class PascalCase
    {
        public static string Solution(string str)
        {
            string[] words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            StringBuilder resultBuilder = new StringBuilder();

            foreach (var word in words)
            {
                StringBuilder sb = new StringBuilder(word);

                char firstLetter = sb[0];
                sb.Remove(0, 1);
                sb.Insert(0, char.ToUpper(firstLetter));

                resultBuilder.Append(sb.ToString());
            }

            return resultBuilder.ToString();
        }
    }
}
