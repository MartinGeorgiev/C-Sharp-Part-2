//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

using System;

class Matrix
{
    static void Main()
    {
        Console.Write("Please enter number N: ");
        int n = Convert.ToInt16(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int z = 1;

        int row, col;

        int diagonalValue = diagonalValue = ((n * n) + 1) / 2 - n / 2; //Calculating the numbers of longest diagonal.

        if (n % 2 == 0)
        {
            diagonalValue = diagonalValue + 1;
        }

        for (int i = 0; i < n; i++)
        {
            matrix[i, i] = diagonalValue;
            diagonalValue++;
        }
        z = diagonalValue;

        for (int i = 0; i < n - 1; i++)
        {
            row = 0;
            col = i + 1;

            for (int y = 0; y + i < n - 1; y++)
            {
                matrix[row, col] = z;
                z++;
                row++;
                col++;
            }
        }
        
        int secondDiagonal = ((n * n) + 1) / 2 - n / 2;

        for (int i = 0; i < n - 1; i++)
        {
            row = n - 1;
            col = n - i - 2;

            for (int y = 0; y + i < n - 1; y++)
            {

                if (n % 2 == 0)
                {

                    matrix[row, col] = secondDiagonal;
                    secondDiagonal--;
                    row--;
                    col--;
                }

                if (n % 2 != 0)
                {
                    secondDiagonal--;
                    matrix[row, col] = secondDiagonal;
                    row--;
                    col--;
                }

            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int y = 0; y < n; y++)
            {
                Console.Write("{0, 4}", matrix[i, y] + " ");
            }
            Console.WriteLine();
        }
        
    }
}