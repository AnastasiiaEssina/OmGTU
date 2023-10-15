using System;
class HelloWorld {
  static void Main() {
    
    int x = 3;
    int y = 4;
    int l = 5;
    int c1 = 10;
    int c2 = 4;
    int c3 = 7;
    int c4 = 6;
    int c5 = 6;
    int c6 = 3;
    int mx, mn, st;
    int p = 2 * (x+y);
    
    //вычисление вспомогательных стоимостей
    int Remont = c1;
    int Rekonstr = c2 + c3;
    int Obnovlen = c2 + c6 + c5 + c4;
    
    //если самый дешевый вариант - ремонт
    if  (Remont <= Rekonstr && Remont <= Obnovlen)
        {
            if (x >= y)
            {
                mx = x;
                mn = y;
            }
            else 
            {
                mx = y;
                mn = x;
            }
                
            if (mx >= l) //если длинная сторона дома больше старой стены 
            {
                st = l*c1 + (p-l)*(c4+c5);
            }
            else
            {
                int ost = l-mx;
                
                if (Rekonstr <= Obnovlen)
                {
                    if (ost <= 2*mn + mx) // если остатка не хватит
                        st = mx*c1 + ost*Rekonstr + (p-l)*(c4+c5);
                    else
                        st = mx*c1 + (p-mx)*Rekonstr + (l-p)*(c2+c6);
                }
                else
                {
                    st = mx*c1 + ost*(c2+c6) + (p-mx)*(c4+c5); 
                }
            }
        }
    else
    {
        if (Rekonstr <= Obnovlen) // если реконструкция самая дешевая
        {
            if (l <= p) // если остатков от старой стены не останется 
                st = l*c3 + (p-l)*(c4+c5) + l*c2;
            else 
                st = (l-p)*c6 + p*c3 + l*c2;
        }
        else // если обновление самое дешевое
        {
            st = l*(c2+c6) + p*(c4+c5);
        }
    }  
    
    Console.WriteLine(st);
  }
}