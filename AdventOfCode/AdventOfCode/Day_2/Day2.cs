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
        public class Letter {
            public string CompleteString { get; set; }
            public char[] CharArray { get; set; }
        }
        public static string Part2(string[] input) {



            //Look at each string, if char is not present in any other string at the same position remove it
            //Get value of how many chars are common

            //Add chars in string to new array of chars, 1 string = one array of many chars
            //Iterate over the list of strings with chars in it, search all other strings for a string that has matching array of chars -1 char
            //var listOfStrings = new List<string>();
            //listOfStrings = input.ToList();
            Letter letter = new Letter();
            var listOfLetters = new List<Letter>();
            var listOfStrings = new List<string> {
                "abcde",
                "abcdd"
            };
            var listOfMatches = new List<char>();
            var listOfChars = new List<char[]>();
            foreach (var item in listOfStrings) {
                listOfChars.Add(item.ToCharArray());
            }
            

            //använd for loop för att se till så den inte kollar samma
            //För varje item i listan

                //För varje char i arrayen
               
                    //För varje item i listan förutom sig själv
                 


            //Kolla varje char i en sträng en gång mot resten av listan, om match continue, annars avbryt och kolla nästa sträng?
            foreach (var item in listOfStrings) {
                //Måste se till att den inte matchar mot sig själv

                char[] charArray = item.ToCharArray();
                
                foreach (char currentChar in charArray) {

                    
                        
                        //tror inte any funkar här
                        bool match = listOfStrings.Exists(str => str.ToCharArray().Any(ch => ch == currentChar));
                        if (match) {
                            listOfMatches.Add(currentChar);
                            continue;
                        } else {
                            break;
                        }
                }
            }





            foreach (var item in listOfStrings) {
                letter = new Letter {
                    CharArray = item.ToCharArray(),
                    CompleteString = item
                };
                listOfLetters.Add(letter);
            }
            foreach (var item in listOfLetters) {
                var wholeCharArraysThatMatchInString = listOfLetters.Select(s => s.CharArray.Any(b => b == item.CharArray.First()));
                foreach (var c in item.CharArray) {
                    var singleCharsThatMatchInString = listOfLetters.Select(s => s.CharArray.Any(b => b == c));
                }
            }






            return "";
        }
    }
}
