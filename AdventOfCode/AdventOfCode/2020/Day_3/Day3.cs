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
            return GetNumberOfTrees(1, 3);
        }

        public static int Part2()
        {
            return GetNumberOfTrees(1, 1) * GetNumberOfTrees(1, 3) * GetNumberOfTrees(1, 5) * GetNumberOfTrees(1, 7) * GetNumberOfTrees(2, 1);
        }

        private static int GetNumberOfTrees(int moveDown, int moveRight)
        {
            var trees = 0;
            var currentHorizontalPosition = 0;
            for (var currentVerticalPosition = 0; currentVerticalPosition < Input.Count - 1;)
            {
                //Go down x
                currentVerticalPosition += moveDown;
                //Go right x
                currentHorizontalPosition += moveRight;
                var line = Input[currentVerticalPosition];
                if (currentHorizontalPosition + moveRight > Input[currentVerticalPosition].Length)
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
