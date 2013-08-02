//Write a program to convert decimal numbers to their hexadecimal representation.

using System;

class DecToHex
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        string hexNumber = Convert.ToString(number, 16);

        hexNumber = hexNumber.ToUpper();

        Console.WriteLine("Result: {0}", hexNumber);
    }
}