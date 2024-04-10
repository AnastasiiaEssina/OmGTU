using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace _2024._04._10___практикум_
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "0123456789";
            Random rand = new Random();
            int y;
            Stopwatch stopWatch1 = new Stopwatch();
            stopWatch1.Start();
            for (int i = 0; i < 1000000; i++)
            {
                y = i % 10;
                str = str.Remove(y, 1).Insert(y, rand.Next(10).ToString());//не совсем прравильно, т к случайные только цифры, а не все символы
            }

            stopWatch1.Stop();
            Console.WriteLine("Время затраченное на string - " + stopWatch1.Elapsed);


            StringBuilder sb = new StringBuilder("0123456789");
            sb[0] = char.Parse(rand.Next(10).ToString());
            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();
            for (int i = 0; i < 1000000; i++)
            {
                y = i % 10;
                sb[y] = char.Parse(rand.Next(10).ToString());
            }

            stopWatch2.Stop();
            Console.WriteLine("Время затраченное на StringBuilder - " + stopWatch2.Elapsed);
        }
    }
}
