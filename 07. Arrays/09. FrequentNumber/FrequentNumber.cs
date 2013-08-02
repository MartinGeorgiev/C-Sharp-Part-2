/*Write a program that finds the most frequent number in an array. Example:
	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)*/

using System;

class FrequentNumber
{
    static void Main()
    {
        Console.Write("Please enter - Array`s Lenght: ");
        int arrLenght = Convert.ToInt32(Console.ReadLine());

        bool rightInput = true; // If the input is wrong, there will be an error.

        if (arrLenght <= 0)
        {
            rightInput = false;
        }

        if (rightInput == true)
        {

            int[] myArr = new int[arrLenght]; //Allocating new array.

            for (int i = 0; i < arrLenght; i++) //Initializing the elements of the array.
            {
                Console.Write("Element[{0}]:", i);
                int myArrElement = Convert.ToInt32(Console.ReadLine());
                myArr[i] = myArrElement;
            }

            Array.Sort(myArr); //Sorting the elements. The smallest element is on first position. The biggest element is on last position. The equal elements are one after other.

            int frequentElement = 0; //Value of the most frequent element in the array.
            int currentSequence = 1; //Number of current equal elements in array.
            int maxSequence = 1; // Number of maximum equal elements in array.

            if (arrLenght == 1) //IF there is only one element in array, it is most frequent element in that array.
            {
                frequentElement = myArr[0];
                Console.WriteLine("Result:{0}{2}{1}", "{", "}", frequentElement);
            }

            if (arrLenght > 1)
            {
                for (int i = 0; i < arrLenght - 1; i++)
                {
                    if (myArr[i] == myArr[i + 1]) //Looking if the element [i] is equal to the next element in array.
                    {
                        currentSequence++;
                    }

                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence; //Serching for the max sequence of equal elements in array.
                        frequentElement = myArr[i];
                    }

                    if (myArr[i] != myArr[i + 1]) //If the element[i] is not equal to the next number, reseting current counter.
                    {
                        currentSequence = 1;
                    }
                }

                if (maxSequence == 1) //If there is no equaln elements in array.
                {
                    Console.WriteLine("There is no frequent element in array.");
                }
                else
                {
                    Console.WriteLine("Most frequent number - Result: {0} ({1} times)", frequentElement, maxSequence);
                }
            }
        }

        else
        {
            Console.WriteLine("Numbers you have wrote, are not valid. You should enter N and K again.");
            Main();
        }
    }
}
