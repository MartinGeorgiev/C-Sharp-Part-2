//Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryToDec
{
    static void Main()
    {
        Console.Write("Please enter a binary number: ");
        string binaryString = Console.ReadLine();

        char[] binaryToChar = binaryString.ToCharArray();
        int arrLenght = binaryToChar.Length;

        Array.Reverse(binaryToChar);

        int result = 0;
        int number = 0;

        for (int i = 0; i < arrLenght; i++)
        {
            string charToString = Convert.ToString(binaryToChar[i]);
            number = Convert.ToInt32(charToString);
            if (number > 1)
            {

            }
            result = result + (int)Math.Pow(2, i) * number;
            number = 0;
        }
        Console.WriteLine("Decimal representation of {0}: {1}", binaryString, result);
    }
}