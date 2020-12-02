using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode._2020.Day_2
{
    public static class Day2
    {
        private static readonly string[] Input = AdventOfCode.Input.Read(@"./2020/Day_2/Input/input.txt");
        public static int Part1()
        {
            var validPasswords = 0;
            foreach (var item in Input)
            {
                var policy = GetPolicy(item);

                var numberOfCharsInString = policy.Password.Count(x => x.ToString() == policy.CharToBePresent);
                var match = numberOfCharsInString >= policy.FirstIndex &&
                            numberOfCharsInString <= policy.SecondIndex;
                if (match)
                {
                    validPasswords++;
                }
            }

            return validPasswords;
        }

        public static int Part2()
        {
            var validPasswords = 0;
            foreach (var item in Input)
            {
                var policy = GetPolicy(item);
                var firstCharInPass = policy.Password[policy.FirstIndex - 1];
                var secondCharInPass = policy.Password[policy.SecondIndex - 1];
                var match =
                    firstCharInPass.ToString() == policy.CharToBePresent &&
                    secondCharInPass.ToString() != policy.CharToBePresent ||
                    firstCharInPass.ToString() != policy.CharToBePresent &&
                    secondCharInPass.ToString() == policy.CharToBePresent;
                if (match)
                {
                    validPasswords++;
                }
            }

            return validPasswords;
        }

        private static PasswordPolicy GetPolicy(string row)
        {
            var replaced = Regex.Replace(row, "\\W", " ");
            var str = replaced.Split(' ');
            return new PasswordPolicy
            {
                FirstIndex = int.Parse(str[0]),
                SecondIndex = int.Parse(str[1]),
                CharToBePresent = str[2],
                Password = str[4]
            };
        }

        private class PasswordPolicy
        {
            public int FirstIndex { get; set; }
            public int SecondIndex { get; set; }
            public string CharToBePresent { get; set; }
            public string Password { get; set; }
        }
    }
}
