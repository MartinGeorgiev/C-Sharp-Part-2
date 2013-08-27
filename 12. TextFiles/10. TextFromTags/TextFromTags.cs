//Write a program that extracts from given XML file all the text without the tags.

using System;
using System.IO;
using System.Text.RegularExpressions;

class TextFromTags
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

                    writer.WriteLine(Regex.Replace(line, @"<(.*?)>", String.Empty));
                }
            }

            Console.WriteLine("Done!");
        }
    }
}
