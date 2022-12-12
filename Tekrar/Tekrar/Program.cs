using System;

namespace Tekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = decrement(34);
            Console.WriteLine(result);
            string fullname = MakeFullName("Maqsud", "Muslumov");
            Console.WriteLine(fullname);
            int num = GetNumber();
            Console.WriteLine(num);
            Console.WriteLine(sum(2332, 232));
            Console.WriteLine(GetAndSumTwo());
            SumShow(1212, 2323);
        }

        static int decrement(int eded)
        {
            eded -= 1;
            return eded;
        }

        static string MakeFullName(String name, string surname)
        {
            var fn = name + " " + surname;
            return fn;
        }

        static int GetNumber()
        {

            string strnumber = Console.ReadLine();
            return Convert.ToInt32(strnumber);
        }

        static int sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static int GetAndSumTwo()
        {
            Console.WriteLine("num1:");
            var num1 = GetNumber();
            Console.WriteLine("num2:");
            var num2 = GetNumber();
            return num1 + num2;
        }

        static void SumShow(int num1,int num2)
        {
           var  sum = num1 + num2;
            Console.WriteLine(sum);
        }
    }
}
