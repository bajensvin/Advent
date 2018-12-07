using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdventOfCode {
    class Day1 {
        static void Main() {
            Console.WriteLine("Part 1 value: " + Part1() + "");
            Console.WriteLine("Part 2 value: " + Part2() + "");
            Console.ReadKey();
        }
        public static string[] ReadFile() {
            var input = System.IO.File.ReadAllLines(@"./Input/Day_1/input.txt");
            return input;
        }
        public static int Part1() {
            var input = ReadFile();
            return input.Sum(int.Parse);
        }
        public static int Part2() {
            var input = ReadFile().ToList();
            int currentTotalFrequency = 0;
            HashSet<int> totalFrequencyAfterEachLoop = new HashSet<int>();
            bool duplicate = false;
            while (!duplicate) {
                foreach (var item in input) {
                    currentTotalFrequency = currentTotalFrequency + int.Parse(item);
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
