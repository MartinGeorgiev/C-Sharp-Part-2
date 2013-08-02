/*Write a program that creates an array containing all letters from the alphabet (A-Z).
 * Read a word from the console and print the index of each of its letters in the array.*/

using System;
class LettersInWord
{
    static void Main()
    {
        char[] arr = new char[26];

        for (int i = 0; i <= 25; i++)
        {
            arr[i] = (char)(i + 65);
        }

        string word = Console.ReadLine();
        string wordUpper = word.ToUpper();

        char[] charArray = wordUpper.ToCharArray();
        int charArrayLenght = charArray.Length;

        for (int i = 0; i < charArrayLenght; i++)
        {
            for (int z = 0; z <= 25; z++)
            {
                if (charArray[i] == arr[z])
                {
                    Console.WriteLine("Letter[{2}]: {0} - Possition: {1}", charArray[i], z,i);
                }
            }
        }
    }
}
