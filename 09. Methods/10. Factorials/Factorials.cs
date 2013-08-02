/*Write a program to calculate n! for each n in the range [1..100]. 
 * Hint: Implement first a method that multiplies a number represented 
 * as array of digits by given integer number. */

//Using an array.

using System;
using System.Numerics;

class Factorials
{
    static void Calculation(int[] array, BigInteger factorial)
    {
        for (int i = 1; i < 101; i++) //Printing the rows - 1 to 100;
        {
            factorial = factorial * array[i]; //There is only one variable in which keeping the factorial value.

            Console.WriteLine("Element[{0}]: {1}",i, factorial);
        }
    }

    static void Main()
    {
        int[] array = new int[101]; //Allocating the array.
        BigInteger factorial = 1;

        for (int i = 1; i < 101; i++) //Initializing the elements of array.
        {
            array[i] = i;
        }

        Calculation(array, factorial);
    }
}
