﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode._2019.Day_2
{
    public class OpCodeCalculator
    {
        public int[] Values { get; set; }
        private int Position { get; set; }
        public int opCode { get; set; }
        public int outputValue { get; set; }
        public OpCodeCalculator(string[] input)
        {
            Values = string.Join(",", input).Split(',').Select(int.Parse).ToArray();
            Position = 0;
        }

        public int Calculate()
        {
            while (true)
            {
                var firstIndex = Values[Position + 1];
                var secondIndex = Values[Position + 2];
                var outputIndex = Values[Position + 3];
                var firstValue = Values[firstIndex];
                var secondValue = Values[secondIndex];
                opCode = Values[Position];

                switch (Values[Position])
                {
                    case 1:
                        var addSum = firstValue + secondValue;
                        Values[outputIndex] = addSum;
                        Position += 4;
                        break;
                    case 2:
                        var mulSum = firstValue * secondValue;
                        Values[outputIndex] = mulSum;
                        Position += 4;
                        break;
                    case 99:
                        return outputValue = Values[0];
                        
                }
            }
        }

        public int Calculate(int noun, int verb)
        {
            Values[1] = noun;
            Values[2] = verb;
            var value = Calculate();
            return value;
        }
    }
}
