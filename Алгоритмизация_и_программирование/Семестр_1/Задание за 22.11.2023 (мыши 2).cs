using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Мыши_2
{
    class Program
    {
        static void Main(string[] args)
        {

                int n = Convert.ToInt32(Console.ReadLine());
                int m = Convert.ToInt32(Console.ReadLine());
                int k = Convert.ToInt32(Console.ReadLine());
                int n1 = Convert.ToInt32(Console.ReadLine());
                int m1 = Convert.ToInt32(Console.ReadLine());

                int S_B = n1 + m1;

                int[] mice = new int[n + m];
                for (int i = 0; i < mice.Length; i++)
                {
                    mice[i] = 1;
                }

                int p = 0;

                while (mice.Count(c => c == 1) > S_B)
                {
                    int mov = 0;

                    while (mov != k)
                    {
                        ++p;

                        if (p > mice.Length - 1)
                        {
                            p = 0;
                        }

                        if (mice[p] == 1)
                        {
                            ++mov;
                        }
                    }

                    mice[p] = 0;
                }

                int rasp_n = 0;
                int rasp_m = 0;
                int rasp_alive_n = 0;
                int rasp_alive_m = 0;

                if (n - n1 == 0 || m - m1 == 0)
                {
                    Console.WriteLine("Мышек так расположить не получится");
                }
                else
                {
                    for (int i = 0; i < mice.Length; i++)
                    {
                    if (mice[i] == 0)
                    {
                        if (rasp_n < n - n1)
                        {
                            Console.WriteLine("Серая");
                            rasp_n++;
                        }
                        else if (rasp_m < m - m1)
                        {
                            Console.WriteLine("Белая");
                            rasp_m++;
                        }
                    }
                    else if (mice[i] == 1)
                    {
                        if (rasp_alive_n < n1)
                        {
                            Console.WriteLine("Серая");
                            rasp_alive_n++;
                        }
                        else if (rasp_alive_m < m1)
                        {
                            Console.WriteLine("Белая");
                            rasp_alive_m++;
                        }
                    }
                    }
                }
            Console.ReadKey();
            }
        
        }
    
    }

