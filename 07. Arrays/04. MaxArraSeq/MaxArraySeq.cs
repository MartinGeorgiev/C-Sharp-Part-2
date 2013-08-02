/*Write a program that finds the maximal sequence of equal elements in an array.
		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.*/

using System;

class MaxArraySum
{
    static void Main()
    {
        Console.Write("Please enter - Array`s Lenght: ");
        int arrLenght = Convert.ToInt32(Console.ReadLine());

        bool rightInput = true; //If the input is wrong, there will be an error.

        if (arrLenght <= 0) // The lenght of array must be number greater than 0.
        {
            rightInput = false;
        }

        if (rightInput == true)
        {

            int[] myArr = new int[arrLenght];

            for (int i = 0; i < arrLenght; i++) //Initializing the elements of array.
            {
                Console.Write("Element[{0}]:", i);
                int myArrElement = Convert.ToInt32(Console.ReadLine());
                myArr[i] = myArrElement;
            }

            int arrElement = 0; //Index of array, from which starts the sequence of same array`s element.
            int sameElementSeq = 1; //Number of Current equal elements in sequense. 
            int maxSameElementSeq = 1; //Number of Maximum equal elements in sequence.

            if (arrLenght == 1) //If there is only one element in the array, its maximal sequence of equal elements is the element.
            {
                arrElement = myArr[0];
            }

            if (arrLenght > 1)
            {
                for (int i = 0; i < arrLenght - 1; i++)
                {
                    if (myArr[i] == myArr[i + 1]) //Checking if the element[i] is equal to the next element of array.
                    {
                        sameElementSeq++; //If it is the same, add 1 to current sequence of equal elements.
                    }

                    if (sameElementSeq > maxSameElementSeq)
                    {
                        maxSameElementSeq = sameElementSeq; //Searching for the maximal sequence of equal elements.
                        arrElement = myArr[i]; //Searching for equal elements.
                    }

                    if (myArr[i] != myArr[i + 1])
                    {
                        sameElementSeq = 1; //Reset current sequence value, if the element[i] of first array != element[i] of second array.
                    }
                }
            }

            if (maxSameElementSeq == 1 && arrLenght > 1) //If the maximal sequence of equal element is 1.
            {
                Console.WriteLine("There is no maximal sequence of equal elements.");
            }

            else
            {
                Console.Write("Maximal sequence of same elements. Result: {");

                for (int i = 0; i < maxSameElementSeq; i++) //Printing n-times /maxSameElementSeq/ the equal array element.
                {
                    Console.Write(arrElement);
                    if (i + 1 < maxSameElementSeq)
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
