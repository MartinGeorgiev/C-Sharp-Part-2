//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

using System;

class SystemConverting
{
    static void Main()
    {
        Console.Write("Please enter - BASE/FROM - numeral system:");
        int from = Convert.ToInt16(Console.ReadLine());

        Console.Write("Please enter - BASE/TO - numeral system:");
        int to = Convert.ToInt16(Console.ReadLine());

        Console.Write("Please enter a number to convert: ");
        string number = Console.ReadLine();



        char[] array = number.ToCharArray();
        Array.Reverse(array);
        int arrLenght = array.Length;
        int sum = 0;

        if (from <= 10)
        {

            for (int i = 0; i < arrLenght; i++)
            {
                string charToString = Convert.ToString(array[i]);
                int numberC = Convert.ToInt32(charToString);
                sum = sum + (int)Math.Pow(from, i) * numberC;
            }
        }

        else
        {
            for (int i = 0; i < arrLenght; i++)
            {
                string charToString = Convert.ToString(array[i]);
                int numberC = 0;

                switch (charToString)
                {
                    case "0": numberC = 0; break;
                    case "1": numberC = 1; break;
                    case "2": numberC = 2; break;
                    case "3": numberC = 3; break;
                    case "4": numberC = 4; break;
                    case "5": numberC = 5; break;
                    case "6": numberC = 6; break;
                    case "7": numberC = 7; break;
                    case "8": numberC = 8; break;
                    case "9": numberC = 9; break;
                    case "A": numberC = 10; break;
                    case "B": numberC = 11; break;
                    case "C": numberC = 12; break;
                    case "D": numberC = 13; break;
                    case "E": numberC = 14; break;
                    case "F": numberC = 15; break;
                    default: break; //If there is invalid symbol, there will be an error
                }
                sum = sum + (int)Math.Pow(from, i) * numberC;
            }
        }


        int digit = 0;
        string result = "";

        string sumStr = Convert.ToString(sum);
        char[] arr = sumStr.ToCharArray();
        arrLenght = arr.Length;

        if (to == 2 || to == 8 || to == 10 || to == 16)
        {
            result = Convert.ToString(sum, to);
            Console.WriteLine("The result after converting is: {0}", result);
        }

        else
        {
            for (int i = 0; 0 < sum; i++)
            {
                digit = sum % to;
                string digitStr = Convert.ToString(digit);

                if (digit >= 10)
                {
                    switch (digitStr)
                    {
                        case "10": digitStr = "A"; break;
                        case "11": digitStr = "B"; break;
                        case "12": digitStr = "C"; break;
                        case "13": digitStr = "D"; break;
                        case "14": digitStr = "E"; break;
                        case "15": digitStr = "F"; break;
                        default: break; //If there is invalid symbol, there will be a
                    }
                }
                sum = sum / to;
                result = result + digitStr;
            }

            char[] arrResult = result.ToCharArray();
            Array.Reverse(arrResult);
            int arrL = arrResult.Length;

            string resultL = "";

            for (int i = 0; i < arrL; i++)
            {
                resultL = resultL + arrResult[i];
            }

            Console.WriteLine("The result after converting is: {0}", resultL);
        }

    }
}


