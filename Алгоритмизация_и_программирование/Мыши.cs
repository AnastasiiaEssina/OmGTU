using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Мыши
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество мышей");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите шаг");
            int K = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите позицию белой мыши");
            int white = Convert.ToInt32(Console.ReadLine());
            white--;

            int count = 0, t = 0;
            int[] a = new int[N];
            int last = 0;

            for (int i = 0; i < N; i++) a[i] = 1;

            while (count < N )
            {
                for (int i = 0; i < N; i++)
                {
                    if (a[i] != 0)
                        t++;
                    if ((t == K) && (a[i] != 0))
                    {
                        a[i] = 0;
                        last = i;
                        count++;
                        t = 0;
                    }
                     
                }
            }

            int delta = white - last + 1;
            if (delta < 0)
                delta += N;

            Console.WriteLine("Надо начать с позиции " + delta);
            Console.ReadKey();
        }
    }
}
