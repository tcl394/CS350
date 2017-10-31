using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace crud
{
    class Program
    {

        static Dictionary<string, string> authors;

        static void Main(string[] args)
        {
            authors = new Dictionary<string, string>();
            tester();
        }

        static void checkFile()
        {
            if (!File.Exists("authors.csv"))
            {
                // Create the file if it doesn't exist, otherwise it exists already
                File.WriteAllText("authors.csv", "xxx");
            }
        }

        static void tester()
        {
            checkFile();
            authors = readCSV.importData();
        }
    }
}
