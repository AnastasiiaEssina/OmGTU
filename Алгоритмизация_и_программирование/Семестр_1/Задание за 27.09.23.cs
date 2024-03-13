using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_за_27._09._23
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задиние 1
            int counter = 0;
            Console.WriteLine("Введите количество элементов (три или больше)");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите элементы");
            int i = Convert.ToInt32(Console.ReadLine());
            int j = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            for (int r = 0; r <= (n - 3); r++)
            {
                if ((j < i) && (j < k))
                    counter += 1;
                
                if ((n - 3) > r)
                {
                    i = j;
                    j = k;
                    k = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Количество элементов, значение которых меньше соседа справа и слева равно " + counter);
            Console.ReadKey();
            

            //Задание 2

            
            int smen = 0;
            Console.WriteLine("Введите количество элементов ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите элементы");
            
            if (n == 1)
            {
                i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Количество смен знака равно 0");
            }
            else
            {
                i = Convert.ToInt32(Console.ReadLine());
                j = Convert.ToInt32(Console.ReadLine());

                    for (int r = 0; r <= (n - 2); r++)
                {
                    
                    while (j == 0)
                    {
                        
                        if (r == (n - 2))
                        {
                            break;
                        }
                        else
                        {
                            j = Convert.ToInt32(Console.ReadLine());
                            r += 1;
                        }
                    }
                   
                    if (i > 0 && j < 0 || i < 0 && j > 0)
                        smen += 1;
                    if (r < (n - 2))
                    {
                        i = j;
                        j = Convert.ToInt32(Console.ReadLine());
                    }
                    

                }
                Console.WriteLine("Количество смен знака равно " + smen);
            }

            
            Console.ReadKey();
            

            // Задание 3

            
            int c = 1;
            int mx = 0;
            Console.WriteLine("Введите количество элементов ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите элементы");
            if (n == 1)
            {
                i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Максимальная длинна подпоследовательности, состоящей из одинаковых элементов, равна 1");
            }
            else
            {
                i = Convert.ToInt32(Console.ReadLine());
                j = Convert.ToInt32(Console.ReadLine());

                for (int r = 0; r <= (n - 2); r++)
                {


                    if (i == j)
                        c += 1;
                    else
                        c = 1;
                    if (mx < c)
                        mx = c;

                    if (r < (n - 2))
                    {
                        i = j;
                        j = Convert.ToInt32(Console.ReadLine());
                    }

                }
                Console.WriteLine("Максимальная длинна подпоследовательности, состоящей из одинаковых элементов, равна " + mx);
            }
            Console.ReadKey();
            

            // Задание 4

            
            int min = 100000000;
            int mn = 100000000;
            c = 0;
            k = 0;
            Console.WriteLine("Введите количество элементов ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите элементы");
            i = Convert.ToInt32(Console.ReadLine());
            if ((n == 1) && (i >= 0))
            {
                
                Console.WriteLine("Минимальная длинна подпоследовательности, состоящей из отрицательных элементов, равна 0");
            }
            else
            {

                
                while (i >= 0)
                {

                    i = Convert.ToInt32(Console.ReadLine());

                    if (k == (n - 1))
                    {
                        Console.WriteLine("Минимальная длинна подпоследовательности, состоящей из отрицательных элементов, равна 0");
                        break;
                    }
                    k++;
                }

                for (int r = k; r < n; r++)
                {

                    if (i < 0)
                    {
                        c += 1;
                        if (r == (n - 1))
                            mn = c;
                    }
                    else
                    {
                        mn = c;
                        c = 0;
                    }
                    if ((min > mn) && (mn !=0))
                        min = mn;

                    if (r < (n - 1))
                    {
                        i = Convert.ToInt32(Console.ReadLine());
                    }



                }
                Console.WriteLine("Минимальная длинна подпоследовательности, состоящей из отрицательных элементов, равна " + min);

            }

            Console.ReadKey();
            
        }
    }

}
