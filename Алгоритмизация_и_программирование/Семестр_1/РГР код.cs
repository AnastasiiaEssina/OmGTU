using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ипподром
{
    class Program
    {
        static void Main(string[] args)
        {
            int d;
            int max;
            Random rd = new Random();
            int r;
            int a, b, c;
            int sa = 0, sb = 0, sc = 0;
            Console.WriteLine("Выберите номер лошади №1 - Бурёнка, №2 - Игогоша, №3 - Жеребяш");
            d = int.Parse(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                max = 0;
                a = 0; b = 0; c = 0;
                r = rd.Next(1,100);
                if (max <= r)
                {
                    max = r;
                    a = 1;
                }

                r = rd.Next(1, 100);
                if (max < r)
                {
                    max = r;
                    a = 0;
                    b = 1;
                }
                if (max == r)
                {
                    b = 1;
                }

                r = rd.Next(1, 100);
                if (max < r)
                {
                    max = r;
                    a = 0;
                    b = 0;
                    c = 1;
                }
                if (max == r)
                {
                    c = 1;
                }

                sa += a;
                sb += b;
                sc += c;
            }


            while ((sa != sb) && (sa != sc) && (sb != sc)) 
            {
                max = 0;
                a = 0; b = 0; c = 0;
                r = rd.Next(1, 100);
                if (max <= r)
                {
                    max = r;
                    a = 1;
                }

                r = rd.Next(1, 100);
                if (max < r)
                {
                    max = r;
                    a = 0;
                    b = 1;
                }
                if (max == r)
                {
                    b = 1;
                }

                r = rd.Next(1, 100);
                if (max < r)
                {
                    max = r;
                    a = 0;
                    b = 0;
                    c = 1;
                }
                if (max == r)
                {
                    c = 1;
                }

                sa += a;
                sb += b;
                sc += c;
            }
            
            int[] n = { sa, sb, sc };           
            int smax = n.Max();                           
            int vmax = Array.IndexOf(n, smax) + 1;

            if (d == vmax) 
            {
                Console.WriteLine("Вы выиграли!");
            }
            else
            {
                Console.WriteLine("Вы проиграли!");
            }
            Console.ReadKey();
        }
    }
}
