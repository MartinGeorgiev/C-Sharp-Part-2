/*Write a program that allocates array of 20 integers and initializes
 * each element by its index multiplied by 5. Print the obtained array 
 * on the console.*/

using System;

class ArraySequence
{
    static void Main()
    {
        int[] intArray = new int[20]; //Allocating - array of 20 integers;

        for (int i = 0; i <= 19; i++) 
        {
            intArray[i] = i * 5; //Calculating each element of array;
            Console.WriteLine("Element[{0}]: {1}",i, intArray[i]); //Printing each element of array;
        }
    }
}