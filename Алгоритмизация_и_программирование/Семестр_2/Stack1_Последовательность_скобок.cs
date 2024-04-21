using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack__скобки_
{
    class Program
    {
        static void Main(string[] args)
        {
            //char a = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите последовательность скобок");
            string c = Console.ReadLine();
            bool flag = true;
            Stack<char> bracket = new Stack<char>();
            foreach (char i in c)
            {
                if ((i == '{')||(i == '[')||(i=='('))
                {
                    bracket.Push(i);
                }
                if (i == ']')
                {
                    if ((bracket.Count == 0) || (bracket.Pop() != '[')) { flag = false; break; }
                }
                if (i == '}')
                {
                    if ((bracket.Count == 0) || (bracket.Pop() != '{')) { flag = false; break; }
                }
                if (i == ')')
                {
                    if ((bracket.Count == 0) || (bracket.Pop() != '(')) { flag = false; break; }
                }
            }
            if (bracket.Count != 0)
                flag = false;
            if (flag == false)
                Console.WriteLine("Скобки расставлениы неверно");
            else
                Console.WriteLine("Скобки расставлениы верно");
            Console.ReadKey();
        }
    }
}
