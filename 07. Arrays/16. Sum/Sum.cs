/* * We are given an array of integers and a number S.
 * Write a program to find if there exists a subset of
 * the elements of the array that has a sum S. Example:
        arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)
 */

using System;

class SubSetSum
{
    static void Main()
    {
        Console.Write("Please enter the sum of the subsets:");
        int sum = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of elements:");
        int arrLenght = Convert.ToInt32(Console.ReadLine());

        bool rightInput = true; //If the input is wrong, there will be an error.

        if (arrLenght == 0)
        {
            rightInput = false;
        }

        if (rightInput == true)
        {

            int[] elements = new int[arrLenght];

            int counter = 0;
            string sumString = "";

            for (int i = 0; i < arrLenght; i++) //Initializing the elements of array.
            {
                Console.Write("Element[{0}]: ", i);
                elements[i] = Convert.ToInt32(Console.ReadLine());
            }

            int maxCombinations = (int)Math.Pow(2, arrLenght) - 1; //Finding the number of max combinations.

            for (int i = 1; i <= maxCombinations; i++) 
            {
                sumString = "";
                int checkSum = 0;

                for (int j = 0; j <= arrLenght; j++)
                {
                    int mask = 1 << j;
                    int numberAndMask = i & mask;
                    int bit = numberAndMask >> j;
                    if (bit == 1)
                    
                    { 
                        checkSum = checkSum + elements[j];
                        sumString = sumString + " " + elements[j]; //Creating string with subset numbers.
                    }
                }

                if (checkSum == sum)
                {
                    Console.WriteLine("Result - numbers that have sum of {0}", sum);
                    counter++;
                    Console.WriteLine("This subset has a sum of {0} : {1} ", sum, sumString);
                }
            }
        }
        else
        {
            Console.WriteLine("Number you have wrote, is not valid. You should enter the number again.");
            Main();
        }
    }
}