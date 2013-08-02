using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Please enter - Array`s Lenght: ");
        int arrLenght = Convert.ToInt32(Console.ReadLine());

        bool rightInput = true; //If the input is wrong, there will be an error.

        if (arrLenght <= 0) // The Array`s lenght must be number greater than 0.
        {
            rightInput = false;
        }

        if (rightInput == true)
        {
            int[] array = new int[arrLenght];

            for (int i = 0; i < arrLenght; i++) //Initializing the elements of array.
            {
                Console.Write("Element[{0}]:", i);
                int myArrElement = Convert.ToInt32(Console.ReadLine());
                array[i] = myArrElement;
            }

            Array.Sort(array);

            Console.Write("Please enter a number - the searched: ");
            int searchedNumber = int.Parse(Console.ReadLine());
            int startSearch = 0;
            int endSearch = array.Length - 1;
            int middle;

            while (startSearch <= endSearch)
            {
                middle = (startSearch + endSearch) / 2;

                if (array[middle] == searchedNumber)
                {
                    Console.WriteLine("Index is: {0}.", middle);
                    break;
                }

                if (array[middle] < searchedNumber)
                {
                    startSearch = middle + 1;
                }

                if (array[middle] > searchedNumber)
                {
                    endSearch = middle - 1;
                }
            }
        }
    }
}
