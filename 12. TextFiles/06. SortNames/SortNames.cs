//Write a program that reads a text file containing a list of strings, 
//sorts them and saves them to another text file. 

using System;
using System.IO;
using System.Collections.Generic;

class SortNames
{
    static void Main()
    {
        List<string> names = new List<string>();
        string line = "";

        using (StreamReader reader = new StreamReader(@"input.txt"))
        {
            while (line != null)
            {
                line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }
                names.Add(line);
            }
        }

        names.Sort();

        using (StreamWriter writer = new StreamWriter(@"result.txt"))
        {
            foreach (string name in names)
            {
                writer.WriteLine(name);
            }
        }

        Console.WriteLine("Done!");
    }
}