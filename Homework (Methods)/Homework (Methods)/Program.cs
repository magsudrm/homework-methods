using System;
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Schema;

namespace Homework__Methods_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task-1 Verilmiş iki ədədi toplayıb nəticəsini qaytaran metod
            Console.WriteLine("Eded 1-i daxil edin!");
            int input1 = ConvertBack();
            Console.WriteLine("Eded 2-ni daxil edin!");
            int input2 = ConvertBack();
            int result = Sum(input1, input2);
            Console.WriteLine(result);

            // Task-2  Verilmiş ədədin kvadratını qaytaran metod
            Console.WriteLine("Ededi daxil edin!");
            int input = ConvertBack();
            int SquareResult = Square(input);
            Console.WriteLine(SquareResult);

            // Task-3  Verilmiş string dəyərində a hərfinin olub olmadığını qaytaran metod
            Console.WriteLine("Yazini daxil edin!");
            string word = Console.ReadLine();
            var CheckA = HasA(word);

            // Task-4  Verilmiş ədədin rəqəmləri cəmini qaytaran metod
            Console.WriteLine("Ededi daxil edin!");
            int inputNum = ConvertBack();
            int ReqemlerCemi = SumOfDigits(inputNum);
            Console.WriteLine(ReqemlerCemi);

            // Task-5  Verilmiş 4 ədədin ortalamasını tapıq qaytaran metod
            Console.WriteLine("Birinci ededi daxil edin!");
            int number1 = ConvertBack();
            Console.WriteLine("Ikinci ededi daxil edin!");
            int number2 = ConvertBack();
            Console.WriteLine("Ucuncu ededi daxil edin!");
            int number3 = ConvertBack();
            Console.WriteLine("Dorduncu ededi daxil edin!");
            int number4 = ConvertBack();
            int NumbersAverages = NumAver(number1, number2, number3, number4);
            Console.WriteLine(NumbersAverages);
        }

        // Task-1 (method)
        static int Sum(int num1, int num2)
        {
            var sum = num1 + num2;
            return sum;
        }

        // Task-2 (method)
        static int Square(int num)
        {
            var numbersquare = num * num;
            return numbersquare;
        }

        // Task-3 (method)
        static Boolean HasA(string word)
        {
            bool hasA = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != 'a' && word[i] != 'A')
                {
                    continue;
                }
                hasA = true;
                break;
            }
            if (hasA)
            {
                Console.WriteLine("Yazida a herfi var!");
            }
            else
            {
                Console.WriteLine("Yazida a herfi yoxdur!");
            }
            return hasA;
        }

        // Task-4 (Method)
        static int SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int X = num % 10;
                sum += X;
                num = (num - X) / 10;
            }
            return sum;
        }

        // Task-5 (Method)
        static int NumAver(int num1, int num2, int num3, int num4)
        {
            int NumbersAverage = (num1 + num2 + num3 + num4) / 4;
            return NumbersAverage;
        }

        // Elave (method) for converts
        static int ConvertBack()
        {
            string DaxilOlunan = Console.ReadLine();
            var Converted = Convert.ToInt32(DaxilOlunan);
            return Converted;
        }
    }
}