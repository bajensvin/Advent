using AdventOfCode.Day_2;
using System.Collections.Generic;
using System.Linq;


namespace AdventOfCode {
    public class Day2 {
        public static int Part1(string[] input) {
            var numberOfTwos = new HashSet<CharObject>();
            var numberOfThrees = new HashSet<CharObject>();

            foreach (var row in input.ToList()) {
                var two = row.GroupBy(c => c).Where(c => c.Count() == 2).Select(c => new CharObject { Char = c.Key, Count = c.Count() }).FirstOrDefault();
                var three = row.GroupBy(c => c).Where(c => c.Count() == 3).Select(c => new CharObject { Char = c.Key, Count = c.Count() }).FirstOrDefault();
                if (two != null) {
                    numberOfTwos.Add(two);
                }
                if(three != null) {
                    numberOfThrees.Add(three);
                }
            }
            return numberOfTwos.Count() * numberOfThrees.Count();
        }
    }
}
