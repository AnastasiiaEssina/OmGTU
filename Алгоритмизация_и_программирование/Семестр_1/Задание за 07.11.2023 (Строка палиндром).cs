using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_за_07._11._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            int sum = 0;

            foreach (char c in input)
            {
                if (Char.IsDigit(c))
                {
                    int digit = int.Parse(c.ToString());
                    if (digit % 2 == 0)
                    {
                        sum += digit;
                    }
                }
            }

            Console.WriteLine("Сумма четных цифр равна " + sum);

            string s = input.Replace(" ","");
            s = s.ToLower();
            char[] Sarray = s.ToCharArray();
            Array.Reverse(Sarray);
            string r =  new string(Sarray);
            if (s == r)
            {
                Console.WriteLine("Строка - палиндром");
            }
            else
            {
                Console.WriteLine("Строка не является палиндромом");
            }
            Console.ReadKey();
        }
    }
}
