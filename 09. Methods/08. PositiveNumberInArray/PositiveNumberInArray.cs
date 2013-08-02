/*Write a method that adds two positive integer numbers 
 * represented as arrays of digits (each array element arr[i] 
 * contains a digit; the last digit is kept in arr[0]). 
 * Each of the numbers that will be added could have up to 10 000 digits.*/

//Задачата е решена без да се използва BigInteger, това е причината да е с голям обем код.
//Обяснявам я на български език, понеже ще е трудно на английски, предвид многото преобразувания.

using System;

class PositiveNumberInArray
{
    static void Main()
    {
        //Въвеждат се двете числа.
        Console.Write("Please enter the first number: ");
        string firstNumber = Console.ReadLine();

        Console.Write("Please enter the second number: ");
        string secondNumber = Console.ReadLine();

        int maxLenght = Math.Max(firstNumber.Length, secondNumber.Length); //Намира се по-голямата дължина на едно от двете числа, като се вземе предвид броя на цифрите във всяко от тях.

        string[] firstArray = new string[maxLenght + 1]; //Създават се два масива, с дължината на по-дългото от двете числа.
        string[] secondArray = new string[maxLenght + 1];

        int firstNumberLenght = firstNumber.Length;
        int secondNumberLenght = secondNumber.Length;

        //Създаваме два масива. Всеки от тях се попълва с цифрите от числото което представлява.
        //Ако едното число е по-дълго от другото, масивът на по-краткото се запълва с 0-ли, докато не достигне дължината на по-дългото.
        //Цифрите в масивите се ривърсват, спрямо позицията им в числото - последната цифра от числото, става първа в масива и обратно.

        for (int i = 1; i <= maxLenght; i++)
        {
            if (i > firstNumberLenght)
            {
                firstArray[i - 1] = "0";
            }

            else
            {
                firstArray[i - 1] = Convert.ToString(firstNumber[firstNumber.Length - i]);
            }
        }

        for (int i = 1; i <= maxLenght; i++)
        {
            if (i > secondNumberLenght)
            {
                secondArray[i - 1] = "0";
            }

            else
            {
                secondArray[i - 1] = Convert.ToString(secondNumber[secondNumber.Length - i]);
            }
        }

        PrintingTheArrays(firstArray, secondArray, maxLenght);
    }
    
    //За да е по-ясно решението, на конзолата се принтират двата масива, след като са ривърснати.
    static void PrintingTheArrays(string[] firstArray, string[] secondArray, int maxLenght)
    {
        Console.WriteLine("Result after converting in array:");

        Console.Write("First array: {");
        for (int i = 0; i < maxLenght; i++)
        {
            Console.Write(firstArray[i]+ ", ");
        }
        Console.Write("}");
        Console.WriteLine();

        Console.Write("Second array: {");
        for (int i = 0; i < maxLenght; i++)
        {
            Console.Write(secondArray[i] + ", ");
        }
        Console.Write("}");
        Console.WriteLine();
        
        SearchingTheResult(firstArray,secondArray,maxLenght);
    }

    //Извършва се събиране на елементите от двата масива, два по два /по двоики, спрямо индексите на елементите/ и резултатът се въвежда в трети масив.

    static void SearchingTheResult(string[] firstArray, string[] secondArray, int maxLenght)
    {
        int[] resultArray = new int[maxLenght + 1]; //Дължината на масива е увеличена с единица, за да може евентуално ако последните цифри на двата масива имат сума повече от 9, да се добави още една цифра.
        int temp = 0;                               //Пример: 999 и 102 - двата масива с с по три елемента, но общата им сума е равна на 1101, за целта в резултатния масив, се добавя още една позиция която да реши това.
        int inMind = 0; //Ако сумата на двете числа от двата масива, на позиция i е по-голяма от 9, тогава се добавя "едно на ум", което се прибавя към следващата двойка.

        for (int i = 0; i < maxLenght+1; i++)
        {
            temp = Convert.ToInt16(firstArray[i]) + Convert.ToInt16(secondArray[i]) + inMind;
           
            if (temp > 9)
            {
                resultArray[i] = inMind + (Convert.ToInt16(firstArray[i]) + Convert.ToInt16(secondArray[i]) - 10);
                inMind = 1;
            }

            else
            {
                resultArray[i] = inMind + Convert.ToInt16(firstArray[i]) + Convert.ToInt16(secondArray[i]);
                inMind = 0;
            }
        }

        ZeroProblem(resultArray, maxLenght);
    }

    static void ZeroProblem(int[] resultArray, int maxLenght)
    {
        string result = ""; //Конвертираме получената стойност в стринг.

        for (int i = 0; i < maxLenght + 1; i++)
        {
            if(i == maxLenght && resultArray[i] == 0) //Премахваме добавената по-горе позиция в масива, ако тя е била излишна.
            {                                           //Пример: числата са 111 и 222 - резултат 333. При това положение 4-та позиция в масива е излишна.
                break;
            }
            result = result + Convert.ToString(resultArray[i]);
        }

        PrintingTheResult(result);
    }

    static void PrintingTheResult(string result) //Принтира се резултатът.
    {
        char[] resultToChar = result.ToCharArray();

        Console.Write("Result: ");
        for (int i = resultToChar.Length; i > 0; i--)
        {
            Console.Write(resultToChar[i-1]);
        }
        Console.WriteLine();
    }
}