using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_за_25._10._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк");
            int k = Convert.ToInt32(Console.ReadLine());
            int[][] arr = new int[k][];
            Console.WriteLine("Введите элементы каждой строки через пробел");
            for (int j = 0; j < k; j++)
            {
                string str = Console.ReadLine();
                string[] H = str.Split(' ');
                arr[j] = new int[H.Length]; 
                for (var i = 0; i < H.Length; i++)
                {
                    arr[j][i] = Convert.ToInt32(H[i]);
                }
            }

            //Пересечение
            int count = 1;
            int[] peresech = new int[0];

            for (int j = 0; j < k; j++)
            {
                arr[j] = arr[j].Distinct().ToArray();
            }
            for (int i = 0; i < arr[0].Length; i++) 
            {
                for (int j = 0; j < k; j++)
                {
                    
                    for (int l = 0; l<arr[j].Length; l++)
                    {
                        if (arr[0][i] == arr[j][l])
                        {
                            count++;
                            if (count==k)
                            {
                                Array.Resize(ref peresech, peresech.Length + 1);
                                peresech[peresech.Length - 1] = arr[0][i];
                            }
                        }
                    }
                }
                count = 0;
            }
            if (k == 1)
            {
                Array.Resize(ref peresech, arr[0].Length);
                for (int i = 0; i < arr[0].Length; i++)
                {
                    peresech[i] = arr[0][i];
                }
            }
            
            peresech = peresech.Distinct().ToArray();
            Console.WriteLine("Пересечение " + (string.Join(", ", peresech)));


            // Объединение
            int[] obyed = new int[0];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Array.Resize(ref obyed, obyed.Length + 1);
                    obyed[obyed.Length - 1] = arr[i][j];
                }
            }
            obyed = obyed.Distinct().ToArray();
            Console.WriteLine("Объединение " + (string.Join(", ", obyed)));

            //  Максимальные элементы
            int[] Max = new int[0];
            for (int i = 0; i < arr.Length; i++)
            {
                Array.Resize(ref Max, Max.Length + 1);
                Max[Max.Length-1] = arr[i].Max();
            }
            Console.WriteLine("Максимальные элементы " + (string.Join(", ", Max)));

            Console.ReadKey(); 
        }
    }
}





            
   

