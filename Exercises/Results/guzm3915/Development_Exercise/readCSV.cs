using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace crud
{
    class readCSV
    {
        public static Dictionary<string, string> importData()
        {
            Dictionary<string, string> temp = new Dictionary<string, string>();
            foreach (string line in File.ReadLines("authors.txt"))
            {
                temp.Add(line.Split(",")[0], line.Split(",")[1]);
            }
            return temp;
        }
    }
}
