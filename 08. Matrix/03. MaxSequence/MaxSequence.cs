/*We are given a matrix of strings of size N x M. 
 * Sequences in the matrix we define as sets of several neighbor elements
 * located on the same line, column or diagonal. Write a program that finds
 * the longest sequence of equal strings in the matrix. */

using System;

class MaxSequence
{
    static void Main()
    {
        Console.Write("Please enter the number of rows of the matrix: ");
        int row = Convert.ToInt16(Console.ReadLine());

        Console.Write("Please enter the number of cols of the matrix: ");
        int col = Convert.ToInt16(Console.ReadLine());

        string[,] matrix = new string[row, col];

        int maxLenght = 0; //Max lenght.
        int lenght = 1; //Counter for current lenght.
        string element = "";

        for (int i = 0; i < row; i++)   //Filling the matrix.
        {
            Console.Write("Elements of Row {0}: ", i); 
            string[] arr = Console.ReadLine().Split(' ');

            for (int y = 0; y < arr.Length; y++)
            {
                matrix[i, y] = arr[y];
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

        for (int i = 0; i < row; i++) //Seaching for a horizontal sequence.
        {
            for (int y = 0; y < col-1; y++)
            {
                if (matrix[i, y] == matrix[i, y + 1])
                {
                    lenght++;
                }

                if (lenght > maxLenght)
                {
                    maxLenght = lenght;
                    element = matrix[y, i];
                }
            }
            lenght = 1;
        }

        for (int i = 0; i < col; i++)  //Searching for a vertical sequence.
        {
            for (int y = 0; y < row - 1; y++)
            {
                if (matrix[y, i] == matrix[y + 1, i])
                {
                    lenght++;
                }

                if (lenght > maxLenght)
                {
                    maxLenght = lenght;
                    element = matrix[y, i];
                }
            }
            lenght = 1;
        }

        for (int i = 0; i < col-1; i++)  //Searching for a diagonal sequence.
        {
            for (int y = 0; y < row - 1; y++)
            {
                if (matrix[y, i] == matrix[y + 1, i + 1])
                {
                    lenght++;
                }

                if (lenght > maxLenght)
                {
                    maxLenght = lenght;
                    element = matrix[y, i];
                }
            }
            lenght = 1;
        }

        Console.WriteLine("Result - max lenght: {0}", maxLenght); //Printing the result.
        Console.WriteLine("Result - element is {0}", element); //Printing the element.
    }
}