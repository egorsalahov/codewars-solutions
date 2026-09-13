//https://www.codewars.com/kata/5287e858c6b5a9678200083c

using System;
using System.Collections.Generic;
using System.Text;

namespace codewars_solutions.CodeWars._6kyu
{
    public class NarcissisticNumber
    {
        public static bool Solution(int value)
        {
            List<int> digits = new List<int>();
            int copyValue = value;

            while (value > 0)
            {
                int digit = value % 10;

                digits.Add(digit);

                value = value / 10;
            }

            int sum = 0;

            foreach (var digit in digits)
            {
                sum += (int)Math.Pow(digit, digits.Count);
            }

            return sum == copyValue ? true : false;
        }
    }
}
