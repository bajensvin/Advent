namespace AdventOfCode._2019.Day_2
{
    public class Day2
    {
        public static int Part1Value { get; set; }
        public static int Part2Value { get; set; }
        public static string[] Input { get; set; }

        public static int Part1()
        {
            Input = AdventOfCode.Input.Read(@"./2019/Day_2/Input/input.txt");
            var occ = new OpCodeCalculator(Input);
            Part1Value = occ.Calculate(12, 2);
            return Part1Value;
        }

        public static int Part2()
        {
            Input = AdventOfCode.Input.Read(@"./2019/Day_2/Input/input.txt");
            for (var i = 0; i < 100; i++)
            for (var j = 0; j < 100; j++)
            {
                var occ = new OpCodeCalculator(Input);
                var value = occ.Calculate(i, j);
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