/*Write a program that reads two integer numbers N and K and
 * an array of N elements from the console. Find in the array those K 
 * elements that have maximal sum.*/

using System;

class MaxSum
{
    static void Main()
    {
        Console.Write("Array Lenght: ");
        int N = Convert.ToInt32(Console.ReadLine());
        int arrLenght = N;

        Console.Write("K: ");
        int K = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[arrLenght];
        int sum = 0;

        for (int i = 0; i < arrLenght; i++)
        {
            Console.Write("Element[{0}]: ", i);
            int arrElement = Convert.ToInt32(Console.ReadLine());
            arr[i] = arrElement;
        }

        Array.Sort(arr);

        for (int i = N-1; i >= N-K; i--)
        {
            sum = arr[i] + sum;
        }

        Console.Write("Result: {");

        for (int i = N-1; i >= N - K; i--)
        {
            Console.Write(arr[i]);
            if (i > N - K)
            {
                Console.Write(",");
            }
        }
        Console.Write("} = " +sum );
        Console.WriteLine();
    }
}
