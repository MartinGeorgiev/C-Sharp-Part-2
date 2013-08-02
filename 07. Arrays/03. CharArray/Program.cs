//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CharArray
{
    static void Main()
    {
        Console.Write("First Array Lenght: ");
        int firstArrayLenght = Convert.ToInt32(Console.ReadLine());

        Console.Write("Second Array Lenght: ");
        int secondArrayLenght = Convert.ToInt32(Console.ReadLine());

        int longerArray = Math.Max(firstArrayLenght, secondArrayLenght);
        int result = 0;

        Console.WriteLine();

        char[] firstArray = new char[firstArrayLenght];
        char[] secondArray = new char[secondArrayLenght];

        Console.WriteLine("First array - numbers: ");

        for (int i = 0; i < firstArrayLenght; i++)
        {
            Console.Write("Element[{0}]: ", i);
            firstArray[i] = Convert.ToChar(Console.ReadLine());
        }

        Console.WriteLine();

        Console.WriteLine("Second array - numbers: ");

        for (int y = 0; y < secondArrayLenght; y++)
        {
            Console.Write("Element[{0}]: ", y);
            secondArray[y] = Convert.ToChar(Console.ReadLine());
        }

        for (int z = 0; z < longerArray; z++)
        {
            if (firstArray[z] != secondArray[z])
            {
                if (firstArray[z] > secondArray[z])
                {
                    result = 2;
                    break;
                }

                if (firstArray[z] < secondArray[z])
                {
                    result = 1;
                    break;
                }
            }
        }


        Console.WriteLine();
        if (result == 0)
        {
            Console.WriteLine("Two arrays are lex. equal.");
        }

        if (result == 1)
        {
            Console.WriteLine("First array is earlier.");
        }

        if (result == 2)
        {
            Console.WriteLine("Second array is earlier.");
        }

    }
}

