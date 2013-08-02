//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

using System;

class Matrix
{
    static void Main()
    {
        Console.Write("Please enter number N: ");
        int n = Convert.ToInt16(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int z = 1; //Will be the value of each number in the matrix.

        for (int row = 0; row < n; row++) //Printing each row in the matrix.
        {
            z = row + 1;

            for (int col = 0; col < n; col++) //Filling in each row with elements.
            {    
                matrix[row, col] = z;
                z = z + n; //The value of the next number in matrix.
                Console.Write("{0, 4}", matrix[row, col] + " ");
            }
            Console.WriteLine(); //Moving to the next row;
        }
    }
}