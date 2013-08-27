//Write a program that concatenates two text files into another text file.

using System;
using System.IO;
using System.Text;

class ConcatenateTwoFiles
{
    static void Main()
    {
        using(StreamWriter writer = new StreamWriter(@"writer.txt"))
        {

            Console.WriteLine("Please wait...");
 
            using(StreamReader firstReader = new StreamReader(@"firstReader.txt", Encoding.GetEncoding("windows-1251")))
            {
                string lineFirstText = "";
             
                while (lineFirstText != null)
                {
                    lineFirstText = firstReader.ReadLine();
                    writer.WriteLine(lineFirstText);
                    
                }
            }

            using(StreamReader secondReader = new StreamReader(@"secondReader.txt", Encoding.GetEncoding("windows-1251")))
            {
                string lineSecondText = "";

                while (lineSecondText != null)
                {
                    lineSecondText = secondReader.ReadLine();
                    writer.WriteLine(lineSecondText);
                }
            }
        }

        Console.WriteLine("Concatenating - finished.");
    }
}