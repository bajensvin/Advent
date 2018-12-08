using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode {
    static class Program {
        static void Main() {
            Console.WriteLine("Day 1 Part 1 value: " + Day1.Part1(Input.Read(@"./Input/Day_1/Input.txt")));
            Console.WriteLine("Day 1 Part 2 value: " + Day1.Part2(Input.Read(@"./Input/Day_1/Input.txt")));
            Console.ReadKey(true);
        }
    }
}
