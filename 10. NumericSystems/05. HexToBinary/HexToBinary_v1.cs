//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;

class HexToBinary
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        string number = Console.ReadLine();

        string binaryNumber = Convert.ToString(Convert.ToInt32(number, 16), 2); //Indirect converting

        Console.WriteLine("Result: {0}", binaryNumber);
    }
}
