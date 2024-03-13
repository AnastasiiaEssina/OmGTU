using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Обмен_денег
{
    class Program
    {
        static void Main(string[] args)
        {
            // обработка первой строки
            string Help_str = Console.ReadLine();
            string[] H = Help_str.Split(' ');
            int N_ish = int.Parse(H[0]);
            H = H.Skip(1).ToArray();
            int[] C = new int[N_ish-1];
            for (int i = 0; i < C.Length; i++)
            {
                C[i] = Convert.ToInt32(H[i]);
            }

            // обработка второй строки
            Help_str = Console.ReadLine();
            H = Help_str.Split(' ');
            int K_ish = int.Parse(H[0]);
            H = H.Skip(1).ToArray();
            int[] A = new int[K_ish];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = Convert.ToInt32(H[i]);
            }

            // обработка третьей строки
            Help_str = Console.ReadLine();
            H = Help_str.Split(' ');
            int N_kon = int.Parse(H[0]);
            H = H.Skip(1).ToArray();
            int[] D = new int[N_kon - 1];
            for (int i = 0; i < D.Length; i++)
            {
                D[i] = Convert.ToInt32(H[i]);
            }

            // обработка четвертой строки
            Help_str = Console.ReadLine();
            H = Help_str.Split(' ');
            int K_kon = int.Parse(H[0]);
            H = H.Skip(1).ToArray();
            int[] B = new int[K_kon];
            for (int i = 0; i < B.Length; i++)
            {
                B[i] = Convert.ToInt32(H[i]);
            }

            // обработка пятой строки
            Help_str = Console.ReadLine();
            H = Help_str.Split(' ');
            int[] E = new int[N_ish];
            for (int i = 0; i < E.Length; i++)
            {
                E[i] = int.Parse(H[i]);
            }

            int[] res = new int[N_kon];

            int pomosh;
            int real_dengi = 0;
            int Q;

            // ослабление порчи
            //Array.Reverse(A);

            //первая часть
            //снятие порчи
            for (int i = 0; i < E.Length; i++)
            {
                for (int j = 0; j < A.Length; j++)
                {
                    if (E[i] >= A[j])
                    {
                        E[i] -= 1;
                    }
                }
            }

            //перевод в реальные деньги
            for (int i = 0; i < E.Length; i++)
            {
                if (i == E.Length - 1)
                {
                    real_dengi += E[i];
                }
                else
                {
                    real_dengi = (real_dengi + E[i]) * C[i];
                }
            }

            //вторая часть
            for  (int i = D.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    res[i+1] = real_dengi % D[i];
                    res[i] = real_dengi / D[i];
                }
                else
                {
                    res[i+1] = real_dengi % D[i];
                    real_dengi /= D[i];
                }
            }

            if (D.Length == 0)
                res[0] = real_dengi;

            //усиление порчи(сортировка)
            //Array.Sort(B);

            // наведение порчи
            for (int i = 0; i< res.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (res[i] >= B[j])
                        res[i] += 1;
                }
            }

            // Возвращаем реку в берега
            for (int i = res.Length-1; i > 0; i--)
            {
                if (res[i] > D[i - 1])
                {
                    res[i - 1] += 1;
                    res[i] -= D[i - 1];
                }
            }

            Console.WriteLine(String.Join(" ", res));
            Console.ReadKey();
        }
    }
}
