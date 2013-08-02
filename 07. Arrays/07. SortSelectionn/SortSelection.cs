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

        Console.Write("Array`s Lenght: ");
        int arrLenght = Convert.ToInt32(Console.ReadLine());

        bool rightInput = true; // There will be an error if input is wrong.

        if (arrLenght <= 0)
        {
            rightInput = false;
        }

        if (rightInput == true)
        {
            int[] myArr = new int[arrLenght]; //Allocating a new array.

            for (int i = 0; i < arrLenght; i++) //Initializing the element of array.
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
                        minValue = myArr[i]; //Finding the minimum value of array`s element.
                        temp = myArr[y]; // Keeping the minimal element value;
                        myArr[y] = myArr[i]; // Moving the minimal value to firstPosition of array.
                        myArr[i] = temp; //Moving the current element to minimal value previous position in array.
                    }
                }
                minValue = Int32.MaxValue; //Reset
            }

            Console.WriteLine();
            Console.WriteLine("Result after sorting: ");
            
            for (int i = 0; i < arrLenght; i++) //Printing the result.
            {
                Console.WriteLine("ELement[{0}]: {1}", i, myArr[i]);
            }
        }

        else
        {
            Console.WriteLine("Number you have wrote, is not valid. You should enter the number again.");
            Main();
        }
    }
}