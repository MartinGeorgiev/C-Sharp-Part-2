/*Write a method that returns the last digit of given integer as an English word. 
Examples: 512 ? "two", 1024 ? "four", 12309 ? "nine".*/

using System;

class LastDigit
{
	static void ReturnLastDigit(int lastDigit)
	{
		string digitString;

		switch(lastDigit) //Converting the last digit in a word.
		{
			case 1: digitString = "One"; break;
			case 2: digitString = "Two"; break;
			case 3: digitString = "Three"; break;
			case 4: digitString = "Four"; break;
			case 5: digitString = "Five"; break;
			case 6: digitString = "Six"; break;
			case 7: digitString = "Seven"; break;
			case 8: digitString = "Eight"; break;
			case 9: digitString = "Nine"; break;
			case 0: digitString = "Zero"; break;
			default: digitString = ""; break;		
		}
		
		Console.WriteLine("The letter corresponding to the last digit of the number: {0}", digitString);
	}

	static void Main()
	{
		Console.Write("Please enter the number: ");
		int number = Convert.ToInt32(Console.ReadLine());

        int lastDigit = number % 10; //Determining the last digit of the number.

		ReturnLastDigit(lastDigit);
	}
}