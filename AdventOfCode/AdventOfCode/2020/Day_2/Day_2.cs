using System;
using System.Collections.Generic;

namespace AdventOfCode._2020.Day_2
{
    public static class Day_2
    {
        private static readonly string[] Input = AdventOfCode.Input.Read(@"./2020/Day_2/Input/input.txt");
        public static void Part1()
        {
            var a = new List<PasswordModel>();
            foreach (var item in Input)
            {
                var min = item.Split('-')[0];
                var max = item.Split('-')[1];
                var cha = item.Split(' ')[0];
                var password = item.Split()
                a.Add(new PasswordModel
                {
                    
                });
            }
        }
        //1-3 a: abcde
        //1-3 b: cdefg
        //2-9 c: ccccccccc
        public string GetSubStr(string str, string separator)
        {
            var index = str.IndexOf(separator, StringComparison.Ordinal);
            string subString;
            if (index >= 0)
            {
                subString = str.Substring(0, index)
            }
            else
            {
                subString = str.Substring()
            }
        }

        private class PasswordModel
        {
            public int MinimumNumberOfTimesPresent { get; set; }
            public int MaximumNumberOfTimesPresent { get; set; }
            public char CharToBePresent { get; set; }
            public string PasswordString { get; set; }
            public bool IsMatch { get; set; }
        }
    }
}
