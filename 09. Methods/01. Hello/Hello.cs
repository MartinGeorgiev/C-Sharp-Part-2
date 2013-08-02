/*Write a method that asks the user for his name and prints
 “Hello, <name>” (for example, “Hello, Peter!”). Write a program to test this method.*/

using System;

class PrintYourName
{
    static void PrintNames() //The user enters his first and last name.
    {
        Console.Write("Please enter your first name: ");
        string firstName = Console.ReadLine();

        Console.Write("Please enter your last name: ");
        string lastName = Console.ReadLine();

        Console.WriteLine("Hello, {0} {1}", firstName, lastName);

        Tests(firstName, lastName);
    }

    static void Tests(string firstName, string lastName) //Testing if the first and the last name contain only letters.
    {
        bool isLetterFirstName = true;
        bool isLetterLastName = true;

        for (int i = 0; i < firstName.Length; i++) //First name testing.
        {

            if (Char.IsLetter(firstName, i) == false)
            {
                isLetterFirstName = false;
            }
        }

        for (int i = 0; i < lastName.Length; i++) //Last name testing.
        {

            if (Char.IsLetter(lastName, i) == false)
            {
                isLetterLastName = false;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Test result - first name.");
        Console.WriteLine(isLetterFirstName == true ? "Successful testing - there are only letters." : "Unsuccessful testing - there are other chars, except letters." );

        Console.WriteLine();

        Console.WriteLine("Test result - last name.");
        Console.WriteLine(isLetterLastName == true ? "Successful testing - there are only letters" : "Unsuccessful testing - there are other chars, except letters.");
    }

    static void Main() 
	{
		PrintNames();
	}
}