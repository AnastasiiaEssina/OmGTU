using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_за_20._12._2023
{
    class Tovar
    {
        private string fName;
        private string fEd_izmer;
        private int fStoim;

        public Tovar(string AName, string aEd_izmer, int aStoim)
        {
            fName = AName;
            fEd_izmer = aEd_izmer;
            fStoim = aStoim;
        }

        public string Name
        {
            get { return fName; }
            set { fName = value; }
        }

        public string Ed_izmer
        {
            get { return fEd_izmer; }
            set { fEd_izmer = value; }
        }

        public int Stoim
        {
            get { return fStoim; }
            set { fStoim = value; }
        }
    }
    class Product : Tovar
    {
        private int fSrok_godn;
        private int fKkal;
        private int fBelki;
        private int fZhirj;
        private int fUglevodj;

        public Product(string AName, string aEd_izmer, int aStoim, int aSrok_godn, int aKkal, int aBelki, int aZhirj, int aUglevodj) : base(AName, aEd_izmer, aStoim)
        {
            fSrok_godn = aSrok_godn;
            fKkal = aKkal;
            fBelki = aBelki;
            fZhirj = aZhirj;
            fUglevodj = aUglevodj;
        }

        public int Srok_godn
        {
            get { return fSrok_godn; }
            set { fSrok_godn = value; }
        }

        public int Kkal
        {
            get { return fKkal; }
            set { fKkal = value; }
        }

        public int Belki
        {
            get { return fBelki; }
            set { fBelki = value; }
        }

        public int Zhirj
        {
            get { return fZhirj; }
            set { fZhirj = value; }
        }

        public int Uglevodj
        {
            get { return fUglevodj; }
            set { fUglevodj = value; }
        }

        public void print()
        {
            Console.WriteLine($"Продукт {Name} ({Ed_izmer}) {Stoim} руб.");
            Console.WriteLine($"Срок годности: {Srok_godn} дней");
            Console.WriteLine($"{Kkal} калорий");
            Console.WriteLine($"Состав: белки - {Belki}, жиры - {Zhirj}, углеводы - {Uglevodj}\n");
        }
    }

    class Stroymat : Tovar
    {
        private string fVid_materiala;

        public Stroymat(string AName, string aEd_izmer, int aStoim, string aVid_materiala) : base(AName, aEd_izmer, aStoim)
        {
            fVid_materiala = aVid_materiala;
        }

        public string Vid_materiala
        {
            get { return fVid_materiala; }
            set { fVid_materiala = value; }
        }

        public void print()
        {
            Console.WriteLine($"Продукт {Name} ({Ed_izmer}) {Stoim} руб.");
            Console.WriteLine($"Вид материала: {Vid_materiala}\n");
        }
    }


    class Program

    {
        static void Main(string[] args)
        {
            Product[] pproducts = new Product[3];
            pproducts[0] = new Product("Молоко", "Литр", 70, 14, 100, 50, 40, 20);
            pproducts[1] = new Product("Хлеб", "шт", 50, 2, 100, 50, 40, 20);
            pproducts[2] = new Product("Масло", "Грамм", 109, 300, 100, 50, 40, 20);

            Stroymat[] pstroymats = new Stroymat[3];
            pstroymats[0] = new Stroymat("Доски", "куб. м", 4000, "Дерево");
            pstroymats[1] = new Stroymat("Арматура", "кг", 79, "Железо");
            pstroymats[2] = new Stroymat("Кирпич", "шт", 25, "Глина");

            for (int i = 0; i < pproducts.Length; i++)
            {
                pproducts[i].print();
            }

            for (int i = 0; i < pstroymats.Length; i++)
            {
                pstroymats[i].print();
            }

            Console.ReadKey();
        }
    }
}

