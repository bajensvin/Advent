using AdventOfCode.Day_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public class WordItem {
            public int DifferenceCount;
            public string Word;
            public string OtherWord;
            public char[] CharsThatDiffer;
        }
        public static string Part2(string[] input) {
            //Needs a lot of cleanup..
            var listOfStrings = input.ToList();
            var listOfStrs = new List<WordItem>();
            var listOfOtherStrs = new List<WordItem>();
            int difference = 0;
            foreach (var str in listOfStrings) {
                foreach (var otherStr in listOfStrings) {
                    if (str == otherStr) {
                        continue;
                    }
                    for (int i = 0; i < str.Length; i++) {
                        if (str[i] != otherStr[i]) {
                            difference++;
                        }
                    }
                    WordItem wi = new WordItem {
                        DifferenceCount = difference,
                        Word = str,
                        OtherWord = otherStr
                    };
                    listOfStrs.Add(wi);
                    difference = 0;
                }
                
            }
            List<WordItem> sortedList = listOfStrs.OrderBy(s => s.DifferenceCount).ToList();
            WordItem correctWord = sortedList.Where(s => s.DifferenceCount == 1).First();
            return correctWord.Word + " " + correctWord.OtherWord;
        }
        public class Word {
            public char[] Chars { get; set; }
            //public string FullString { get; set; }
            public int NumberOfMatches { get; set; }
        }
    }
}
