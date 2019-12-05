using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode._2019.Day_1
{
    internal static class Day1
    {
        private static List<int> _part1Values = new List<int>();
        private static int _part2Values;
        public static int Part1(string[] input)
        {
            foreach (var line in input)
            {
                var mass = int.Parse(line) / 3 - 2;
                _part1Values.Add(mass);
            }

            return _part1Values.Sum(value => value);
        }

        public static int Part2(string[] input)
        {
            var partialValues = new List<int>();
            foreach (var line in input)
            {
                var mass = int.Parse(line);
                while (mass > 0)
                {
                    mass = mass / 3 - 2;
                    if (mass > 0)
                    {
                        partialValues.Add(mass);
                    }
                }
            }

            _part2Values = partialValues.Sum(value => value);
            return _part2Values;
        }
    }
}
