using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упаковки_молока
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double count = 0, counter = 0;
            double min = 1000000000;
            double m;
            double x1, x2, y1, y2, z1, z2, s1, s2, v1, v2;
            double c1, c2, st;
            for (double i = 0; i < n; i++)
            {
                count += 1;
                x1 = (double.Parse(Console.ReadLine()));
                y1 = (double.Parse(Console.ReadLine()));
                z1 = (double.Parse(Console.ReadLine()));
                x2 = (double.Parse(Console.ReadLine()));
                y2 = (double.Parse(Console.ReadLine()));
                z2 = (double.Parse(Console.ReadLine()));
                c1 = double.Parse(Console.ReadLine());
                c2 = double.Parse(Console.ReadLine());
                s1 = 2 * (x1*y1 + y1*z1 + x1*z1);
                v1 = x1 * y1 * z1 / 1000;
                s2 = 2 * (x2*y2 + y2*z2 + z2*x2);
                v2 = x2 * y2 * z2 / 1000;
                st = (c2*v1-c1*v2)/(s2*v1-s1*v2);
                m = (c1 - st * s1) / (v1);
                if (m < min)
                {
                    min = m;
                    counter = count;
                }
            }
            var minmin = string.Format("{0:0.##}", min);
            Console.Write(counter + " " + minmin);
            Console.ReadKey();
        }
    }
}
