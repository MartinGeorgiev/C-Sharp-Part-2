/*Write a method that calculates the number of workdays between 
 * today and given date, passed as parameter. Consider that 
 * workdays are all days from Monday to Friday except a fixed 
 * list of public holidays specified preliminary as array.*/

using System;
using System.Linq;

class WorkingDays
{
    static void Main()
    {
        DateTime date;

        Console.Write("Please enter a date in the future in format: DD.MM.YYYY: ");
        date = DateTime.Parse(Console.ReadLine());

        while (date < DateTime.Today)
        {
            Console.Write("Invalid date. Please enter again: ");
            date = DateTime.Parse(Console.ReadLine());
        } 

        Console.WriteLine("There are {0} working days between today and {1}", CalcHolidays(date), date); //Printing the result.
    }

    static int CalcHolidays(DateTime date)
    {
        int days = 0;
        int holidays = 0;

        DateTime dateToday = DateTime.Today;
        int currYear = DateTime.Today.Year;

        DateTime[] hdays =
        {
            new DateTime(currYear, 1, 1),
            new DateTime(currYear, 3, 3),
            new DateTime(currYear, 5, 1),
            new DateTime(currYear, 5, 2),
            new DateTime(currYear, 5, 6),
            new DateTime(currYear, 5, 24),
            new DateTime(currYear, 9, 22),
            new DateTime(currYear, 12, 24),
            new DateTime(currYear, 12, 25),
            new DateTime(currYear, 12, 26),
            new DateTime(currYear, 12, 31)
            };

        while (dateToday <= date)
        {
            if (dateToday.DayOfWeek == DayOfWeek.Saturday || dateToday.DayOfWeek == DayOfWeek.Sunday)
            {
                holidays++;
            }
            else
            {
                foreach (var element in hdays)
                {
                    if (element.DayOfYear == dateToday.DayOfYear)
                    {
                        holidays++;
                    }
                }
            }
            days++;
            dateToday = dateToday.AddDays(1);
        }

        int workingDays = days - holidays;
        return workingDays;
    }
}
