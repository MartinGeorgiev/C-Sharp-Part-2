// Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
// Example: N = 5, K = 2 -> {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

using System;

class Combinations
{
    static void Main()
    {
        Console.Write("Please enter the number N: ");
        int numberN = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter the elements K: ");
        int numberK = Convert.ToInt32(Console.ReadLine());

        bool rightInput = true;

        if(numberN <= 0 || numberK <=0)
        {
            rightInput = false;
        }

        if (numberK < 1)
        {
            Console.WriteLine("This combination is imposible");
        }
        
        if(rightInput == true)
        {
        
            for (int i = 0; i < Math.Pow(numberN, numberK); i++)
            {
                int temp = i;
                int[] array = new int[numberK];
                bool print = true;
                
                for (int j = 0; j < numberK; j++)
                {
                    array[numberK - j - 1] = temp % numberN;
                    temp = temp / numberN;
                }

                for (int j = 1; j < array.Length; j++)
                {
                    if (array[j] <= array[j - 1])
                    {
                        print = false;
                    }
                }

                if (print)
                {
                    Console.Write("{0}{1}", '{', array[0] + 1);
                    for (uint j = 1; j < numberK; j++)
                    {
                        Console.Write(",{0}", array[j] + 1);
                    }
                    Console.WriteLine("}");
                }
            }
        }
        else
        {
            Console.WriteLine("Number you have wrote, is not valid. You should enter the number again.");
            Main();
        }
    }
}