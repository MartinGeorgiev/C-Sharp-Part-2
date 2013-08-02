﻿/*Write a program that finds all prime numbers in the range [1...10 000 000].
 * Use the sieve of Eratosthenes algorithm (find it in Wikipedia).*/

using System;

class IsPrime
{
    static void Main()
    {

        int[] arr = new int[10000000];

        for (int i = 0; i < 10000000; i++)
        {
            int arrElement = i;
            arr[i] = arrElement;
        }

        Console.Write("Result: {");
        for (int i = 0; i < 10000000; i++)
        {
            if (arr[i] % 2 != 0 && arr[i] % 3 != 0 && arr[i] % 5 != 0 && arr[i] % 7 != 0)
            {
                Console.Write(arr[i]);
                if (i <= 10000000)
                {
                    Console.Write(", ");
                }
            }
        }
        Console.WriteLine("}");
    }
}