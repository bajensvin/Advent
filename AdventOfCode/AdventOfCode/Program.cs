using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode {
    static class Program {
        static void Main() {
            Console.WriteLine("Day 1 Part 1 value: " + Day1.Part1(Input.Read(@"./Day_1/Input/Input.txt")));
            Console.WriteLine("Day 1 Part 2 value: " + Day1.Part2(Input.Read(@"./Day_1/Input/Input.txt")));
            Console.WriteLine("Day 2 Part 1 value: " + Day2.Part1(Input.Read(@"./Day_2/Input/input.txt")));
            Console.ReadKey(true);
        }
    }
}
