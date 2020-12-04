using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode._2020.Day_3
{
    public static class Day3
    {
        public static List<string> Input = AdventOfCode.Input.Read(@"./2020/Day_3/Input/input.txt").ToList();
        public static int Part1()
        {
            return GetTrees(1, 3);
        }

        public static int Part2()
        {
            var first = GetTrees(1, 1);
            var second = GetTrees(1, 3);
            var third = GetTrees(1, 5);
            var fourth = GetTrees(1, 7);
            var fifth = GetTrees(2, 1);
            return first * second * third * fourth * fifth;
        }

        private static int GetTrees(int down, int right)
        {
            var trees = 0;
            var currentHorizontalPosition = 0;
            for (var currentVerticalPosition = 0; currentVerticalPosition < Input.Count - 1;)
            {
                //Go down 1
                currentVerticalPosition += down;
                //Go right 3
                currentHorizontalPosition += right;
                var line = Input[currentVerticalPosition];
                if (currentHorizontalPosition + right > Input[currentVerticalPosition].Length)
                {
                    for (var i = Input[currentVerticalPosition].Length - 1;
                        i < currentHorizontalPosition;
                        i += Input[currentVerticalPosition].Length)
                    {
                        line = line.Insert(line.Length, Input[currentVerticalPosition]);
                    }
                }

                var isTree = line[currentHorizontalPosition].ToString() == "#";
                if (isTree)
                {
                    trees++;
                }
            }
            return trees;
        }
    }
}
