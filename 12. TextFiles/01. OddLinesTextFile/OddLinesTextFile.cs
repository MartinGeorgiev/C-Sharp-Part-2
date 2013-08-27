//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;
using System.Text;

class OddLinesTextFiles
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"textFile.txt", Encoding.GetEncoding("windows-1251")))
        {
            int line = 1;
            string textLine = "";

            Console.WriteLine("Result - printing only odd lines: \n");

            while (textLine != null)
            {
                textLine = reader.ReadLine();

                if (line % 2 == 1)
                {
                    Console.WriteLine(textLine);
                }
                line++;
            }
        }
    }
}