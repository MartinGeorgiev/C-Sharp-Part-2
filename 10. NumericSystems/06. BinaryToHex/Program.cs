//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;

class HexToBinary
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        string hexValue = Console.ReadLine();
        string result = "";

        char[] hexValueChar = hexValue.ToCharArray();
        int arrLenght = hexValueChar.Length;

        string digit = "";
        bool real = true;
        string digitString = "";

        for (int y = 0; y < arrLenght/4; y++)
        {
            for (int i = 0; i < 4; i++)
            {
                   digit = Convert.ToString(hexValueChar[i + y*4]);
                   digitString = digitString + digit;
            }

            switch (digitString)
            {
                case "0000": digitString = "0"; break;
                case "0001": digitString = "1"; break;
                case "0010": digitString = "2"; break;
                case "0011": digitString = "3"; break;
                case "0100": digitString = "4"; break;
                case "0101": digitString = "5"; break;
                case "0110": digitString = "6"; break;
                case "0111": digitString = "7"; break;
                case "1000": digitString = "8"; break;
                case "1001": digitString = "9"; break;
                case "1010": digitString = "A"; break;
                case "1011": digitString = "B"; break;
                case "1100": digitString = "C"; break;
                case "1101": digitString = "D"; break;
                case "1110": digitString = "E"; break;
                case "1111": digitString = "F"; break;
                default: real = false; break;
            }
            result = result + digitString;
            digitString = "";
        }
        if (real == false)
        {
            Console.WriteLine("There is an error!");
        }
        else
        {
            Console.WriteLine("Result: " + result);
        }
    }
}


