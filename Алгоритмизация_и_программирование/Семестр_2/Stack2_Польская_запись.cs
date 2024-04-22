using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Польская_запись
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите выражение: ");
            string phrase = Console.ReadLine();
            Stack<string> expression = new Stack<string>();
            double result = 0;
            double a;
            double b;
            bool flag = false;
            foreach (char i in phrase)
            {
                if (i == '+' || i == '-' || i == '*' || i == '/')
                {
                    if (expression.Count < 2) { Console.WriteLine("Ошибка: Отсутствие элемента для произведения вычисления"); flag = true; break; }
                    if (expression.Count > 2) { Console.WriteLine("Ошибка: Неоднозначность результата"); flag = true; break; }
                    b = Convert.ToDouble(expression.Pop());
                    a = Convert.ToDouble(expression.Pop());
                    if (b == 0) { Console.WriteLine("Ошибка: Деление на ноль"); flag = true; break; }
                    if (i == '+') { result = a + b; }
                    if (i == '-') { result = a - b; }
                    if (i == '*') { result = a * b; }
                    if (i == '/') { result = a / b; }
                    expression.Push(Convert.ToString(result));
                }
                else
                {
                    if (i != ' ')
                    {
                        expression.Push(Convert.ToString(i));
                    }
                }
            }
            if (flag == false) { Console.WriteLine("Результат вычисления: " + expression.Pop()); }
            Console.ReadKey();
        }
    }
}
