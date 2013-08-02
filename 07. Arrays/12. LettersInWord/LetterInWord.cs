/*Write a program that creates an array containing all letters from the alphabet (A-Z).
 * Read a word from the console and print the index of each of its letters in the array.*/

using System;

class LettersInWord
{
    static void Main()
    {
        char[] arr = new char[26]; //Allocating new array.

        for (int i = 0; i <= 25; i++) //Initializing the elements of array {A ... to ... Z}. 
        {
            arr[i] = (char)(i + 65); // The Letter "A" is 65th element in ASCII table.
        }


        Console.Write("Please enter a word: ");
        string word = Console.ReadLine(); //Inputting the word.
        string wordUpper = word.ToUpper(); //

        char[] charArray = wordUpper.ToCharArray(); //Converting the string to char array. Ex: Word ==> {w, o, r, d}
        int charArrayLenght = charArray.Length;

        Console.WriteLine("Result - letter`s position in array:");

        for (int i = 0; i < charArrayLenght; i++) //Searching for index of each letter, constructing the word.
        {
            for (int z = 0; z <= 25; z++)
            {
                if (charArray[i] == arr[z])
                {
                    Console.WriteLine("Letter[{2}]: {0} - Possition: {1}", charArray[i], z,i); //Printing the result.
                }
            }
        }
    }
}
