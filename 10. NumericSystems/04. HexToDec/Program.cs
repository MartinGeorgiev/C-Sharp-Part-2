//Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexToDec
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        string number = Console.ReadLine();

        int numberDec = int.Parse(number, System.Globalization.NumberStyles.HexNumber);

        Console.WriteLine("Result: {0}", numberDec);
    }
}
