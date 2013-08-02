//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

using System;

class Sorting
{
    static void GetMaxNumberInPortion(int[] array, int index) //Searching for the max element in array.
    {
        int maxNumber = array[index];
        int element = 0;

        for (int i = index; i < array.Length-1; i++)
        {
            if (array[i] > array[i + 1])
            {
                maxNumber = array[i];
                element = i;
            }
        }

        int swap = array[array.Length-1];
        array[array.Length-1] = maxNumber;
        array[element] = swap;
    }

    static void SortPortion(int[] array, int index, int element, int maxNumber) //Using selection sort for the portion of array and sort it.
    {
        int z = 2;

        for (int start = array.Length - index; start > 1; start--)
        {
            maxNumber = int.MinValue;

            for (int i = index; i < index + start - 1; i++)
            {
                if (array[i] > maxNumber)
                {
                    maxNumber = array[i];
                    element = i;
                }
            }

            int swap = array[array.Length - z];
            array[array.Length - z] = maxNumber;
            array[element] = swap;
            z++;
        }
    }

    static void SortDescending(int[] array) //Using insertion sort for the entire array.
    {
        int temp, k;
        for (int i = 1; i < array.Length; i++)
        {
            temp = array[i];
            k = i - 1;
            while (k >= 0 && array[k] > temp)
            {
                array[k + 1] = array[k];
                k--;
            }
            array[k + 1] = temp;
        }
    }

    static void SortAscending(int[] array) //Reversing the array.
    {
        Array.Reverse(array);     
    }

    static void PrintArrayAscending(int[] array)  //Printing the result.
    {
        Console.Write("Result - descending sorting: {");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]+ ", ");
        }
        Console.Write("}");
        Console.WriteLine();
    }

    static void PrintArrayDescending(int[] array) //Printing the result.
    {
        Console.Write("Result - ascending sorting: {");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + ", ");
        }
        Console.Write("}");
        Console.WriteLine();
    }

    static void Main()
    {
        int[] array = { 1, 5, -4444, 4, 3, -10, 5, -11 }; //Allocating and initializing the array.

        int index = 3;
        int maxNumber = array[index];
        int element = 0;

        //Calling each method.
        GetMaxNumberInPortion(array, index);
        SortPortion(array, index, element, maxNumber);
        SortDescending(array);
        PrintArrayDescending(array);
        SortAscending(array);
        PrintArrayAscending(array);
    }
}