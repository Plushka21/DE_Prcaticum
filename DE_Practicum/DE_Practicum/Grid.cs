using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_Practicum
{
    abstract public class Grid
    {
        public double[] x;
        public double[] y;
        public int N;
        public double c;
        public double h;

        public Grid(int N, double x0, double y0, double X)
        {
            h = (X - x0) / N;
            c = Math.Abs(Math.PI * Math.Sqrt(y0) - Math.Sin(x0));

            x = new double[N];
            y = new double[N];

            for (int i = 0; i < N; i++)
            {
                if (i == 0)
                {
                    x[i] = x0;
                    y[i] = y0;
                }
                else
                {
                    x[i] = x[i - 1] + h;
                }
            }
        }
    }
}
