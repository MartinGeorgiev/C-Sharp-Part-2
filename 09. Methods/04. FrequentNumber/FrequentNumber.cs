/*Write a method that counts how many times given number appears in given array. 
 * Write a test program to check if the method is working correctly.*/

using System;

class FrequentNumber
{
    static void FindNumber(int k, int[] array)
    {
        int counter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (k == array[i])
            {
                counter++; //Add 1 every time when the loop finds the searched number.
            }
        }

        if (counter == 0) //There is no such number in array.
        {
            Console.WriteLine("There is no such number in array.");
        }
        else
        {
            Console.WriteLine("The number K appears {0} times in the array.", counter);
        }
    }

    static void Main()
    {
        Console.Write("Please enter the number K: "); //User enters a number /the searched number/.
        int k = Convert.ToInt32(Console.ReadLine());

        int[] array = { 1, 5, 123, 5, 222, 3, 55, 6, 78, 10, 689 };

        FindNumber(k, array);
    }
}

