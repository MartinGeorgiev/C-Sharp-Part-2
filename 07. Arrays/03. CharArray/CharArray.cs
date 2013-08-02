//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CharArray
{
    static void Main()
    {
        Console.Write("Please enter - First Array`s Lenght: ");
        int firstArrayLenght = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter - Second Array`s Lenght: ");
        int secondArrayLenght = Convert.ToInt32(Console.ReadLine());

        bool rightInput = true;

        if (firstArrayLenght <= 0 || secondArrayLenght <= 0) // The array`s lenght must be number greater than 0.
        {
            rightInput = false;
        }

        if (rightInput == true)
        {

            int shorterArray = Math.Min(firstArrayLenght, secondArrayLenght); //Finding the lenght of shortest array.
            int result = 0;

            Console.WriteLine();

            //Initializing and comparing the elements of arrays.

            char[] firstArray = new char[firstArrayLenght];
            char[] secondArray = new char[secondArrayLenght];

            Console.WriteLine("Please enter - First array - chars: ");

            for (int i = 0; i < firstArrayLenght; i++) //Initializing elements of first array.
            {
                Console.Write("Element[{0}]: ", i);
                firstArray[i] = Convert.ToChar(Console.ReadLine());
            }

            Console.WriteLine();

            Console.WriteLine("Please enter - Second array - chars: ");

            for (int y = 0; y < secondArrayLenght; y++) //Initializing elements of second array.
            {
                Console.Write("Element[{0}]: ", y);
                secondArray[y] = Convert.ToChar(Console.ReadLine());
            }

            for (int z = 0; z < shorterArray; z++)
            {
                if (firstArray[z] != secondArray[z]) //Comparing each of elements of two arrays.
                {
                    if (firstArray[z] > secondArray[z]) //Break - The second array is earlier because the element[i] is smaller than the element[i] of first array.
                    {
                        result = 2;
                        break;
                    }

                    if (firstArray[z] < secondArray[z]) //Break - The first array is earlier because the element[i] is smaller than the element[i] of second array.
                    {
                        result = 1;
                        break;
                    }
                }
            }
            Console.WriteLine();

            if (result == 0 && firstArrayLenght == secondArrayLenght)
            {
                Console.WriteLine("Result: Two arrays are lex. equal."); //The arrays are equal.
            }

            if (result == 0 && firstArrayLenght > secondArrayLenght)
            {
                Console.WriteLine("Result: The second array is earlier."); //The arrays are not equal --> the first array is longer than second.
            }

            if (result == 0 && firstArrayLenght < secondArrayLenght)
            {
                Console.WriteLine("Result: The first array is earlier."); //The arrays are not equal --> the second array is longer than first.
            }

            if (result == 1)
            {
                Console.WriteLine("Result: The first array is earlier."); //The arrays are not equal --> the first is earlier.
            }

            if (result == 2)
            {
                Console.WriteLine("Result: The second array is earlier."); //The arrays are not equal --> the second is earlier.
            }
        }

        else
        {
            Console.WriteLine("Numbers you have wrote, are not valid. You should enter the numbers again.");
            Main();
        }
    }
}
    