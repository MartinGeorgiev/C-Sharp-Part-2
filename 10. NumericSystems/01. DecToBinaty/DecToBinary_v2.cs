//Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryToDec
{
    static void Main()
    {
        Console.Write("Please enter a binary number: ");
        string binaryString = Console.ReadLine();

        bool rightInput = true;

        char[] binaryToChar = binaryString.ToCharArray(); //Converting the string to charArray --> 0000 1111 ==> {0,0,0,0,1,1,1,1} 
        int arrLenght = binaryToChar.Length;

        Array.Reverse(binaryToChar);

        int result = 0;
        int number = 0;

        for (int i = 0; i < arrLenght; i++)
        {
            string charToString = Convert.ToString(binaryToChar[i]);

            number = Convert.ToInt32(charToString); //Converting each char of array, in integer.

            if (number > 1)
            {
                rightInput = false;
            }
            result = result + (int)Math.Pow(2, i) * number;//Using the second method --> http://www.wikihow.com/Convert-from-Binary-to-Decimal
            number = 0;
        }

        if (rightInput == true)
        {
            Console.WriteLine("Decimal representation of {0}: {1}", binaryString, result); //Printing the result.
        }
        else
        {
            Console.WriteLine("You have wrote invalid number.");
            Main();
        }
    }
}