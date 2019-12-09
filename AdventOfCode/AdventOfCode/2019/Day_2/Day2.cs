using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Markup;

namespace AdventOfCode._2019.Day_2
{
    internal class Day2
    {
        const int add = 1;
        const int multiply = 2;
        const int stop = 99;
        private static int[] Calculate(int[] values, int position, bool add = true)
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

                else if (opCode == stop)
                {
                    break;
                }
            }

            return values[0];
        }

        public static int Calc2(int noun, int verb)
        {
            return 0;
        }

        public static int Part2(string[] input)
        {
            input = string.Join(",", input).Split(',');
            var values = input.Select(int.Parse).ToArray();


            values[1] = 12;
            values[2] = 2;

            for (var i = 1; i < 99; i++)
            {
                for (var j = 1; j < 99; j++)
                {
                    //sätt värde på 1 och 2 från 0 - 99 tills dess att summan blir 19690720
                    values[1] = i;
                    values[2] = j;
                    Calculate(values, i);
                    if (i + j == 19690720 || i * j == 19690720)
                    {
                        var hej = 100 * (i + j);
                    }
                }
            }

            return 0;
        }
    }
}