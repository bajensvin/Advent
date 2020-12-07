using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode._2020.Day_4
{
    public class Day4
    {

        public static int Part1()
        {

            var Input = AdventOfCode.Input.Read(@"./2020/Day_4/Input/input.txt").ToList();
            var a = Input.Select(x => x.Split(' '));
            var b = Input.Select(x => x.Split()).ToList();












            //Take all rows until "", add everything to the new passport object and proceed to next row
            var listOfPassports = new List<Passport>();
            var listOfValidPassports = new List<Passport>();
            var passport = new Passport();
            var typelist = new List<string>();
            var types = "";
            for (var i = 0; i < Input.Count; i++)
            {
                //var row = Input[i];
                //var rowStr = row.Split(' ');
                //if (row != "")
                //{
                //    passportString += row;
                //}



                var row = Input[i].Split(' ');
                //If row is not empty(indicates new passport)
                if (row.Any(x => x == ""))
                {
                    //if (passport.BirthYear.HasValue && passport.ExpirationYear.HasValue && passport.EyeColor != string.Empty && passport.EyeColor != null && passport.HairColor != string.Empty && passport.HairColor != null && passport.Height != string.Empty && passport.Height != null && passport.IssueYear.HasValue && passport.PassportId != string.Empty && passport.PassportId != null && passport.CountryId.HasValue)
                    //{
                    //    listOfValidPassports.Add(passport);
                    //}
                    listOfPassports.Add(passport);
                    typelist.Add(types);
                    passport = new Passport();
                    types = "";
                    continue;
                }
                else
                {
                    foreach (var part in row)
                    {
                        var splitAgain = part.Split(':');
                        var type = splitAgain[0];
                        var value = splitAgain[1];
                        types += type + " ";
                        switch (type)
                        {
                            case "eyr":
                                passport.ExpirationYear = int.Parse(value);
                                break;
                            case "iyr":
                                passport.IssueYear = int.Parse(value);
                                break;
                            case "byr":
                                passport.BirthYear = int.Parse(value);
                                break;
                            case "hgt":
                                passport.Height = value;
                                break;
                            case "hcl":
                                passport.HairColor = value;
                                break;
                            case "ecl":
                                passport.EyeColor = value;
                                break;
                            case "pid":
                                passport.PassportId = value;
                                break;
                            case "cid":
                                passport.CountryId = int.Parse(value);
                                break;
                        }
                    }
                }
            }
            //267 too high
            //253 too low
            //234 too low
            //137 too low
            var required = new[] { "byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid" }.ToList();
            var requiredString = "byr iyr, eyr, hgt, hcl, ecl, pid";
            var count = 0;
            var bla = listOfPassports.Count(x => x.BirthYear.HasValue && x.ExpirationYear.HasValue && x.EyeColor != string.Empty && x.HairColor != string.Empty && x.Height != string.Empty && x.IssueYear.HasValue && x.PassportId != string.Empty);

            

            return 0;
        }
        public class Passport
        {
            public int? BirthYear { get; set; }
            public int? IssueYear { get; set; }
            public int? ExpirationYear { get; set; }
            public string Height { get; set; }
            public string HairColor { get; set; }
            public string EyeColor { get; set; }
            public string PassportId { get; set; }
            public int? CountryId { get; set; }
        }
    }
}
