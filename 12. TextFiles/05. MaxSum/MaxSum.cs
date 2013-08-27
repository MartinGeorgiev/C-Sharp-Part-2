/*Write a program that reads a text file containing a square 
 * matrix of numbers and finds in the matrix an area of size 
 * 2 x 2 with a maximal sum of its elements. The first line
 * in the input file contains the size of matrix N. Each of 
 * the next N lines contain N numbers separated by space. 
 * The output should be a single number in a separate text file. */

using System;
using System.IO;

class MaxSum
{
    static void Main()
    {
        int[,] matrix = new int[0,0];

         using(StreamReader reader = new StreamReader(@"input.txt"))
         {
             int n = Convert.ToInt16(reader.ReadLine());
             matrix = new int[n, n];
             string line = "";

             for (int i = 0; i < n; i++)
             {
                 line = reader.ReadLine();
                 string[] matrixString = line.Split(' ');

                 for (int y = 0; y < n; y++)
                 {
                     matrix[i, y] = Convert.ToInt16(matrixString[y]);
                 }
             }
         }

         int sum = 0;
         int maxSum = 0;

         for (int i = 0; i <= 2; i++)
         {
             for (int y = 0; y <= 2; y++) //Calculating the sum of nine elements --> 2x2.
             {
                 sum = matrix[i, y] + matrix[i, y + 1] + matrix[i + 1, y] + matrix[i + 1, y + 1];
                    
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

         using (StreamWriter writer = new StreamWriter("result.txt"))
         {
             writer.WriteLine(maxSum);
         }

         Console.WriteLine("Done!");
    }
}
