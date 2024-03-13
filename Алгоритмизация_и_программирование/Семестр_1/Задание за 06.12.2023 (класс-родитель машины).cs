using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_за_06._12._2023
{
    class Car
    {
        private string fNomer;
        private string fMarka;
        private int fGodvjp;
        private int[] fTehosmotr;

        public Car (string aNomer, string aMarka, int aGodvjp, int[] aTehosmotr)
        {
            fNomer = aNomer;
            fMarka = aMarka;
            fGodvjp = aGodvjp;
            fTehosmotr = aTehosmotr;
        }

        public string Nomer
        {
            get { return fNomer; }
            set { fNomer = value; }
        }

        public string Marka
        {
            get { return fMarka; }
            set { fMarka = value; }
        }

        public int Godvjp
        {
            get { return fGodvjp; }
            set { fGodvjp = value; }
        }

        public int[] Tehosmotr
        {
            get { return fTehosmotr; }
            set { fTehosmotr = value; }
        }
    }


    class Legkovoy: Car
    {
        private string fTip_kuzova;
        private int fPower;

        public Legkovoy(string aNomer, string aMarka, int aGodvjp, int[] aTehosmotr, string aTip_kuzova, int aPower): base(aNomer, aMarka, aGodvjp, aTehosmotr)
        {
            fTip_kuzova = aTip_kuzova;
            fPower = aPower;
        }

        public string Tip_Kuzova
        {
            get { return fTip_kuzova; }
            set { fTip_kuzova = value; }
        }

        public int Power
        {
            get { return fPower; }
            set { fPower = value; }
        }

        public bool Otborkuzov (string aKuzov)
        {
            if (aKuzov == fTip_kuzova)
                return true;
            else
                return false;
        }
    }

    class Gruzovoy: Car
    {
        private int fGruzopod;

        public Gruzovoy(string aNomer, string aMarka, int aGodvjp, int[] aTehosmotr, int aGruzopod): base(aNomer, aMarka, aGodvjp, aTehosmotr)
        {
            fGruzopod = aGruzopod;
        }

        public int Gruzopod
        {
            get { return fGruzopod; }
            set { fGruzopod = value; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Legkovoy[] pLegkovoys = new Legkovoy[3];
            pLegkovoys[0] = new Legkovoy("Номер 1", "Toyota", 2003, new int[] { 2008, 2011, 2014, 2017, 2020, 2023 }, "Седан", 89);
            pLegkovoys[1] = new Legkovoy("Номер 3", "Nissan", 2015, new int[] { 2017, 2020, 2023 }, "Универсал", 109);
            pLegkovoys[2] = new Legkovoy("Номер 4", "Toyota", 1989, new int[] { 1995, 2000, 2008, 2011, 2014, 2017, 2020, 2023 }, "Седан", 125);

            Gruzovoy[] pGruzovoys = new Gruzovoy[6];
            pGruzovoys[0] = new Gruzovoy("Номер 5", "ГАЗ-53", 2010, new int[] { 2011, 2014, 2017, 2020, 2023 }, 3);
            pGruzovoys[1] = new Gruzovoy("Номер 2", "ЗИЛ-130", 2010, new int[] { 2011, 2014, 2017, 2020, 2023 }, 5);
            pGruzovoys[2] = new Gruzovoy("Номер 6", "КАМАЗ 1", 2010, new int[] { 2011, 2014, 2017, 2020, 2023 }, 10);
            pGruzovoys[3] = new Gruzovoy("Номер 7", "КАМАЗ 2", 2010, new int[] { 2011, 2014, 2017, 2020, 2023 }, 20);
            pGruzovoys[4] = new Gruzovoy("Номер 8", "ГАЗель", 2009, new int[] { 2010, 2014, 2017, 2020, 2023 }, 2);
            pGruzovoys[5] = new Gruzovoy("Номер 9", "УРАЛ", 2010, new int[] { 2011, 2014, 2017, 2020, 2023 }, 15);

            Console.WriteLine("Введите тип кузова");
            string K = Console.ReadLine();
            for (int i = 0; i < pLegkovoys.Length; i++) 
            {               
                if (pLegkovoys[i].Otborkuzov(K))
                {
                    Console.WriteLine($"Номер машины: {pLegkovoys[i].Nomer}");
                    Console.WriteLine($"Марка машины: {pLegkovoys[i].Marka}");
                    Console.WriteLine($"Тип кузова: {pLegkovoys[i].Tip_Kuzova}");
                    Console.WriteLine($"Мощность двигателя: {pLegkovoys[i].Power}");

                }
                    
            }

            Console.WriteLine("Введите массу груза (в тоннах)");
            int m = int.Parse(Console.ReadLine());

            int[] gh = new int[6];
            for (int i = 0; i < gh.Length; i++)
            {
                gh[i] = pGruzovoys[i].Gruzopod;
            }
            Array.Sort(gh);
            Array.Reverse(gh);
            int r = m;
            int j = 0;
            int count = 0;
            do
            {
                r = r - gh[j];
                count++;
                j++;
            } while (r > 0 && j < gh.Length);
            Console.WriteLine($"Задействовано {count} машин");
            if (r > 0)
                Console.WriteLine($"Но машин всё равно не хватило");

            Console.WriteLine("Введите номер автомобиля");
            string N = Console.ReadLine();
            for (int i =0; i < pLegkovoys.Length; i++)
            {
                if (N == pLegkovoys[i].Nomer)
                    Console.WriteLine("Легковой автомобиль");
            }
            for (int i = 0; i < pGruzovoys.Length; i++)
            {
                if (N == pGruzovoys[i].Nomer)
                    Console.WriteLine("Грузовой автомобиль");
            }

            Console.ReadKey();

        }
    }
}
