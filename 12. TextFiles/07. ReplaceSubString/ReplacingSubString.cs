/*Write a program that replaces all occurrences of the substring
"start" with the substring "finish" in a text file. Ensure it will 
work with large files (e.g. 100 MB).*/

using System;
using System.IO;

class ReplaceSubString
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
                    writer.WriteLine(line.Replace("start", "finish"));
                }
            }
        }
    }
}