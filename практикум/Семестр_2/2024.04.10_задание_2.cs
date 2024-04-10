using System;

namespace _2024._04._10__практикум2_
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datatime1 = new DateTime(2024, 4, 10, 21, 2, 3);
            
            string str = Convert.ToString(datatime1);
            Console.WriteLine(datatime1);
            Console.WriteLine(str);
            Console.WriteLine(datatime1.ToString());
            Console.ReadKey();
        }
    }
}
