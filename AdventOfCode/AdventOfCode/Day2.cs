using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode {
    class Day2 {
        public static string Part1(string[] input) {
            HashSet<char> characters = new HashSet<char>();
            foreach (var item in input) {
                //Om raden har fler än 1 dubblett så räknas det fortfarande bara som en dubblett 
                foreach (char c in item) {
                    characters.Add(c);
                }
            }
            return "";
        }
    }
}
