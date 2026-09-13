//https://www.codewars.com/kata/514b92a657cdc65150000006

using System;
using System.Collections.Generic;
using System.Text;

namespace codewars_solutions.CodeWars._6kyu
{
    public class MultiplesOfThreeOrFive
    {
        public static int Solution(int value)
        {
            int result = 0;

            for (int i = 1; i < value; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) result += i;
                else if (i % 3 == 0) result += i;
                else if (i % 5 == 0) result += i;
            }

            return result;
        }
    }
}
