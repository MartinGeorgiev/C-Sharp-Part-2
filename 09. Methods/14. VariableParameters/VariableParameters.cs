/*Write methods to calculate minimum, maximum, average,
 * sum and product of given set of integer numbers.
 * Use variable number of arguments. *///

using System;

class VariableParameters
{
    static int Sum(params int[] array)
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }

        return sum;
    }

    static double Average(params int[] array)
    {
        double averageSum = 0;
        double elements = 0; //The number of elements in array.

        for (int i = 0; i < array.Length; i++)
        {
            averageSum = averageSum + array[i];
            elements = i;
        }

        averageSum = averageSum / elements;

        return averageSum;
    }

    static int MaxElement(params int[] array)
    {
        int maxElement = int.MinValue;

        for (int i = 0; i < array.Length-1; i++)
        {
            if (array[i] > maxElement)
            {
                maxElement = array[i];
            }
        }

        return maxElement;
    }

    static int MinElement(params int[] array)
    {
        int minElement = int.MaxValue;

        for (int i = 0; i < array.Length-1; i++)
        {
            if (array[i] < minElement)
            {
                minElement = array[i];
            }
        }

        return minElement;
    }

    static void Main()
    {
        //Calling each method and print the result.
        Console.WriteLine("Result - SUM: {0}", Sum(1, 2, 3, 4, 5, 6, -7666, 34, 2, -111, 12, 2));
        Console.WriteLine("Result - SUM: {0}", Sum(6, 7666, 34, 2, -111, 12, 2));

        Console.WriteLine("Result - Average: {0}", Average(1, 2, 3, 4, 5, 6, -7666, 34, 2, -111, 12, 2));
        Console.WriteLine("Result - Average: {0}", Average(6, 7666, 34, 2, -111, 12, 2));

        Console.WriteLine("Result - Max Element: {0}", MaxElement(1, 2, 3, 4, 5, 6, -7666, 34, 2, -111, 12, 2));
        Console.WriteLine("Result - Max Element: {0}", MaxElement(6, 66, 34, 2, -111, 12, 2));

        Console.WriteLine("Result - Min element: {0}", MinElement(1, 2, 3, 4, 5, 6, -7666, 34, 2, -111, 122, 2));
        Console.WriteLine("Result - Min element: {0}", MinElement(6, 7666, 34, 1232, -111, 12, 2));
    }
}
