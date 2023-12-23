using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_за_22._11._2023
{
    class Student
    {
        // свойства
        private string fFIO = "";
        private int fGod_rohzd = 0;
        private string fNomer_grup = "";

        public Student(string aFIO, int aGod_rohzd, string aNomer_grup)
        {
            this.fFIO = aFIO;
            this.fGod_rohzd = aGod_rohzd;
            this.fNomer_grup = aNomer_grup;
        }

        public string FIO
        {
            get { return fFIO; }
            set { fFIO = value; }
        }
        public int God_rohzd
        {
            set { fGod_rohzd = value; }
            get { return fGod_rohzd; }
        }
        public string Nomer_grup
        {
            get { return fNomer_grup; }
            set { fNomer_grup = value; }
        }

        public bool OtborGodRohzd(int aGodRozhd)
        {
            if (fGod_rohzd == aGodRozhd)
                return true;
            else
                return false;
        }

        public bool OtborGruppa(string aGruppa)
        {
            if (fNomer_grup == aGruppa)
                return true;
            else
                return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[7];
            students[0] = new Student("Фамилия1 Имя1 Отчество1", 2004, "Группа 1");
            students[1] = new Student("Фамилия2 Имя2 Отчество2", 2003, "Группа 1");
            students[2] = new Student("Фамилия3 Имя3 Отчество3", 2004, "Группа 2");
            students[3] = new Student("Фамилия4 Имя4 Отчество4", 2005, "Группа 2");
            students[4] = new Student("Фамилия5 Имя5 Отчество5", 2005, "Группа 1");
            students[5] = new Student("Фамилия6 Имя6 Отчество6", 2005, "Группа 1");
            students[6] = new Student("Фамилия7 Имя7 Отчество7", 2006, "Группа 2");

            Console.WriteLine("Введите год рождения студента");
            int g = int.Parse(Console.ReadLine());
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].OtborGodRohzd(g))
                    Console.WriteLine(students[i].FIO);
            }

            Console.WriteLine("Введите номер группы студента");
            string gr = Console.ReadLine();
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].OtborGruppa(gr))
                    Console.WriteLine(students[i].FIO);
            }

            Console.ReadKey();
        }
    }
}
