/*Write a program that reads two arrays from the 
 * console and compares them element by element.*/

using System;

class CompareArrays
{
    static void Main()
    {
        int i = 0;
        int y = 0;
        int z = 0;
        bool generalResult = true;

        Console.Write("Array Lenght: ");    
        int arrayLenght = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        int[] firstArray = new int[arrayLenght];
        int[] secondArray = new int[arrayLenght];

        Console.WriteLine("First array - numbers: ");

        for (i = 0; i < arrayLenght; i++)
        {
            Console.Write("Element[{0}]: ", i);
            firstArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine();

        Console.WriteLine("Second array - numbers: ");

        for (y = 0; y < arrayLenght; y++)
        {
            Console.Write("Element[{0}]: ", y);
            secondArray[y] = Convert.ToInt32(Console.ReadLine());
        }

        i = y = 0;

        Console.WriteLine();

        Console.WriteLine("Array comparing result - true/false: ");
        for (z = 0; z < arrayLenght; z++, i++, y++)
        {
            bool result = (firstArray[i] == secondArray[y]);
            
            if (result == false)
            {
                generalResult = false;
            }
            Console.WriteLine("Element[{0}]: {1}", z, result);
        }

        Console.WriteLine();

        if (generalResult == true)
        {
            Console.WriteLine("Result: Two arrays are equal.");
        }
        else
        {
            Console.WriteLine("Result: Two arrays are NOT equal.");
        }
    }
}
