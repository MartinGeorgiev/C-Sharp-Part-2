//Write a program that deletes from given text file all odd lines. 
//The result should be in the same file.

using System;
using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        using (StreamWriter writer = new StreamWriter(@"temp.txt"))
        {
            int counter = 1;

            using (StreamReader reader = new StreamReader(@"input.txt"))
            {
                string line = "";

                while (line != null)
                {
                    line = reader.ReadLine();

                    if (counter % 2 != 0)
                    {
                        line = "";
                    }
                    writer.WriteLine(line);
                    counter++;
                }
            }
        }

        using (StreamWriter writer = new StreamWriter(@"input.txt"))
        {
            using (StreamReader reader = new StreamReader(@"temp.txt"))
            {
                string line = "";

                while (line != null)
                {
                    line = reader.ReadLine();

                    writer.WriteLine(line);
                }
            }
        }

        File.Delete(@"temp.txt");
        Console.WriteLine("Done!");
    }
}