/*Sorting an array means to arrange its elements in increasing order. 
 * Write a program to sort an array. Use the "selection sort" algorithm:
 * Find the smallest element, move it at the first position, find the smallest
 * from the rest, move it at the second position, etc.*/

using System;

class SelectionSort
{
    static void Main()
    {
        int minValue = Int32.MaxValue;
        int temp = 0;

        Console.Write("Array Lenght: ");
        int arrLenght = Convert.ToInt32(Console.ReadLine());

        int[] myArr = new int[arrLenght];

        for (int i = 0; i < arrLenght; i++)
        {
            Console.Write("Element[{0}]:", i);
            int myArrElement = Convert.ToInt32(Console.ReadLine());
            myArr[i] = myArrElement;
        }

        for (int y = 0; y < arrLenght; y++)
        {
            for (int i = y; i < arrLenght; i++)
            {
                if (myArr[i] < minValue)
                {
                    minValue = myArr[i];
                    temp = myArr[y];
                    myArr[y] = myArr[i];
                    myArr[i] = temp;
                }
            }
            minValue = Int32.MaxValue;
        }

        for (int i = 0; i < arrLenght; i++)
        {
            Console.WriteLine(myArr[i]);
        }
    }
}