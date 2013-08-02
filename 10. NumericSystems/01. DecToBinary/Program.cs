//Write a program to convert decimal numbers to their binary representation.

using System;

class DecToBinary
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int numberLenght = 0;

        if (number < 255)
        {
            numberLenght = 8;
        }

        if (number > 255 && number < 65353)
        {
            numberLenght = 16;
        }

        if (number > 65353 && number < 2147483648)
        {
            numberLenght = 32;
        }

        DecToBinaryMethod(number, numberLenght);
    }
    static void DecToBinaryMethod(int number, int numberLenght)
    {
        string binaryDigit = "";
        int lastDigit = 0;

        for (int i = 0; i < numberLenght; i++)
        {
            lastDigit = number % 2;
            binaryDigit = binaryDigit + lastDigit;
            number = number / 2;
        }
        PrintNumber(binaryDigit);
    }
    static void PrintNumber(string binaryDigit)
    {
        char[] arrString = binaryDigit.ToCharArray();
        Array.Reverse(arrString);
        string binary = new string(arrString);
        
        Console.WriteLine("Result: {0}", binary);
    }
}