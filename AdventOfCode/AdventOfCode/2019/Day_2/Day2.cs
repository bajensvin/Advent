namespace AdventOfCode._2019.Day_2
{
    internal static class Day2
    {
        private static int Part1Value { get; set; }
        private static int Part2Value { get; set; }
        private static string[] Input { get; set; }

        public static int Part1()
        {
            Input = AdventOfCode.Input.Read(@"./2019/Day_2/Input/input.txt");
            var ocp = new OpCodeProgram(Input);
            Part1Value = ocp.Calculate(12, 2);
            return Part1Value;
        }

        public static int Part2()
        {
            Input = AdventOfCode.Input.Read(@"./2019/Day_2/Input/input.txt");
            for (var i = 0; i < 100; i++)
            for (var j = 0; j < 100; j++)
            {
                var ocp = new OpCodeProgram(Input);
                var value = ocp.Calculate(i, j);
                if (value == 19690720)
                {
                    Part2Value = 100 * i + j;
                    break;
                }
            }

            return Part2Value;
        }
    }
}