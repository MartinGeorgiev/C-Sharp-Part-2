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

        Console.Write("Please enter - Array`s Lenght: ");
        int arrLenght = Convert.ToInt32(Console.ReadLine());

        if (arrLenght <= 0) // Array`s lenght must be positive integer.
        {
            Console.WriteLine("Array`s lenght must be positive interer.");
            Main();
        }

        int[] myArr = new int[arrLenght];

        for (int i = 0; i < arrLenght; i++) //Initializing the elements of array.
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
                    minValue = myArr[i]; //Finding element of array with minimal value, and put it on first position etc.
                    temp = myArr[y];
                    myArr[y] = myArr[i]; //Changing position - element with min value goes to the first position of array. First position element goes to minimal value element previous position.
                    myArr[i] = temp;
                }
            }
            minValue = Int32.MaxValue;
        }

        Console.WriteLine("Result after sorting: "); 

        for (int i = 0; i < arrLenght; i++) //Printing the result.
        {
            Console.WriteLine("Element[{0}]: {1}", i, myArr[i]);
        }
    }
}