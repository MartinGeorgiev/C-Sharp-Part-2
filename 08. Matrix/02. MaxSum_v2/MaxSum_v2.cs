/*Write a program that reads a rectangular matrix of size N x M and 
finds in it the square 3 x 3 that has maximal sum of its elements.*/


using System;

class MaxSum
{
    static void Main()
    {
        int[,] matrix =             //The matrix.
        {
                {1, 2, 5, 6, 7, 9},
                {1, 2, 5, 3, 7, 9},
                {5, 2, 5, 6, 1, 9},
                {1, 11, 5, 6, 17, 9},
                {1, 2, 15, 16, 7, 9},
                {1, 21, 5, 3, 7, 9},
        };

        int sum = 0;
        int maxSum = 0;

        for (int i = 0; i <= 3; i++)
        {
            for (int y = 0; y <= 3; y++) //Calculating the sum of nine elements --> 3x3.
            {
                sum = matrix[i, y] + matrix[i, y + 1] + matrix[i, y + 2] +
                    matrix[i + 1, y] + matrix[i + 1, y + 1] + matrix[i + 1, y + 2] +
                    matrix[i + 2, y] + matrix[i + 2, y + 1] + matrix[i + 2, y + 2];

                if (sum > maxSum)
                {
                    maxSum = sum; //Searching for the max sum.
                }
                else
                {
                    sum = int.MinValue;
                }
            }
        }
        Console.WriteLine("Result:{0}", maxSum); //Printing the result.
    }
}