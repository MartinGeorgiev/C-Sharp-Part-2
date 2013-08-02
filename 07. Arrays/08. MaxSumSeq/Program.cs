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
        int result = 0;
        int resultElement = 0;
        int z = 0;

        for (int i = 0; i < arrLenght; i++)
        {
            Console.Write("Element[{0}]: ", i);
            int arrElement = Convert.ToInt32(Console.ReadLine());
            arr[i] = arrElement;
        }

        for (int i = 0; i <= arrLenght - K; i++)
        {
            for (int y = 0; y < K; y++)
            {
                sum = sum + arr[y + z];
            }
            if (sum > result)
            {
                result = sum;
                resultElement = i;
            }
            sum = 0;
            z++;
        }
      
        Console.Write("Result: {");

        for (int i = resultElement; i < resultElement + K; i++)
        {
            Console.Write(arr[i]);
            if (i + 1 < resultElement + K)
            {
                Console.Write(",");
            }
        }
        Console.Write("} = " + result );
        Console.WriteLine();
    }
   
}
