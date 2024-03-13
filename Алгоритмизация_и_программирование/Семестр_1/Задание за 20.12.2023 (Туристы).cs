using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Туристы
{
    class Program
    {
        static void Main(string[] args)
        {
            int dl = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            double[] S = new double[k+2];
            S[0] = 0;
            for (int i = 1; i < S.Length - 1; i++)
            {
                S[i] = double.Parse(Console.ReadLine());
            }
            S[S.Length - 1] = dl;
            Array.Resize(ref S, S.Length + 1);
            S[S.Length - 1] = dl;

            double v = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите время восхода через пробел");
            string line = Console.ReadLine();
            string[] H = line.Split(' ');
            double vosh = 0;

            vosh = int.Parse(H[0]) + int.Parse(H[1]) / 60;


            Console.WriteLine("Введите время заката через пробел");
            string line2 = Console.ReadLine();
            string[] H2 = line2.Split(' ');
            double zak = 0;

            zak = int.Parse(H2[0]) + int.Parse(H2[1]) / 60.0;

            double t = zak - vosh;
            int count = 0;
            int[] a = new int[0];
            double S_pred=0;
            int D = 0;
            bool f = true;
            for (int i = 0; i < k + 2; i++)
            {
                if (S[i]-S_pred > v * t)
                {
                    if (i == 1)
                    {
                        Console.WriteLine("Добраться до первого пункта нельзя");
                        f = false;
                        break;
                    }

                    if (D == i - 1)
                    {
                        Console.WriteLine("Добраться до пункта назначения нельзя");
                        f = false;
                        break;
                    }
                    Array.Resize(ref a, a.Length + 1);
                    
                    a[a.Length - 1] = i - 1;
                    S_pred = S[i - 1];
                    D = i - 1;
                    count += 1;
                    i -= 1;
                }
                
            }
            if (f)
            {
                Console.WriteLine(String.Join(",", a));
                Console.WriteLine(count+1);
            }
            Console.ReadKey();
        }
    }
}
