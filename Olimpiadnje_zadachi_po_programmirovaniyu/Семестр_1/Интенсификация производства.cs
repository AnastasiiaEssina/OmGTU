using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Интенсификация_производства
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime a = DateTime.Parse(Console.ReadLine());
            DateTime b = DateTime.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            double r = (b - a).TotalDays + 1;
            r = Convert.ToInt32(r);
            int sum = 0;
            for (int i = 0; i < r; i++)
            {
                sum += p + i;
            }
            
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
