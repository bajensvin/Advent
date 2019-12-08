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

            input = string.Join(",", input).Split(',');
            var values = input.Select(int.Parse).ToArray();

            values[1] = 12;
            values[2] = 2;


            //var values = new int[] { 1, 9, 10, 3, 2, 3, 11, 0, 99, 30, 40, 50 };
            for (int i = 0; i < values.Length;)
            {
                var opCode = values[i];
                if (opCode == 1)
                {
                   
                    var firstIndex = values[i + 1];
                    var secondIndex = values[i + 2];
                    var outputIndex = values[i + 3];
                    var firstValue = values[firstIndex];
                    var secondValue = values[secondIndex];
                    var outputValue = values[outputIndex];
                    values[outputIndex] = firstValue + secondValue;
                    i += 4;
                }

                else if (opCode == 2)
                {
                    var firstIndex = values[i + 1];
                    var secondIndex = values[i + 2];
                    var outputIndex = values[i + 3];
                    var firstValue = values[firstIndex];
                    var secondValue = values[secondIndex];
                    var outputValue = values[outputIndex];
                    values[outputIndex] = firstValue * secondValue;
                    i += 4;
                }

                else if (opCode == 99)
                {
                    return values[0];
                }
            }

            return 0;
        }
    }
}
