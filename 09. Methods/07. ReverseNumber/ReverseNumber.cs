/*Write a method that reverses the digits of given decimal number. 
 * Example: 256  652*/

using System;

class ReverseNumber
{
    static void ReversingNumber(string number)
    {
        char[] array = number.ToCharArray(); //Converting the string in a charArray. {1, 2, 3}
        Array.Reverse(array); //Reversing the charArray --> {3, 2, 1}

        string reversedNumber = "";

        for (int i = 0; i < array.Length; i++) //Converting the array in a string. {3, 2, 1} -- > 321
        {
            reversedNumber = reversedNumber + array[i];
        }

        long revNumber = Convert.ToInt64(reversedNumber); //Converting the string in a long number.

        Console.WriteLine("Reversed number: {0}", revNumber);//Printing the result.
    }

    static void Main()
    {
        Console.Write("Please enter the number: "); //The user enters a number --> string.
        string number = Console.ReadLine(); 

        ReversingNumber(number);
    }
}
