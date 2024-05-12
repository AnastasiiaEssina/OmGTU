using System.Linq;
class TrapezoidalRule{
    public static double Solve(Func<Double, Double> f, double a, double b, double dx){
        double summ = 0;
        double epsilon = 10E-7;
        if (!double.IsNormal(a)) {throw new ArgumentException ("a is not a number");}
        if (!double.IsNormal(b)) {throw new ArgumentException ("b is not a number");}
        if (dx < epsilon) {throw new ArgumentException ("dx меньше epsilon");}
        double current_posx = a;
        int dist_count = Convert.ToInt32(Math.Ceiling((b-a)/dx)); //кол-во отрезков
        /*for (int i = 0; i <= dist_count; i++){

            current_posx = a + dx * i;

            double p = Math.Abs(((f(current_posx)+f(current_posx+dx))*dx)/2);
            summ += p;

        }*/
        double[] apoints = Enumerable.Range(0, dist_count+1).Select(x => a + dx * x).ToArray();
        summ = apoints.Sum(x => Math.Abs(((f(x)+f(x+dx))*dx)/2));
        
        return summ;
    }
}


Func<double, double> f = (double x) => -x*x + 9;
double a = 1;
double b = 4;
double dx = 0.1;
Console.WriteLine(TrapezoidalRule.Solve(f,a,b,dx));
