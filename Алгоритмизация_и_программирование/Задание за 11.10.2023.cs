using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_за_11._10._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            Console.WriteLine("Введите количество элементов массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int min = 1000000000;
            int max = -1000000000;
            int count = 0;
            Console.WriteLine("Введите элементы массива");
            for (int i= 0; i<a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());                
            }
            foreach (var i in a) // Нахождение минимума и максимума
            {
                if (i < min)
                    min = i;
                if (i > max)
                    max = i;
                

            }
            


            int indexmin = 0, indexmax = 0;
            for (int i = 0; i < a.Length; i++) 
            {
                if (a[i] == min)
                    indexmin = i;
                if (a[i] == max)
                    indexmax = i;
            }
            if ((indexmin+1) < indexmax)
            {
                for (int i = (indexmin+1); i< indexmax;i++)
                {
                    if (a[i] % 2 == 0)
                        count += 1;
                }
                Console.WriteLine("Количество четных элементов между максимальным и минимальным элементами массива равно " + count);

            }
            else
            {
                if (indexmin > (indexmax+1))
                {
                    for (int i = (indexmax + 1); i < indexmin; i++)
                    {
                        if (a[i] % 2 == 0)
                            count += 1;
                    }
                    Console.WriteLine("Количество четных элементов между максимальным и минимальным элементами массива равно " + count);

                }
                else
                {
                    if (min == max)
                        Console.WriteLine("Нет максимального и минимального элементов");
                    else
                        Console.WriteLine("Нет элементов между максимальным и минимальным элементами массива");
                }
            }

            Console.ReadKey();
            

            // Задание 2
            
            Console.WriteLine("Введите количество элементов массива (два и больше)");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Введите элементы массива");
            int countch = 0, count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                {
                    countch += 1;
                    while (a[i] > 0) 
                    {
                        if (a[i] % 10 == 5)
                        {
                            count += 1;
                            break;
                        }
                        a[i]/= 10;
                    }
                }
            }
            if (count == countch)
                Console.WriteLine("Все элементы,стоящие на чётных местах, имеют в своей записи 5");
            else
                Console.WriteLine("Не все элементы,стоящие на чётных местах, имеют в своей записи 5");
            Console.ReadKey();
           

            // Задание 3

            Console.WriteLine("Введите количество элементов массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Введите элементы массива");
            
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                int k = 0;
                if (a[i] % 2 == 1)
                {
                    while (a[i] > 0)
                    {
                        k+= (a[i] % 10);
                        a[i] /= 10;
                    }
                    a[i] = k;
                }
            }
            foreach(int i in a) {Console.WriteLine(i);}
            Console.ReadKey();
            

            // Задание 4
            Console.WriteLine("Введите количество элементов массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Введите элементы массива");
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                if (a[i] % 2 != 0)
                {
                    count += 1;
                }
            }
            int[] b = new int[count];
            for (int j = 0; j < count; j++)
            {
                for (int i = j; i < a.Length; i++)
                {
                    if (a[i] % 2 != 0)
                    {
                        b[j] = a[i];
                        break;
                    }
                }
            }
            double d = b.Sum()*1.0 / count;
            int k = 0;
            foreach(int i in a)
            {
                if (i > d)
                    k += 1;
            }
            Console.WriteLine("Количество элементов, значение которых больше среднего арифметического нечётных элементов, равно " + k);
            Console.ReadKey();
            

            // Задание 5
            Console.WriteLine("Введите количество элементов массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                if ((a[i] < 0) && (Math.Abs(a[i]) % 10 == 3))
                {
                    Console.WriteLine("В массиве есть хотя бы 1 отрицательный элемент, оканчивающийся на 3");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
