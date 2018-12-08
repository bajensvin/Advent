using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode {
    static class Input {
        public static string[] Read(string filePath) {
            return File.ReadAllLines(filePath);
        }
    }
}
