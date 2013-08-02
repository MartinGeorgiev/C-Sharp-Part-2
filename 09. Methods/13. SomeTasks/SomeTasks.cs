/*Write a program that can solve these tasks:
 * Reverses the digits of a number - The decimal number should be non-negative
 * Calculates the average of a sequence of integers - The sequence should not be empty
 * Solves a linear equation a * x + b = 0 - a should not be equal to 0 */

using System;

class SomeTasks
{
    static void ReverseDigit()
    {
        Console.Write("Please enter a number: ");
        string numberString = Console.ReadLine();
        ulong number = 0;

        bool isUlong = ulong.TryParse(numberString, out number);

        while (isUlong == false) //The number must be positive.
        {
            Console.WriteLine("Invalid Number. You should enter a positive number.");
            Console.Write("Please enter a number: ");
            numberString = Console.ReadLine();
            isUlong = ulong.TryParse(numberString, out number);
        }

        string numberToString = Convert.ToString(number); //Converting the number to string.

        char[] stringToChar = numberToString.ToCharArray(); //Converting the string to charArray. 

        Console.Write("Result: ");
        for (int i = stringToChar.Length; i > 0; i--)
        {
            Console.Write(stringToChar[i - 1]);
        }
        Console.WriteLine();
    }

    static void AverageInSequence()
    {
        Console.Write("Please enter the lenght of array: ");
        int lenght = Convert.ToInt16(Console.ReadLine());

        while (lenght <= 0) //The lenght can be less than 1;
        {
            Console.WriteLine("Error! The array lenght must be greater than 0.");
            Console.Write("Please enter the lenght of array: ");
            lenght = Convert.ToInt16(Console.ReadLine());
         
        }
        double sum = 0;

        for (int i = 0; i < lenght; i++) //Entering the elements of array.
        {
            Console.Write("Element[{0}]: ", i);
            int number = Convert.ToInt32(Console.ReadLine());
            sum = sum + number;
        }

        double averageSum = sum / (double)lenght;
        Console.WriteLine("The average sum is: {0}", averageSum );
    }

    static void LinearEquation()
    {
        Console.Write("Please enter a value for a: ");
        double aValue = Convert.ToInt32(Console.ReadLine());

        while (aValue == 0) //A must be != 0.
        {
            Console.WriteLine("A must be not equal to 0. Enter a new number.");
            Console.Write("Please enter a value for a: ");
            aValue = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Please enter a value for b: ");
        double bValue = Convert.ToInt32(Console.ReadLine());

        if (bValue > 0)
        {
            bValue = bValue * -1;
        }
        else
        {
            bValue = Math.Abs(bValue);
        }

        double result = bValue / aValue;
        Console.WriteLine("Result: {0}", result);
    }

    static void Main()
    {   //The menu
        Console.WriteLine("Task 1: Reverses the digits of a number.");
        Console.WriteLine("Task 2: Calculates the average of a sequence of integers.");
        Console.WriteLine("Task 3: Solves a linear equation a * x + b = 0.");

        Console.WriteLine();

        Console.Write("Please enter the number of the task that you want to solve: "); //The users choices the task to solve.
        int task = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine();

        while (task > 3 || task < 0) //Checking if there is a such taks.
        {
            Console.WriteLine("There is no such task.");
            Console.Write("Please enter the number of the task that you want to solve: ");
            task = Convert.ToInt16(Console.ReadLine());
        }

        //Calling the appropriate method.
        if (task == 1)
        {
            ReverseDigit();
        }

        if (task == 2)
        {
            AverageInSequence();
        }

        if (task == 3)
        {
            LinearEquation();
        }
    }
}