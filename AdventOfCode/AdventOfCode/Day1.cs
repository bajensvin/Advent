using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace AdventOfCode {
    class Day1 {
        static void Main() {
            Console.WriteLine("Part 1 value: " + Part1(ReadInput()) + "");
            Console.WriteLine("Part 2 value: " + Part2(ReadInput()) + "");
            Console.ReadKey();
        }
        public static string[] ReadInput() {
            var input = File.ReadAllLines(@"./Input/Day_1/input.txt");
            return input;
        }
        public static int Part1(string[] input) {
            return input.Sum(int.Parse);
        }
        public static int Part2(string[] input) {
            int currentTotalFrequency = 0;
            var totalFrequencyAfterEachLoop = new HashSet<int>();
            bool duplicate = false;
            while (!duplicate) {
                foreach (var item in input) {
                    currentTotalFrequency = currentTotalFrequency += int.Parse(item);
                    duplicate = totalFrequencyAfterEachLoop.Contains(currentTotalFrequency);
                    totalFrequencyAfterEachLoop.Add(currentTotalFrequency);
                    if (duplicate) {
                        break;
                    }
                }
            }
            return currentTotalFrequency;
        }
    }
}
