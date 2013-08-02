
//Write a program to convert decimal numbers to their hexadecimal representation.

using System;

class DecToHex
{
    static void Main()
    {
        Console.Write("Please enter a number - decimal format: ");
        string numberD = Console.ReadLine();

        int numberDec = 0;
        bool numberBool = Int32.TryParse(numberD, out numberDec);

        if (numberBool == false) //There will be an error if the input is wrong.
        {
            Console.WriteLine("There is an error! Invalid number.");
            Main();
        }

        if (numberBool == true)
        {
            string hexNumber = Convert.ToString(numberDec, 16); //Converting decimal number to HEX format.

            hexNumber = hexNumber.ToUpper();

            Console.WriteLine("Result: {0}", hexNumber); //Printing the result.
        }
    }
}