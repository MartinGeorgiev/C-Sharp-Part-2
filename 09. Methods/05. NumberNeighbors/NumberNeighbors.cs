/*Write a method that checks if the element at given position 
 * in given array of integers is bigger than its two neighbors 
 * (when such exist).*/

using System;

class NumberNeighbors
{
    static void FindNumber(int k, int[] array)
    {
        if ((k > 0 && array.Length > k) && (array[k] > array[k + 1] && array[k] > array[k - 1])) //Searching if element[I] is greater than its neighbors.
        {
            Console.WriteLine("The number at position K is bigger than its two neighbors.");
        }

        else if (k == 0 && array[k] > array[k + 1])
        {
            Console.WriteLine("The number at position K is bigger than its neighbor.");
        }

        else if (k == array.Length && array[k] > array[k - 1])
        {
            Console.WriteLine("The number at position K is bigger than its neighbor.");
        }

        else
        {
            Console.WriteLine("The number is not greater than its neighbor/s.");
        }
    }

    static void Main() 
    {
        Console.Write("Please enter the number K - position in array: "); //The user enters a number-the element position.
        int k = Convert.ToInt32(Console.ReadLine());

        int[] array = { 1, 5, 123, 5, 222, 3, 55, 6, 78, 10, 689, 65, 
                          3, 4, 5, 6, 3, 4, 555, 34, 345, 3453 };

        int lenght = array.Length;

        while (k >= lenght)
        {
            Console.Write("Please enter again the number K - position in array: ");
            
            k = Convert.ToInt32(Console.ReadLine());
        }

        FindNumber(k, array);
    }
}