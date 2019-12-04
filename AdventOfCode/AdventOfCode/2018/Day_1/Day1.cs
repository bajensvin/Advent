using System.Collections.Generic;
using System.Linq;


namespace AdventOfCode {
    static class Day1 {
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
