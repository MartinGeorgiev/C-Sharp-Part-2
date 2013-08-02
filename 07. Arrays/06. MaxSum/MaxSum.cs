/*Write a program that reads two integer numbers N and K and
 * an array of N elements from the console. Find in the array those K 
 * elements that have maximal sum.*/

using System;

class MaxSum
{
    static void Main()
    {
        Console.Write("Please enter - Array`s Lenght: ");
        int N = Convert.ToInt32(Console.ReadLine());
        int arrLenght = N;

        Console.Write("Please enter - K: ");
        int K = Convert.ToInt32(Console.ReadLine());

        bool rightInput = true;

        if (K < 0 || N < 0) //N and K must be positive numbers.
        {
            rightInput = false;
        }

        if (N < K) // K can not be > than the array`s lenght.
        {
            rightInput = false;
        }

        if (rightInput == true)
        {

            int[] arr = new int[arrLenght];
            int sum = 0;

            for (int i = 0; i < arrLenght; i++) //Initializing the elements of array.
            {
                Console.Write("Element[{0}]: ", i);
                int arrElement = Convert.ToInt32(Console.ReadLine());
                arr[i] = arrElement;
            }

            Array.Sort(arr); //Sorting the array`s element. The last element has biggest value, after sorting.

            for (int i = N - 1; i >= N - K; i--) // Sum the K biggest element of array,starting from last one.
            {
                sum = arr[i] + sum;
            }

            Console.Write("Result: {");

            for (int i = N - 1; i >= N - K; i--) //Printing the result.
            {
                Console.Write(arr[i]);
                if (i > N - K) //Printing biggest K element from sorted array. They have max sum.
                {
                    Console.Write(",");
                }
            }
            Console.Write("} = " + sum); // Printing sum of K biggest array`s element.
            Console.WriteLine();
        }

        else
        {
            Console.WriteLine("Numbers you have wrote, are not valid. You should enter N and K again.");
            Main();
        }
    }
}
