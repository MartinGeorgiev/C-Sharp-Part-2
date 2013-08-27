//Write a program that removes from a text file all words listed in 
//given another text file. Handle all possible exceptions in your methods.

using System;
using System.IO;
using System.Collections.Generic;

class RemoveWords
{
    static void Main()
    {
        List<string> words = new List<string>();

        using (StreamReader reader = new StreamReader(@"words.txt"))
        {
            string line = "";

            while (line != null)
            {
                line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }
                words.Add(line);
            }
        }

        using (StreamWriter writer = new StreamWriter(@"temp.txt"))
        {
            string line = "";

            using (StreamReader replacer = new StreamReader(@"text.txt"))
            {
                line = replacer.ReadToEnd();

                for (int i = 0; i < words.Count; i++)
                {
                    string replacingWord = words[i];
                    line = line.Replace(replacingWord + " ", "");
                }
            }
            writer.WriteLine(line);
        }

        Console.WriteLine("Done!");
    }
}
