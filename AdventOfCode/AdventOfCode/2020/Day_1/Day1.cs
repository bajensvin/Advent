using System.Linq;

namespace AdventOfCode._2020.Day_1
{
    internal static class Day1
    {
        private static readonly string[] Input = AdventOfCode.Input.Read(@"./2020/Day_1/Input/input.txt");
        public static int Part1()
        {
            var part1Input = Input.Select(int.Parse).ToList();
            var result = 0;
            for (var i = 0; i < part1Input.Count - 1;)
            {
                var firstNumber = part1Input[i];

                foreach (var secondNumber in part1Input)
                {
                    var sum = firstNumber + secondNumber;
                    if (sum == 2020)
                    {
                        result = firstNumber * secondNumber;
                    }
                }
                i++;
            }

            return result;
        }

        public static int Part2()
        {
            var part2Input = Input.Select(int.Parse).ToList();
            var result = 0;
            for (var i = 0; i < part2Input.Count - 1;)
            {
                var firstNumber = part2Input[i];
                foreach (var secondNumber in part2Input)
                {
                    foreach (var thirdNumber in part2Input)
                    {
                        var sum = firstNumber + secondNumber + thirdNumber;
                        if (sum == 2020)
                        {
                            result = firstNumber * secondNumber * thirdNumber;
                        }
                    }
                }
                i++;
            }

            return result;
        }
    }
}
