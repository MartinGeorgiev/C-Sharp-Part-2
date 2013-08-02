/*Write a program that finds the sequence of maximal sum in given array. Example:
	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
	Can you do it with only one loop (with single scan through the elements of the array)?*/


using System;

class MaxSumSequence
{
    static void Main()
    {
        Console.Write("Please enter - Array`s Lenght: ");
        int arrLenght = Convert.ToInt32(Console.ReadLine());

        bool rightInput = true;

        if (arrLenght <= 0)
        {
            rightInput = false;
        }

        if (rightInput == true)
        {
            int[] arr = new int[arrLenght];

            int currentSum = 0; //Current sum of some elements.
            int maxSum = 0;     //Max sum of elements.

            int startElement = 0; //From this element starts the sequence of elements with max sum.
            
            int elementLenght = 0; //Number of elements which have max sum.

            int K = 2; //Number of elements which we calculating. K=3 ==> element[i] + element [i+1] + element[i+2]

            for (int i = 0; i < arrLenght; i++) //Initializing the elements of array.
            {
                Console.Write("Element[{0}]: ", i);
                int arrElement = Convert.ToInt32(Console.ReadLine());
                arr[i] = arrElement;
            }

            for (int x = 0; arrLenght >= K; x++)
            {
                int z = 0; 

                for (int i = 0; i <= arrLenght - K; i++)
                {
                    for (int y = 0; y < K; y++)
                    {
                        currentSum = currentSum + arr[y + z];
                    }
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum; //Searching for the max sum.
                        startElement = i;
                        elementLenght = K;
                    }
                    currentSum = 0; //Reset currentSum;
                    z++;
                }
                K++; //
                z = 0;
            }

            Console.Write("Maximum sum: {");

            for (int i = startElement; i < startElement + elementLenght; i++) //Printing the element, starting from "startElement".
            {
                Console.Write(arr[i]);
                if (i + 1 < startElement + elementLenght)
                {
                    Console.Write(",");
                }
            }
            Console.Write("} = " + maxSum);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Number you have wrote, is not valid. You should enter the number again.");
            Main();
        }
    }
}

