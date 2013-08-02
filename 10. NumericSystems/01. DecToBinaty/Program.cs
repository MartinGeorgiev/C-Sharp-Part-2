//Write a program to convert decimal numbers to their binary representation.

using System;

class DecToBin
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        string binNumber = Convert.ToString(number, 2);

        Console.WriteLine("Result: {0}", binNumber);
    }
}