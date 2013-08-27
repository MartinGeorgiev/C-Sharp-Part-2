//Write a program that deletes from a text file all words that start with the prefix "test". 
//Words contain only the symbols 0...9, a...z, A…Z, _.

//Write a program that extracts from given XML file all the text without the tags.

using System;
using System.IO;
using System.Text.RegularExpressions;

class RemoveWords
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

                    writer.WriteLine(Regex.Replace(line, @"\btest[a-zA-Z0-9]+\b", String.Empty));
                }
            }
        }
    }
}
