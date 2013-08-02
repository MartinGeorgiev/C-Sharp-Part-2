/*Write a program that finds all prime numbers in the range [1...10 000 000].
 * Use the sieve of Eratosthenes algorithm (find it in Wikipedia).*/

using System;

class IsPrime
{
    static void Main()
    {
        Console.Write("Result: {");
        for (int i = 0; i < 10000000; i++)
        {
            if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
            {
                Console.Write(i);
                if (i <= 10000000)
                {
                    Console.Write(", ");
                }
            }
        }
        Console.WriteLine("}");
    }
}