using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_Practicum
{
    // Class for approximate solutions
    abstract public class ApproxSol : Grid
    {
        // Array that will contain values of  approximate solutions
        public double[] y;
        public ApproxSol(int N, double x0, double y0, double X) : base(N, x0, y0, X)
        {
            y = new double[N];
            // initial value of y is y0
            y[0] = y0;
        }
    }
}
