using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode._2019.Day_2
{
    class Day2
    {
        public static int Part1(string[] input)
        {
            List<int> partialValues = new List<int>();
            input = string.Join(",", input).Split(',');
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == "1")
                {
                    input[i + 3] = input[i + 1] + input[i + 2];
                }
                else if (input[i] == "2")
                {

                }
                else if (input[i] == "99")
                {

                }
            }

            return 0;
        }
    }
}
