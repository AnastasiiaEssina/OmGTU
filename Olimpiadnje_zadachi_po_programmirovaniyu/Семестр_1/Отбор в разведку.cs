using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Отбор_в_разведку
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[1];
            int i = 0;
            int n, p;

            int s = int.Parse(Console.ReadLine());
            a[0] = s;
            
            while (i < a.Length)
            {
                if (a[i] > 3)
                {
                    n = a[i] / 2;
                    p = a[i] - n;

                    Array.Resize(ref a, a.Length + 2);
                    a[a.Length - 2] = n;
                    a[a.Length - 1] = p;
                }

                i++;                
            }

            int count = 0;
            foreach (int item in a)
            {
                if (item == 3)
                    count += 1;
                //Console.WriteLine(item.ToString());
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
