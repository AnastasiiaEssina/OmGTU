using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_за_08._11._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            void Zapoln_array(int[,] a)
            {
                int m = a.GetLength(0);
                int n = a.Length / m;

                Random r = new Random();
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {                        
                        a[i, j] = r.Next(0, 100);
                    }
                }
            }

            int get_min(int[] stroka)
            {
                int mmin = stroka[0];
                foreach (int i in stroka)
                    if (i < mmin)
                        mmin = i;
                return mmin;
            }

            int get_max(int[] stroka)
            {
                int mmax = stroka[0];
                foreach (int i in stroka)
                    if (i > mmax)
                        mmax = i;
                return mmax;
            }

            Console.WriteLine("Введите высоту массива");
            int heigth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину массива");
            int width = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int[,] array = new int[heigth, width];
            Zapoln_array(array);

            for (int i = 0; i < heigth; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(array[i, j].ToString(), " ");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }



            int min, max;
            for (int i = 0; i < heigth; i++)
            {
                int[] line = new int[width];
                for (int j = 0; j < width; j++)
                {
                    line[j] = array[i, j];
                }

                min = get_min(line);
                max = get_max(line);
                if (min % 2 == 0 && max % 2 == 0)
                    count++;
            }
            Console.WriteLine("Количество строк " + count);
            Console.ReadKey();
        }
    }
}
