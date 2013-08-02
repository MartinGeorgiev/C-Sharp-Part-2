/*You are given an array of strings. Write a method that 
 * sorts the array by the length of its elements
 * (the number of characters composing them). */

using System;
using System.Collections.Generic;
using System.Linq;

class SortString
{
    static void Main(string[] args)
    {
        IEnumerable<string> newList = null;

        List<string> strList = new List<string>()
        {
            "Martin", "Peter", "Pesho", "Na Pesho sestra mu", "Goshov", "Todorov"
        };

        newList = strList.OrderBy(x => x.Length).ThenByDescending(x => x);

        foreach (var str in newList)
        {
            Console.WriteLine(str);
        }
    }
}
