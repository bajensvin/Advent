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
            var a = Input.Select(x => x.Split(' ')).ToList();
            var b = Input.Select(x => x.Split()).ToList();

            var requiredFields = new[] { "byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid" };
            var requiredFieldsList = new List<string> { "byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid" };
            var requiredCount = 7;
            var currentCount = 0;
            var valids = 0;
            var stringToAdd = "";
            var tempList = new List<string>();
            var passportKeys = new List<string>();
            var row = "";
            for (int i = 0; i <= a.Count; i++)
            {
                if (i == Input.Count - 2)
                {

                }
                
                
                    row = Input[i];
                
                
                if (row == string.Empty || i == a.Count - 1)
                {
                    //Skip empty row
                    //i++;
                    //Den tar inte den sista raden pga currentcount har blivit nollad och den foreachar inte varje part i den heller, fixa så löses problemet
                    if (currentCount >= requiredCount)
                    {
                        if (tempList.All(requiredFields.Contains))
                        {
                            valids += 1;
                        }
                    }
                    currentCount = 0;
                    tempList = new List<string>();
                }

                foreach (var part in row.Split(' '))
                {
                    if (part == "") continue;
                    if (part.Split(':')[0] == "cid") continue;
                    tempList.Add(part.Split(':')[0]);
                    currentCount += 1;

                }
            }

            //Take all rows until "", add everything to the new passport object and proceed to next row
            var listOfPassports = new PassportList { Passports = new List<Passports>() };
            var passportItemToAdd = new Passports { ExpirationYear = new PassportItem(), BirthYear = new PassportItem(), CountryId = new PassportItem(), EyeColor = new PassportItem(), HairColor = new PassportItem(), Height = new PassportItem(), IssueYear = new PassportItem(), PassportId = new PassportItem() };
            for (var i = 0; i < Input.Count; i++)
            {
                var asdsa = Input.Count(x => x == "\r\n" || x == "\r");
                //var row = Input[i];
                //If row is not empty(indicates new passport)
                if (Input[i] == string.Empty || Input[i] == "\n")
                {
                    i++;
                    if (passportItemToAdd != null)
                    {
                        listOfPassports.Passports.Add(passportItemToAdd);
                        passportItemToAdd = new Passports { ExpirationYear = new PassportItem(), BirthYear = new PassportItem(), CountryId = new PassportItem(), EyeColor = new PassportItem(), HairColor = new PassportItem(), Height = new PassportItem(), IssueYear = new PassportItem(), PassportId = new PassportItem() };
                    }
                }
                else
                {
                    foreach (var asdf in Input[i].Split(' '))
                    {
                        var splitRow = new string[] { };
                        if (row.Split(' ').Length > 1)
                        {

                        }
                        splitRow = row.Split(':');
                        var type = splitRow[0];
                        var value = splitRow[1];

                        switch (type)
                        {
                            case "eyr":
                                passportItemToAdd.ExpirationYear.Exists = true;
                                passportItemToAdd.ExpirationYear.Value = int.Parse(value);
                                break;
                            case "iyr":
                                passportItemToAdd.IssueYear.Exists = true;
                                passportItemToAdd.IssueYear.Value = int.Parse(value);
                                break;
                            case "byr":
                                passportItemToAdd.BirthYear.Exists = true;
                                passportItemToAdd.BirthYear.Value = int.Parse(value);
                                break;
                            case "hgt":
                                passportItemToAdd.Height.Exists = true;
                                passportItemToAdd.Height.Value = value;
                                break;
                            case "hcl":
                                passportItemToAdd.HairColor.Exists = true;
                                passportItemToAdd.HairColor.Value = value;
                                break;
                            case "ecl":
                                passportItemToAdd.EyeColor.Exists = true;
                                passportItemToAdd.EyeColor.Value = value;
                                break;
                            case "pid":
                                passportItemToAdd.PassportId.Exists = true;
                                passportItemToAdd.PassportId.Value = value;
                                break;
                            case "cid":
                                passportItemToAdd.CountryId.Exists = true;
                                passportItemToAdd.CountryId.Value = int.Parse(value);
                                break;
                        }
                    }
                }
            }


            var count = listOfPassports.Passports.Count(x => x.BirthYear.Exists == true && x.ExpirationYear.Exists == true && x.EyeColor.Exists == true && x.HairColor.Exists == true && x.Height.Exists == true && x.IssueYear.Exists == true && x.PassportId.Exists == true);
            //267 too high
            //253 too low
            //234 too low
            //137 too low
            var required = new[] { "byr", "iyr", "eyr", "hgt", "hcl", "ecl", "pid" }.ToList();
            //var requiredString = "byr iyr, eyr, hgt, hcl, ecl, pid";
            //var count = 0;
            //var bla = listOfPassports.Count(x => x.BirthYear.HasValue && x.ExpirationYear.HasValue && x.EyeColor != string.Empty && x.HairColor != string.Empty && x.Height != string.Empty && x.IssueYear.HasValue && x.PassportId != string.Empty);



            return 0;
        }

        public class PassportList
        {
            public List<Passports> Passports { get; set; }
        }
        public class Passports
        {
            public PassportItem BirthYear { get; set; }
            public PassportItem IssueYear { get; set; }
            public PassportItem ExpirationYear { get; set; }
            public PassportItem Height { get; set; }
            public PassportItem HairColor { get; set; }
            public PassportItem EyeColor { get; set; }
            public PassportItem PassportId { get; set; }
            public PassportItem CountryId { get; set; }
        }

        public class PassportItem
        {
            public bool? Exists { get; set; }
            public object Value { get; set; }
        }
    }
}
