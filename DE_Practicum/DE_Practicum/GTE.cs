using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_Practicum
{
    // Class to find GTE for each method 
    class GTE
    {
        // Array that will contain values of error
        public double[] e;

        // yEx contains values of exact solution, y values of current solution, N number of steps
        public GTE(double[] yEx, double[] y, int N)
        {
            e = new double[N];
            //
            for (int i = 0; i < N; i++)
            {
                // Fill array calculating GTE at each point
                e[i] = Math.Abs(yEx[i] - y[i]);
            }
        }
    }
}
