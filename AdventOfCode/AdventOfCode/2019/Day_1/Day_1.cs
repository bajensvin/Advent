using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode._2019.Day_1
{
    class Day_1
    {
        private static List<int> _values;
        public static int Part1(string[] input)
        {
            _values = new List<int>();

            foreach (var line in input)
            {
                var value = int.Parse(line) / 3;
                _values.Add(value);
            }

            return _values.Sum(y => y - 2);
        }

        public static int Part2(string[] input)
        {

        }
    }
}
