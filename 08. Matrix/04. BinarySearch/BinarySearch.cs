using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter a number K: ");
        int k = Convert.ToInt32(Console.ReadLine());

        int[] array = { 1, 6, 10, 5, -10, 76, 16, 1, 67, 4 }; //The matrix

        Array.Sort(array);
        int position = Array.BinarySearch(array, k); //Searching for the number.
        if (position < 0)
        {
            position = ~position - 1;
        }
        if (position < 0)
        {
            Console.WriteLine("No such number.");
        }
        else
        {
            Console.WriteLine("Result: {0}", array[position]);
        }
    }
}

