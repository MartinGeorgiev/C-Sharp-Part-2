/*Write a program that creates an array containing all letters from the alphabet (A-Z).
 * Read a word from the console and print the index of each of its letters in the array.*/

using System;

class LettersInWord
{
    static void Main()
    {
        char[] arr = new char[52]; //Allocating new array of elements.

        for (int i = 0, y = 0, z=0; z <= 51;z++) //Initializing the elements of array ==> {A, a, B, b .... to Z, z}
        {
            if (z % 2 == 0)
            {
                arr[z] = (char)(i + 65); // The letter "A" is 65th element in ASCII table.
                i++;
            }
            else
            {
                arr[z] = (char)(y + 97); //The letter "a" is 97th element in ASCII table.
                y++;
            }
        }

        Console.Write("Please enter a word: ");
        string word = Console.ReadLine(); //Inputting the word.

        char[] charArray = word.ToCharArray(); //Converting the string to char array. Ex: Word ==> {w, o, r, d}
        int charArrayLenght = charArray.Length;

        for (int i = 0; i < charArrayLenght; i++) //Searching for the index of each letter, constructing the word.
        {
            for (int z = 0; z <= 51; z++)
            {
                if (charArray[i] == arr[z])
                {
                    Console.WriteLine("Letter[{2}]: {0} - Possition: {1}", charArray[i], z, i); //Printing the result.
                }
            }
        }
    }
}
