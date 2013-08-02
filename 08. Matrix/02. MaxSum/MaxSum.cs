/*Write a program that reads a rectangular matrix of size N x M and 
finds in it the square 3 x 3 that has maximal sum of its elements.*/

//Числата от матрицата се изписват на един ред, всички разделени с интервал.

using System;

class MaxSum
{
    static void Main()
    {
       Console.Write("Please enter the number of rows of the matrix: ");
        int row = Convert.ToInt16(Console.ReadLine());

        Console.Write("Please enter the number of cols of the matrix: ");
        int col = Convert.ToInt16(Console.ReadLine());

        int[,] matrix = new int[row, col];

        for (int i = 0; i < row; i++) //Filling in the matrix.
        {
            Console.Write("Elements of Row {0}: ", i);
            string[] arr = Console.ReadLine().Split(' ');

            for (int y = 0; y < arr.Length; y++)
            {
                matrix[i, y] = int.Parse(arr[y]);
            }
        }

        Console.WriteLine("The matrix: "); //Printing the matrix for better view.
        for (int i = 0; i < row; i++)
        {
            for (int y = 0; y < col; y++)
            {
                Console.Write("{0, 3}", matrix[i, y] + " ");
            }
            Console.WriteLine();
        } 

        int sum = 0;
        int maxSum = 0;

        for (int i = 0; i <= row - 3; i++) //Calculating the sum of 9 elements. 
        {
            for (int y = 0; y <= col - 3; y++)
            {
                sum = matrix[i, y] + matrix[i, y + 1] + matrix[i, y + 2] +
                    matrix[i + 1, y] + matrix[i + 1, y + 1] + matrix[i + 1, y + 2] +
                    matrix[i + 2, y] + matrix[i + 2, y + 1] + matrix[i + 2, y + 2];

                if (sum > maxSum)
                {
                    maxSum = sum; //Searching for the maximal sum.
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