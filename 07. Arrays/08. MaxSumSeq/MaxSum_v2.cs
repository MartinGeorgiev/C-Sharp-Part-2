/*Write a program that reads two integer numbers N and K and
 * an array of N elements from the console. Find in the array those K 
 * elements that have maximal sum.*/

using System;

class MaxSum
{
    static void Main()
    {
        Console.Write("Please enter N - Array`s Lenght: ");
        int N = Convert.ToInt32(Console.ReadLine());
        int arrLenght = N;

        Console.Write("Please enter - K: ");
        int K = Convert.ToInt32(Console.ReadLine());

        bool rightInput = true;

        if (K < 0 || N < 0) //N and K must be positive numbers.
        {
            rightInput = false;
        }

        if (N < K)
        {
            rightInput = false;
        }

        if (rightInput == true)
        {
            int[] arr = new int[arrLenght];
            int sum = 0;    //Sum of K elements. 
            int result = Int32.MinValue; //Max sum of K elements;
            int firstElement = 0; //Will be the first element of founded max sequence.
            int z = 0; //index;

            for (int i = 0; i < arrLenght; i++) //Initializing elements of array.
            {
                Console.Write("Element[{0}]: ", i);
                int arrElement = Convert.ToInt32(Console.ReadLine());
                arr[i] = arrElement;
            }

            for (int i = 0; i <= arrLenght - K; i++)
            {
                for (int y = 0; y < K; y++)
                {
                    sum = sum + arr[y + z]; //Searching for the maximal sum of K  element/
                }
                if (sum > result)
                {
                    result = sum;
                    firstElement = i; //Finding the first element of array, from which starts max sum sequence.
                }
                sum = 0; //Reset the current sum ot element.
                z++;
            }

            Console.Write("Result: {");

            for (int i = firstElement; i < firstElement + K; i++) //Printing the result.
            {
                Console.Write(arr[i]); //Printing K elements, starting from firstElement. 
                if (i + 1 < firstElement + K)
                {
                    Console.Write(",");
                }
            }
            Console.Write("} = " + result);
            Console.WriteLine();
        }

        else
        {
            Console.WriteLine("Numbers you have wrote, are not valid. You should enter N and K again.");
            Main();
        }
    }
}