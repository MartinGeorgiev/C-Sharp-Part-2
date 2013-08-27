//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

using System;
using System.IO;
using System.Text;

class LineNumbers
{
    static void Main()
    {
        using (StreamWriter writer = new StreamWriter(@"writer.txt"))
        {
            string line = "";
            int lineNumber = 1;
            string str = "";

            using (StreamReader reader = new StreamReader(@"reader.txt"))
            {
                while (line != null)
                {
                    line = reader.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    string numberToString = Convert.ToString(lineNumber);
                    str = numberToString + ". " + line;
                    
                    lineNumber++;
                    
                    writer.WriteLine(str);
                }
            }
        }

        Console.WriteLine("Done!");
    }
}