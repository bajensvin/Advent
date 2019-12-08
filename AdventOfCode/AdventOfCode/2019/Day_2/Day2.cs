using System.Linq;

namespace AdventOfCode._2019.Day_2
{
    internal class Day2
    {
        const int add = 1;
        const int multiply = 2;
        const int stop = 99;
        public static int[] Calculate(int[] values, int position, bool add = true)
        {
            var firstIndex = values[position + 1];
            var secondIndex = values[position + 2];
            var outputIndex = values[position + 3];
            var noun = values[firstIndex];
            var verb = values[secondIndex];

            if (add)
            {
                values[outputIndex] = noun + verb;
            }
            else
            {
                values[outputIndex] = noun * verb;
            }

            return values;
        }

        public static int Part1(string[] input)
        {
            input = string.Join(",", input).Split(',');
            var values = input.Select(int.Parse).ToArray();

            values[1] = 12;
            values[2] = 2;

            for (var i = 0; i < values.Length;)
            {
                var opCode = values[i];
                if (opCode == add)
                {
                    Calculate(values, i);
                    i += 4;
                }

                else if (opCode == multiply)
                {
                    Calculate(values, i, false);
                    i += 4;
                }

                if (values[0] == 19690720)
                {
                    var a = 0;
                }

                else if (opCode == stop)
                {
                    break;
                }
            }

            return values[0];
        }

        public static int Part2(string[] input)
        {
            

            return 0;
        }
    }
}