//https://www.codewars.com/kata/5938f5b606c3033f4700015a

using System;
using System.Collections.Generic;
using System.Text;

namespace codewars_solutions.CodeWars._6kyu
{
    public class AlphabetWar
    {
        public static string Solution(string fight)
        {
            Dictionary<char, int> leftTeam = new Dictionary<char, int>();
            leftTeam.Add('w', 4);
            leftTeam.Add('p', 3);
            leftTeam.Add('b', 2);
            leftTeam.Add('s', 1);

            Dictionary<char, int> rightTeam = new Dictionary<char, int>();
            rightTeam.Add('m', 4);
            rightTeam.Add('q', 3);
            rightTeam.Add('d', 2);
            rightTeam.Add('z', 1);

            StringBuilder sb = new StringBuilder(fight);

            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == '*' && i == 0)
                {
                    sb[0] = ' ';
                    sb[1] = ' ';
                }
                else if (sb[i] == '*' && i == sb.Length - 1)
                {
                    sb[sb.Length - 1] = ' ';
                    sb[sb.Length - 2] = ' ';
                }
                else if (sb[i] == '*')
                {
                    sb[i] = ' ';

                    if (sb[i - 1] != '*')
                    {
                        sb[i - 1] = ' ';
                    }

                    if (sb[i + 1] != '*')
                    {
                        sb[i + 1] = ' ';
                    }
                }
            }

            int leftTeamSum = 0;
            int rightTeamSum = 0;

            for (int i = 0; i < sb.Length; i++)
            {

                if (rightTeam.ContainsKey(sb[i]))
                {
                    rightTeamSum += rightTeam[sb[i]];
                }


                if (leftTeam.ContainsKey(sb[i]))
                {
                    leftTeamSum += leftTeam[sb[i]];
                }

            }

            string result = leftTeamSum > rightTeamSum ? "Left side wins!" : "Right side wins!";
            if (leftTeamSum == rightTeamSum) result = "Let's fight again!";

            return result;

        }
    }
}
