//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;

class LeapYears
{
    static void Main()
    {
        ushort year = 0;

        while (true)
        {
            try
            {
                Console.Write("Please enter a year to check: ");
                year = Convert.ToUInt16(Console.ReadLine());
                
                Console.WriteLine("Result - the year is leap: {0}", IsItLeap(year));
                break;
            }

            catch (Exception)
            {
                Console.WriteLine("ERROR!.You must enter a valid positive number. \n");
            }
         }
    }

    static bool IsItLeap(ushort year)
    {
        bool isLeap = DateTime.IsLeapYear(year);

        return isLeap;
    }
}

