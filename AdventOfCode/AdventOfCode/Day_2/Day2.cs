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
        //public static string Part2(string[] input) {



        //    //Look at each string, if char is not present in any other string at the same position remove it
        //    //Get value of how many chars are common

        //    List<char> charList = new List<char>();

        //    foreach (var item in input.ToList()) {
        //        charList.Add(item);
        //    }
        //    foreach (var item in input.ToList()) {
        //        foreach (char c in item) {
        //            if (input.ToList().Contains(c))
        //        }
        //    }



        //    //Iterate over string, add all chars to an item and search for longer and longer substrings?
        //    var list = input.ToList();
        //    var list2 = new List<string>();
        //    foreach (var item in list) {
        //        list2.Add(list.Select(c => c).Where(c => c == "alpiggsvyfecjuqmnxaktdrhkz").First());
        //    }
        //    return "";
        //}
        //public class Word {
        //    public char Chars { get; set; }
        //}
    }
}
