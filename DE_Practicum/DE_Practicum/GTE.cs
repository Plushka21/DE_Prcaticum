using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_Practicum
{
    class GTE
    {
        public double[] e;
        public GTE(double[] yEx, double[] y, int N)
        {
            e = new double[N];
            for (int i = 0; i < N; i++)
            {
                e[i] = Math.Abs(yEx[i] - y[i]);
            }
        }
    }
}
