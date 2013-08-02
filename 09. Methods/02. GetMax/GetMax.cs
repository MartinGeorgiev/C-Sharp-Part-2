/*Write a method GetMax() with two parameters that returns the bigger of two integers.
Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().*/

using System;

class PrintMaxNumber
{
	static void GetMax(int firstNumber, int thirdNumber)
	{
		int maxNumber = Math.Max(firstNumber, thirdNumber);  //Searching for the biggest number.
		Console.WriteLine("The biggest number is {0}", maxNumber);
	}

	static void Main() 
	{
		Console.Write("Please enter the first number: ");
		int firstNumber = Convert.ToInt32(Console.ReadLine());

		Console.Write("Please enter the second number: ");
		int secondNumber = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Please enter the third number: ");
		int thirdNumber = Convert.ToInt32(Console.ReadLine());

		if(firstNumber < secondNumber) //Searching for the bigger number.
			{
			firstNumber = secondNumber;
			}

		GetMax(firstNumber, thirdNumber);
	}
}