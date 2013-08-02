/*Write a program that creates an array containing all letters from the alphabet (A-Z).
 * Read a word from the console and print the index of each of its letters in the array.*/

using System;
class LettersInWord
{
    static void Main()
    {
        char[] arr = new char[52];

        for (int i = 0, y = 0, z=0; z <= 51;z++)
        {
            if (z % 2 == 0)
            {
                arr[z] = (char)(i + 65);
                i++;
            }
            else
            {
                arr[z] = (char)(y + 97);
                y++;
            }
        }

        Console.WriteLine("Please enter a word: ");
        string word = Console.ReadLine();
   
        char[] charArray = word.ToCharArray();
        int charArrayLenght = charArray.Length;

        for (int i = 0; i < charArrayLenght; i++)
        {
            for (int z = 0; z <= 51; z++)
            {
                if (charArray[i] == arr[z])
                {
                    Console.WriteLine("Letter[{2}]: {0} - Possition: {1}", charArray[i], z, i);
                }
            }
        }
    }
}
