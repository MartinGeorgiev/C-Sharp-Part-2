/*Write a program that reads two numbers N and K and generates all the variations of
 * K elements from the set [1..N]. Example:
	N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}*/

using System;

class Variationss
{
    static void Main()
    {
        Console.Write("Please enter number N: ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Please enter number K: ");
        int K = int.Parse(Console.ReadLine());
   
        int[] variations = new int[K];
        Variations(variations, 0, N);
    }

    static void Variations(int[] array, int index, int N) //Generating all variations.
    {
        if (index == array.Length)
        {
            PrintArray(array);
        }
        else
        {
            for (int i = 1; i <= N; i++)
            {
                array[index] = i;
                Variations(array, index + 1, N);
            }
        }
    }

    static void PrintArray(int[] array)  //Printing the result.
    {
        Console.Write("{");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i <= array.Length - 2)
            {
                Console.Write(",");
            }
        }
        Console.Write("}");
        Console.WriteLine();
    }
}