//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;

class HexToBinary
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        string hexValue = Console.ReadLine();
        string result = "";

        char[] hexValueChar = hexValue.ToCharArray(); //Converting string to CharArray to separate and use each symbol of hexValue.
        int arrLenght = hexValueChar.Length;

        string digit = "";
        bool rightInput = true; //If the input is wrong, there will be an error.

        for (int y = 0; y < arrLenght; y++)
        {
            digit = Convert.ToString(hexValueChar[y]);

            switch (digit)
            {
                case "0": digit = "0000"; break;
                case "1": digit = "0001"; break;
                case "2": digit = "0010"; break;
                case "3": digit = "0011"; break;
                case "4": digit = "0100"; break;
                case "5": digit = "0101"; break;
                case "6": digit = "0110"; break;
                case "7": digit = "0111"; break;
                case "8": digit = "1000"; break;
                case "9": digit = "1001"; break;
                case "A": digit = "1010"; break;
                case "B": digit = "1011"; break;
                case "C": digit = "1100"; break;
                case "D": digit = "1101"; break;
                case "E": digit = "1110"; break;
                case "F": digit = "1111"; break;
                default: rightInput = false; break; //If there is invalid symbol, there will be an error.
            }
            result = result + digit + " ";

        }
        if (rightInput == false)
        {
            Console.WriteLine("There is an error! The number is invalid."); //There is an error if number is invalid
            Main();                                                         //Recalling the Main() method.
        }
        else
        {
            Console.WriteLine("Binary representation og HEX number - Result: " + result);
        }
    }
}


