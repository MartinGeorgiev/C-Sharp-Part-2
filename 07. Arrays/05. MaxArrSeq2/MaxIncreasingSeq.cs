//Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

using System;

class MaxIncreasingElements
{
    static void Main()
    {
        Console.Write("Please enter - Array`s Lenght: ");
        int arrLenght = Convert.ToInt32(Console.ReadLine());

        bool rightInput = true; //If the input is wrong, there will bi a fault.

        if (arrLenght <= 0) // The array`s lenght must be number greater than 0.
        {
            rightInput = false;
        }

        if (rightInput == true)
        {

            int[] myArr = new int[arrLenght];

            for (int i = 0; i < arrLenght; i++) //Initializing the array.
            {
                Console.Write("Element[{0}]:", i);
                int myArrElement = Convert.ToInt32(Console.ReadLine());
                myArr[i] = myArrElement;
            }

            int arrElement = 0; //Index of array, from which starts the sequence of increasing elements of array.
            int increasingElementSeq = 1; //Current increasing elements sequense. 
            int maxIncreasingElementSeq = 1; //Maximum increasing elements sequence.

            if (arrLenght > 1)
            {
                for (int i = arrLenght - 1; i > 0; i--)
                {
                    if (myArr[i] - myArr[i - 1] == 1) // Checking if the element[i]+1 = element[i+1]
                    {
                        increasingElementSeq++;
                    }

                    if (increasingElementSeq > maxIncreasingElementSeq)
                    {
                        maxIncreasingElementSeq = increasingElementSeq; //Searching for the maximal sequence of increasing elements.
                        arrElement = i - 1;
                    }
                    if (myArr[i] - myArr[i - 1] != 1)
                    {
                        increasingElementSeq = 1; //Reset current sequence value, if the element[i]  + != element[i + 1]
                    }
                }
            }

            if ((maxIncreasingElementSeq == 1 && arrLenght == 1) || (maxIncreasingElementSeq == 1 && arrLenght > 1))
            {
                Console.WriteLine("There is no maximal sequence ot increasing elements."); //If there is no increasing element sequence or array`s lenght is 1.
            }

            else
            {
                Console.Write("Maximal sequence of increasing elements. Result: {");

                for (int i = arrElement; i < arrElement + maxIncreasingElementSeq; i++)
                {
                    Console.Write(myArr[i]);
                    if (i < arrElement + maxIncreasingElementSeq - 1)
                    {
                        Console.Write(",");
                    }
                }
                Console.WriteLine("}");
            }
        }

        else
        {
            Console.WriteLine("Number you have wrote, is not valid. You should enter a number again.");
            Main();
        }
    }
}

        
    