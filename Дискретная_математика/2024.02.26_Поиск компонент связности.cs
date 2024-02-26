using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace поиск_компонент_связности
{
    class V
    {
        private string fVer1;
        private string fVer2;

        public V(string aVer1, string aVer2)
        {
            fVer1 = aVer1;
            fVer2 = aVer2;
        }

        public string Ver1
        {
            get { return fVer1; }
            set { fVer1 = value; }
        }

        public string Ver2
        {
            get { return fVer2; }
            set { fVer2 = value; }
        }
    }
    class Program
    {
        static void Main()
        {
            List<string> white = new List<string>();
            List<string> black = new List<string>();
            List<V> vr = new List<V>();

            vr.Add(new V("1", "2"));
            vr.Add(new V("1", "6"));
            vr.Add(new V("3", "2"));
            vr.Add(new V("10", "2"));
            vr.Add(new V("3", "4"));
            vr.Add(new V("10", "4"));
            vr.Add(new V("10", "vershina_5"));

            vr.Add(new V("7", "8"));
            vr.Add(new V("7", "9"));
            vr.Add(new V("8", "9"));

            vr.Add(new V("18", "89"));

            vr.Add(new V("70", "70"));

            // Создание списка всех вершин
            for (int i = 0; i < vr.Count; i++)
            {
                if (!(white.Contains(vr[i].Ver1)))
                {
                    white.Add(vr[i].Ver1);
                }

                if (!(white.Contains(vr[i].Ver2)))
                {
                    white.Add(vr[i].Ver2);
                }
            }

            // Формирование компонент связности
            while (white.Count !=0)
            {
                black.Add(white[0]);   
                white.RemoveAt(0);

                // Формирование текущей компоненты связности
                for (int i = 0; i < black.Count; i++)
                {
                    for (int j = 0; j < vr.Count; j++)
                    {

                        if ((black[i] == vr[j].Ver1) && (!(black.Contains(vr[j].Ver2))))
                        {
                            black.Add(vr[j].Ver2);
                            white.Remove(vr[j].Ver2);

                        }
                        else if ((black[i] == vr[j].Ver2) && (!(black.Contains(vr[j].Ver1))))
                        {
                            black.Add(vr[j].Ver1);
                            white.Remove(vr[j].Ver1);
                        }
                    }
                }

                string str = String.Join(" ", black);
                
                Console.WriteLine(str);
                black.Clear();
            }

            Console.ReadKey();
        }
    }
}