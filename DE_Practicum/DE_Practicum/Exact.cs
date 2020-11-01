using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE_Practicum
{
    // Class to find values of exact solution 
    public class Exact : Grid
    {
        // Array that will contain values y of a solution
        public double[] y;
        public Exact(int N, double x0, double y0, double X) : base(N, x0, y0, X)
        {
            y = new double[N];
            for (int i = 0; i < N; i++)
            {
                try
                {
                    // x[i] cannot be zero because it is in denominator
                    if (x[i] == 0)
                    {
                        throw new Exception();
                    }
                    // Otherwise find value y using exact solution
                    else
                    {
                        y[i] = Math.Pow((Math.Sin(x[i]) + c) / (x[i]), 2);
                    }
                }
                // Message that will appear in case x is negative number
                catch
                {
                    MessageBox.Show("x cannot be 0.\n Change input please", "Error");
                }
            }
        }
    }
}
