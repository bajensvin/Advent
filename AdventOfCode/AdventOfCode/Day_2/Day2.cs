using AdventOfCode.Day_2;
using System;
using System.Collections.Generic;
using System.Linq;


namespace AdventOfCode {
    public class Day2 {
        public static int Part1(string[] input) {
            var numberOfTwos = new HashSet<CharObject>();
            var numberOfThrees = new HashSet<CharObject>();

            foreach (var row in input.ToList()) {
                var twos = row.GroupBy(c => c).Where(c => c.Count() == 2).Select(c => new CharObject { Char = c.Key, Count = c.Count() }).FirstOrDefault();
                var threes = row.GroupBy(c => c).Where(c => c.Count() == 3).Select(c => new CharObject { Char = c.Key, Count = c.Count() }).FirstOrDefault();
                if (twos != null) {
                    numberOfTwos.Add(twos);
                }
                if (threes != null) {
                    numberOfThrees.Add(threes);
                }
            }
            return numberOfTwos.Count() * numberOfThrees.Count();
        }
        public static string Part2(string[] input) {
            return "";
        }
    }
}
