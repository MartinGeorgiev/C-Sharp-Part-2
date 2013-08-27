//Modify the solution of the previous problem to replace
//only whole words (not substrings).

using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWord
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"input.txt"))
        {
            using (StreamWriter writer = new StreamWriter(@"output.txt"))
            {
                string line = "";

                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    writer.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
                }
            }
        }
    }
}