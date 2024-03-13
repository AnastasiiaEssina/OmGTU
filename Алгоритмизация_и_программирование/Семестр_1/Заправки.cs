using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Заправки
{
    class Program
    {
        static void Main(string[] args)
        {
            int poloz = -1;
            int k = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[k];
            int min = 1000000000;            
            a[0] = 0;
            int[] b = new int[k];
            b[0] = 0;

            

            for (int i = 1; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = a.Sum();

            for (int i = 1; i < k; i++)
            {
                b[i] = b[i - 1] + a[i];
            }

            for (int i = 0; i <= sum; i++)
            {

                int r = 0;
                bool sanzona_ok = false;
                for (int g = 0; g < k; g++)
                {
                    r += a[g];

                    if ((r - p) < i && i < r + p)
                    {
                        sanzona_ok = true;
                    }



                }
                if (sanzona_ok == false)
                {
                    int f = 0;
                    for (int j = 0; j<k; j++)
                    {
                        f += Math.Abs(i - b[j]);
                    }
                    
                    if (f < min)
                    {
                        min = f;
                        poloz = i;
                    }
                }


            }
            if (min == 1000000000)
            {
                Console.WriteLine("Невозможно поставить заправку");
            }
            else
            {
                Console.WriteLine(poloz);
            }

            Console.ReadKey();
            
        }
    }
}
