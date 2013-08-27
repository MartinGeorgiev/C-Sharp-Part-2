/*You are given a sequence of positive integer values written into a string,
 * separated by spaces. Write a function that reads these values 
 * from given string and calculates their sum.
 * Example: string = "43 68 9 23 318"  result = 461 */

using System;

class SumFromString
{
    static void Main()
    {
        string numbersInString = "1, 2, 3, 4, 5, 6, 7"; //Result = 28;
        int sum = 0;

        string [] numbers = numbersInString.Split(',');

        foreach (string number in numbers)
        {
            int singleNumber = Convert.ToInt32(number);
            sum = sum + singleNumber;
        }

        Console.WriteLine("Sum: {0}", sum);
    }
}
