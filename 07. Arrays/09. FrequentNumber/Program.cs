/*Write a program that finds the most frequent number in an array. Example:
	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)*/

using System;

class FrequentNumber
{
    static void Main()
    {
        Console.Write("Array Lenght: ");
        int arrLenght = Convert.ToInt32(Console.ReadLine());

        int[] myArr = new int[arrLenght];

        for (int i = 0; i < arrLenght; i++)
        {
            Console.Write("Element[{0}]:", i);
            int myArrElement = Convert.ToInt32(Console.ReadLine());
            myArr[i] = myArrElement;
        }

        Array.Sort(myArr);
        int arrElement = 0;
        int arrSeqTemp = 1;
        int arrSeq = 1;

        if (arrLenght == 1)
        {
            arrElement = myArr[0];
            Console.WriteLine("Result:{0}{2}{1}", "{", "}", arrElement);
        }

         if (arrLenght > 1)
        {
            for (int i = 0; i < arrLenght - 1; i++)
            {
                if (myArr[i] == myArr[i + 1])
                {
                    arrSeqTemp++;
                }

                if (arrSeqTemp > arrSeq)
                {
                    arrSeq = arrSeqTemp;
                    arrElement = myArr[i];
                }
                else
                {
                    arrSeqTemp = 1;
                }
            }
            Console.WriteLine("Result: {0}({1} times)", arrElement, arrSeq );
        }
    }
}
