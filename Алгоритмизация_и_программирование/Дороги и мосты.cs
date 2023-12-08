using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дороги_и_мосты
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество интервалов");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину моста");
            int t = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int sumB = 0 , sumA = 0;
            Console.WriteLine("Введите пары чисел");
            for (int i = 0; i < N; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                sumA += a;
                sumB += b;
                result = Math.Min(sumA + t, result + b);
            }
            if (result == sumB)
                result += t;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
