/*Write a program that finds the sequence of maximal sum in given array. Example:
	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
	Can you do it with only one loop (with single scan through the elements of the array)?*/

/*Write a program that reads two integer numbers N and K and
 * an array of N elements from the console. Find in the array those K 
 * elements that have maximal sum.*/

using System;

class MaxSumSequence
{
    static void Main()
    {
        Console.Write("Array Lenght: ");
        int N = Convert.ToInt32(Console.ReadLine());
        int arrLenght = N;

        int K = 2;

        int[] arr = new int[arrLenght];
        int sum = 0;
        int result = 0;
        int resultElement = 0;
        int z = 0;
        int resultElementK = 0;

        for (int i = 0; i < arrLenght; i++)
        {
            Console.Write("Element[{0}]: ", i);
            int arrElement = Convert.ToInt32(Console.ReadLine());
            arr[i] = arrElement;
        }

        for (int x = 0; arrLenght >= K; x++)
        {
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
                    resultElementK = K;
                }
                sum = 0;
                z++;
            }
            K++;
            z = 0;
        }

        Console.Write("Result: {");

        for (int i = resultElement; i < resultElement + resultElementK; i++)
        {
            Console.Write(arr[i]);
            if (i + 1 < resultElement + resultElementK)
            {
                Console.Write(",");
            }
        }
        Console.Write("} = " + result);
        Console.WriteLine();
    }

}
