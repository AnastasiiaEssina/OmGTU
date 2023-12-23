using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_за_05._12._2023
{
    class Car
    {
        private string fName;
        private int fGodvjp;
        private string fColor;        
        private string[] fVladelcj;
        private int[] fTehosmotr;

        public Car()
        {
            fName = "";
            fGodvjp = -1;
            fColor = "Нет";
            fVladelcj = new string[0];
            fTehosmotr = new int[10];
        }

        public Car(string aName, int aGodvjp, string aColor, string[] aVladelcj, int [] aTehocmotr)
        {
            fName = aName;
            fGodvjp = aGodvjp;
            fColor = aColor;
            fVladelcj = aVladelcj;
            fTehosmotr = aTehocmotr;
        }

        public string Name
        {
            get { return fName; }
            set { fName = value; }
        }

        public int Godvjp
        {
            get { return fGodvjp; }
            set { fGodvjp = value; }
        }

        public string Color
        {
            get { return fColor; }
            set { fColor = value; }
        }

        public string[] Vladelcj
        {
            get { return fVladelcj; }
            set { fVladelcj = value; }
        }

        public int[] Tehosmotr

        {
            get { return fTehosmotr; }
            set { fTehosmotr = value; }
        }

        public bool OtborGod (int aGod)
        {
            if (fGodvjp == aGod)
                return true;
            else
                return false;
        }

        public bool OtborTehosmotr (int aTehosmotr)
        {
            bool bl = false;
            for (int i = 0; i < fTehosmotr.Length; i++)
            {
                if (fTehosmotr[i] == aTehosmotr)                
                    bl = true;                
            }
            return bl;
        }

        public string PosledniyVladelec()
        {
            return fVladelcj[fVladelcj.Length - 1];
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car[] Mashinj = new Car[4];
            Mashinj[0] = new Car("Toyota", 2003, "Серый", new string[] { "ФИО1", "ФИО2" }, new int[] { 2005, 2009, 2011, 2013, 2015, 2017, 2019 });
            Mashinj[1] = new Car("Nissan", 2015, "Синий", new string[] { "ФИО3", "ФИО4" }, new int[] { 2015, 2017, 2019, 2021, 2023 });
            Mashinj[2] = new Car("ВАЗ", 1980, "Желтый", new string[] { "ФИО4", "ФИО3" }, new int[] { 1990, 1995, 2000, 2005, 2010, 2015, 2020 });
            Mashinj[3] = new Car("ГАЗ", 1995, "Белый", new string[] { "ФИО2", "ФИО1" }, new int[] { 2003, 2006, 2009, 2012, 2015, 2018, 2021 });

            Console.WriteLine("Введите год выпуска автомобиля");
            int g = int.Parse(Console.ReadLine());
            for (int i = 0; i < Mashinj.Length; i++)
            {
                if (Mashinj[i].OtborGod(g))
                {
                    Console.WriteLine($"Автомобиль марки {Mashinj[i].Name}");
                    Console.WriteLine($"{Mashinj[i].Godvjp} года выпуска");
                    Console.WriteLine($"Цвет: {Mashinj[i].Color}");
                    Console.Write("Владельцы: ");
                    for (int j = 0; j < Mashinj[i].Vladelcj.Length; j++)
                    {
                        Console.Write(Mashinj[i].Vladelcj[j]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();


                    Console.Write("Техосмотры: ");
                    for (int j = 0; j < Mashinj[i].Tehosmotr.Length; j++) 
                    {
                        Console.Write(Mashinj[i].Tehosmotr[j]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Введите год техосмотра автомобиля");
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < Mashinj.Length; i++)
            {
                if (Mashinj[i].OtborTehosmotr(t))
                {
                    Console.WriteLine($"Автомобиль марки {Mashinj[i].Name}");
                    Console.WriteLine($"{Mashinj[i].Godvjp} года выпуска");
                    Console.WriteLine($"Цвет: {Mashinj[i].Color}");
                    Console.Write("Владельцы: ");
                    for (int j = 0; j < Mashinj[i].Vladelcj.Length; j++)
                    {
                        Console.Write(Mashinj[i].Vladelcj[j]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();


                    Console.Write("Техосмотры: ");
                    for (int j = 0; j < Mashinj[i].Tehosmotr.Length; j++)
                    {
                        Console.Write(Mashinj[i].Tehosmotr[j]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Последние владельцы");
            for (int i = 0; i < Mashinj.Length; i++)
            {
                Console.WriteLine($"Автомобиль марки {Mashinj[i].Name}");
                Console.WriteLine($"{Mashinj[i].Godvjp} года выпуска");
                Console.WriteLine($"Настоящий владелец - {Mashinj[i].PosledniyVladelec()}");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
