/*Write a method that returns the index of the first element 
 * in array that is bigger than its neighbors, or -1, if there’s no such element.
Use the method from the previous exercise.*/

using System;

class NumberNeighbors
{
    static void FindNumber(int[] array)
    {
        bool noResult = true; //If there is no element in array which is greater than its neighbors.

        for (int i = 0; i < array.Length - 1; i++) //Searching if element[I] is greater than its neighbors/neighbor.
        {
            if ((i > 0 && array.Length > i) && (array[i] > array[i + 1] && array[i] > array[i - 1]))
            {
                Console.WriteLine("The number at position K is bigger than its two neighborS: {0} ", array[i]);
                noResult = false; //There is a element which is greatet than its neighbor, then bool is false;
                break;
            }

            else if (i == 0 && array[i] > array[i + 1])
            {
                Console.WriteLine("The number at position K is bigger than its neighbor: {0} ", array[i]);
                noResult = false; //The same..
                break;
            }

            else if (array[array.Length - 1] > array[array.Length - 2])
            {
                Console.WriteLine("The number at position K is bigger than its neighbor: {0} ", array[array.Length - 1]);
                noResult = false; //The same..
                break;
            }
        }

        if (noResult == true) //The bool is false if there is no number which is greater than its neighbors.
        {
            Console.WriteLine("Result: -1.");
        }
    }

    static void Main()
    {
        int[] array = { 1, 5, 5, 2, 1, 1, 111, 1, 3, 4, 4, 1};

        FindNumber(array);
    }
}
