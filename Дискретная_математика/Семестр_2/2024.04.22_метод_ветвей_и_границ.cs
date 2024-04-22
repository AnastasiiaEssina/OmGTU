using System;
class HelloWorld {
  static void Main() {
    //int[,] Matrix = new int[5, 5];

    int[,] Matrix =  { { 9999, 41, 17, 23, 32 }, { 13, 9999,  45, 12, 37 }, { 80, 45, 9999, 50, 64}, { 23, 12,50, 9999, 67 }, {32, 37, 64, 67, 9999 }};
    
    //нахождение минимума по строкам
    int min;
    int a = 0;
    for (int i = 0; i < 5; i++ )
    {
        min = Matrix[i, 0];
        for (int j = 0; j < 5; j++)
        {
            if (Matrix[i, j] < min)
            {
                min = Matrix[i, j];
            }
        }
        for (int j = 0; j < 5; j++)
        {
            Matrix[i, j] = Matrix[i, j] - min;
        }
        a+=min;
    }
    
    //нахождение минимума по столбцам
    for (int i = 0; i < 5; i++ )
    {
        min = Matrix[0, i];
        for (int j = 0; j < 5; j++)
        {
            if (Matrix[j, i] < min)
            {
                min = Matrix[j, i];
            }
        }
        for (int j = 0; j < 5; j++)
        {
            ///Matrix[j, i] = Matrix[j, i] - min;
        }
        a+=min;
    }
  }
}
