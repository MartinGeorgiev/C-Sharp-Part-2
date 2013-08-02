/*Write a program that reads two arrays from the 
 * console and compares them element by element.*/

using System;

class CompareArrays
{
    static void Main()
    {
      
        bool areEqual = true;

        Console.Write("Please enter - First array`s Lenght: ");    
        int firstArrayLenght = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter - Second array`s Lenght: ");
        int secondArrayLenght = Convert.ToInt32(Console.ReadLine());

        bool rightInput = true;

        if (firstArrayLenght <= 0 || secondArrayLenght <= 0) // The array`s lenght must be number greater than 0.
        {
            rightInput = false;
        }

        if (rightInput == true)
        {

            Console.WriteLine();

            if (firstArrayLenght != secondArrayLenght) //Two array are not equal if the first array`s lenght != second array`s lenght.
            {
                Console.WriteLine("Two arrays are NOT equal.");
            }

            else //First array`s lenght == second array`s lenght. 
            {

                int[] firstArray = new int[firstArrayLenght];
                int[] secondArray = new int[secondArrayLenght];

                int arrayLenght = firstArrayLenght;

                Console.WriteLine("Please enter - First array - numbers: ");

                for (int i = 0; i < arrayLenght; i++) //Initializing the elements of first array.
                {
                    Console.Write("Element[{0}]: ", i);
                    firstArray[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine();

                Console.WriteLine("Please enter - Second array - numbers: ");

                for (int i = 0; i < arrayLenght; i++) //Initializing the elements of second array.
                {
                    Console.Write("Element[{0}]: ", i);
                    secondArray[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine();

                Console.WriteLine("Arrays comparing result - true/false: ");
                for (int i = 0; i < arrayLenght; i++)
                {
                    bool result = (firstArray[i] == secondArray[i]); //Comparing the elements of first and second array - position i.

                    if (result == false) //If the element[i] of first array != element[i] of second array, then result is false ==> areEqual == false.
                    {
                        areEqual = false;
                    }
                    Console.WriteLine("Element[{0}]: {1}", i, result);
                }

                Console.WriteLine();

                if (areEqual == true) //Printing the result.
                {
                    Console.WriteLine("Result: Two arrays are equal.");
                }
                else
                {
                    Console.WriteLine("Result: Two arrays are NOT equal.");
                }
            }
        }
        else
        {
            Console.WriteLine("Numbers you have wrote, are not valid. You should enter the number again.");
            Main();
        }
    }
}
