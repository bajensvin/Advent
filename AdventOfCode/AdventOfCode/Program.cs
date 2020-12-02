using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode._2019.Day_1;

namespace AdventOfCode {
    static class Program {
        static void Main() {
            Console.WriteLine("2018 Day 1 Part 1 value: " + Day1.Part1(Input.Read(@"./2018/Day_1/Input/input.txt")));
            Console.WriteLine("2018 Day 1 Part 2 value: " + Day1.Part2(Input.Read(@"./2018/Day_1/Input/input.txt")));
            Console.WriteLine("2018 Day 2 Part 1 value: " + Day2.Part1(Input.Read(@"./2018/Day_2/Input/input.txt")));
            Console.WriteLine("2018 Day 2 Part 2 value: " + Day2.Part2(Input.Read(@"./2018/Day_2/Input/input.txt")));
            Console.WriteLine("2018 Day 3 Part 1 value: " + Day3.Part1(Input.Read(@"./2018/Day_3/Input/input.txt")));
            Console.WriteLine($"2019 Day 1 Part 1 value: {_2019.Day_1.Day1.Part1(Input.Read(@"./2019/Day_1/Input/input.txt"))}");
            Console.WriteLine($"2019 Day 1 Part 2 value: {_2019.Day_1.Day1.Part2(Input.Read(@"./2019/Day_1/Input/input.txt"))}");
            Console.WriteLine($"2019 Day 2 Part 1 value: {_2019.Day_2.Day2.Part1()}");
            Console.WriteLine($"2019 Day 2 Part 2 value: {_2019.Day_2.Day2.Part2()}");
            Console.WriteLine($"2020 Day 1 Part 1 value: {_2020.Day_1.Day1.Part1()}");
            Console.WriteLine($"2020 Day 1 Part 2 value: {_2020.Day_1.Day1.Part2()}");
            Console.WriteLine($"2020 Day 2 Part 1 value: {_2020.Day_2.Day2.Part1()}");
            Console.WriteLine($"2020 Day 2 Part 2 value: {_2020.Day_2.Day2.Part2()}");
            Console.ReadKey(true);
        }
    }
}
