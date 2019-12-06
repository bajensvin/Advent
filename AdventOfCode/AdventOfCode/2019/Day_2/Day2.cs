using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode._2019.Day_2
{
    class Day2
    {
        public static int Part1(string[] input)
        {

            //För varje "opcode"
            //1. Hitta räknesätt
            //2. Hitta vilka positioner(index) talen man ska räkna med ligger på
            //3. Hämta de faktiska talen från varje position och räkna därefter
            //4. Lagra det uträknade värdet på index + 3
            //4. När programmet träffar koden 99, avsluta direkt
            input = string.Join(",", input).Split(',');
            var values = input.Select(int.Parse).ToArray();

            values[1] = 12;
            values[2] = 2;


            //int[] hej = { 1, 9, 10, 3, 2, 3, 11, 0, 99, 30, 40, 50 };

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == 1)
                {
                    var indexOfFirstValue = i + 1;
                    var indexOfSecondValue = i + 2;
                    var indexOfOutputValue = i + 3;
                    var firstValue = values[indexOfFirstValue];
                    var secondValue = values[indexOfSecondValue];
                    var outputValue = firstValue + secondValue;
                    values.SetValue(outputValue, indexOfOutputValue);
                    i += 3;
                }
                else if (values[i] == 2)
                {
                    var indexOfFirstValue = i + 1;
                    var indexOfSecondValue = i + 2;
                    var indexOfOutputValue = i + 3;
                    var firstValue = values[indexOfFirstValue];
                    var secondValue = values[indexOfSecondValue];
                    var outputValue = firstValue * secondValue;
                    values.SetValue(outputValue, indexOfOutputValue);
                    i += 3;

                }
                else if (values[i] == 99)
                {
                    return values[0];
                }
            }

            return 0;
        }
    }
}
