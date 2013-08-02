//Write a program to convert decimal numbers to their binary representation.

using System;

class DecToBinary
{
    static void Main()
    {
        Console.Write("Please enter a number - decimal format: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int numberLenght = 0;

        if (number < 255 || number < -256) //Defining the lenght of the number in bits.
        {
            numberLenght = 8;
        }

        if ((number > 255 && number < 65353) || (number < -256 && number > -65353))
        {
            numberLenght = 16;
        }

        if ((number > 65353 && number < 2147483648) || (number < -65353 && number > - 2147483648))
        {
            numberLenght = 32;
        }

        if (number > 0)
        {
            DecToBinaryMethod(number, numberLenght);
        }

        if (number < 0)
        {
            DecimalToBinarySing(number, numberLenght);
        }
    }

    static void DecToBinaryMethod(int number, int numberLenght) //Converting the decimal number to binary, using a string.
    {
        string binaryDigit = "";
        int lastDigit = 0;

        for (int i = 1; i <= numberLenght; i++)
        {
            lastDigit = number % 2;                 //Searching for the residue in the division

            binaryDigit = binaryDigit + lastDigit;  //Add the residue to the string.
            number = number / 2;

            if (i % 4 == 0) //
            {
                binaryDigit = binaryDigit + " "; //Add an interval, after each 4 digits, for better view --> 0000 0001;
            }
        }
        PrintNumber(binaryDigit);
    }

    static void DecimalToBinarySing(int number, int numberLenght) //Converting negative decimal number to its binary representation.
    {                                                           //-1 ==> 1111 1111
        string binaryDigit = "";                                //-2 ==> 1111 1110
        int lastDigitS = 0;
        number = Math.Abs(number + 1);

        for (int i = 1; i <= numberLenght; i++)
        {
            lastDigitS = number % 2;

            int lastDigit = 0;

            if (lastDigitS == 1) //If the digit/residue/ is 1, we convert the digit to 0;
            {
                lastDigit = 0;
            }

            else
            {
                lastDigit = 1; ////If the digit/residue/ is 0, we convert the digit to 1;
            }

            binaryDigit = binaryDigit + lastDigit;
            number = number / 2;

            if (i % 4 == 0)
            {
                binaryDigit = binaryDigit + " ";
            }
        }
        PrintNumber(binaryDigit);
    }

    static void PrintNumber(string binaryDigit) //Printing the result.
    {
        char[] arrString = binaryDigit.ToCharArray(); //Converting the string to charArray, because it must be reversed.
        Array.Reverse(arrString); //Reversing the array, because first digit is on last position now --> 1 ==> 1000 0000;
        string binary = new string(arrString); //After reversing the result is 0000 0001;

        Console.WriteLine("Result - binary representation: {0}", binary);
    }
}