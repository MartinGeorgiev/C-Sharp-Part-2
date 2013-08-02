/*Write a program that finds in given array of integers a sequence of given sum S (if present). 
 * Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5} */

using System;

class SumInArray
{
    static void Main()
    {
        Console.Write("Array`s Lenght: ");
        int N = Convert.ToInt32(Console.ReadLine());
        int arrLenght = N;

        Console.Write("Searched sum: ");
        int searchedSum = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[arrLenght];

        int currentSum = 0; //Current sum of some elements.
        int startElement = 0; //From this element starts the sequence of elements with max sum
        int elementLenght = 0; //Number of elements which have max sum.
        int K = 2; //Number of elements which we calculating. K=3 ==> element[i] + element [i+1] + element[i+2]
        int counter = 0;

        for (int i = 0; i < arrLenght; i++)
        {
            Console.Write("Element[{0}]: ", i); //Initializing the elements of array.
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

                if (currentSum  == searchedSum)
                {
                    startElement = i; 
                    elementLenght = K;
                    counter++; 

                    Console.Write("Result: {");

                    for (int i2 = startElement; i2 < startElement + elementLenght; i2++) //Printing the element, starting from "startElement".
                    {
                        Console.Write(arr[i2]);
                        if (i2 + 1 < startElement + elementLenght)
                        {
                            Console.Write(",");
                        }
                    }
                    Console.Write("} = " + currentSum);
                    Console.WriteLine();
                }
                currentSum = 0;
                z++;
            }
            K++;
            z = 0;
        }
        if (counter == 0)
        {
            Console.WriteLine("There is no result.");
        }
    }
}
	
