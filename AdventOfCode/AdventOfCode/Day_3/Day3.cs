using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCode {
    static class Day3 {
        public static string Part1(string[] input) {
            var claims = new List<Claim>();
            foreach (var row in input.ToList()) {
                Claim claim = new Claim();
                var capture = Regex.Match(row, "(#[0-9]+) @ ([0-9]+),([0-9]+): ([0-9]+)x([0-9]+)").Groups;
                claim.Id = int.Parse(capture[1].Value.Replace("#", ""));
                claim.FromLeft = int.Parse(capture[2].Value);
                claim.FromTop = int.Parse(capture[3].Value);
                claim.Width = int.Parse(capture[4].Value);
                claim.Height = int.Parse(capture[5].Value);
                claims.Add(claim);
            }
            //Draw area of dots
            
            return "";
        }
        public class Claim {
            public int Id;
            public int FromLeft;
            public int FromTop;
            public int Width;
            public int Height;
        }
    }
}
