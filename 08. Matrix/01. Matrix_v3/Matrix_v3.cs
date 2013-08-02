//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

using System;

class Matrix
{
    static void Main()
    {
        Console.Write("Please enter number N: ");
        int n = Convert.ToInt16(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int z = 1; //Will be each number in the matrix.

        for (int col = 0; col < n; col++)
        {
            if (col == 0) //Filling first col with with numbers.
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = z;
                    z++;
                }
                z--;
            }
            else
            {
                if (col % 2 != 0) //Filling in each prime column with numbers. 
                {
                    z = z  + n;

                    for (int row = 0; row < n; row++) 
                    {
                        matrix[row, col] = z; 
                        z--;
                    }
                }

                else //Filling in each even column with numbers.
                {
                    z = z + n + 1;
                    for (int row = 0; row < n; row++)
                    {
                        matrix[row, col] = z;
                        z++;
                    }
                    z--;
                }
            }

        }

        for (int row = 0; row < n; row++) //Printing the matrix on the console.
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0, 4}", matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}