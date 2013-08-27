//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different. Assume the files have equal number of lines.

using System;
using System.IO;
using System.Text;

class CompareLineByLine
{
    static void Main()
    {
        int counter = 0;

        using(StreamReader firstReader = new StreamReader(@"firstFile.txt"))
        {
            using (StreamReader secondReader = new StreamReader(@"secondFile.txt"))
            {
                string firstLine = "a";
                string secondLine = "b";

                while (firstLine != null)
                {
                    if (firstLine == secondLine)
                    {
                        counter++;
                    }

                    firstLine = firstReader.ReadLine();
                    secondLine = secondReader.ReadLine();
                }
            }
        }

        Console.WriteLine("Result - number of equal rows {0}", counter);
    }
}