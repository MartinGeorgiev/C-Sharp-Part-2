//Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

using System;

class MaxArrSeq2
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
            for (int i = arrLenght - 1; i > 0 ; i--)
            {
                if (myArr[i] - myArr[i-1] == 1)
                {
                    arrSeqTemp++;
                }

                if (arrSeqTemp > arrSeq)
                {
                    arrSeq = arrSeqTemp;
                    arrElement = i - 1;
                }
                else
                {
                    arrSeqTemp = 1;
                }
            }

            Console.Write("Result: {");

            for (int i = arrElement; i < arrElement + arrSeq; i++)
            {
                Console.Write(myArr[i]);
                if (i < arrElement + arrSeq - 1)
                {
                    Console.Write(",");
                }
            }

            Console.WriteLine("}");
        }
    }
}