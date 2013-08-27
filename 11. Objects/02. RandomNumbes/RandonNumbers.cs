//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class RandomNumbers
{
    static void Main()
    {
        Random number = new Random();

        for (int i = 0; i < 10; i++)
        {
            int randomNumber = number.Next(100, 200);
            Console.WriteLine("Number [{0}]: {1}", i+1, randomNumber);
        }
    }
}