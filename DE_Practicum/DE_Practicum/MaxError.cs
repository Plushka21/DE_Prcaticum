using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_Practicum
{
    class MaxError
    {
        public double[] MaxGTE;

        public MaxError(int N0, int MaxN, int method, double x0, double y0, double X)
        {
            MaxGTE = new double[MaxN - N0];
            double[] Apy;
            double[] Exy;
            GTE gte;

            if (method == 1)
            {
                for (int i = N0; i < MaxN; i++)
                {
                    Apy = new Euler(i, x0, y0, X).y;
                    Exy = new Exact(i, x0, y0, X).y;
                    gte = new GTE(Exy, Apy, i);
                    MaxGTE[i - N0] = gte.e.Max();
                }
            }
            else if (method == 2)
            {
                for (int i = N0; i < MaxN; i++)
                {
                    Apy = new ImprovedEuler(i, x0, y0, X).y;
                    Exy = new Exact(i, x0, y0, X).y;
                    gte = new GTE(Exy, Apy, i);
                    MaxGTE[i - N0] = gte.e.Max();
                }
            }
            else if (method == 3)
            {
                for (int i = N0; i < MaxN; i++)
                {
                    Apy = new RungeKutta(i, x0, y0, X).y;
                    Exy = new Exact(i, x0, y0, X).y;
                    gte = new GTE(Exy, Apy, i);
                    MaxGTE[i - N0] = gte.e.Max();
                }
            }
        }
    }
}