using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE_Practicum
{
    // Class to find all values of x and constant c using x0, X and N
    abstract public class Grid
    {
        // Array that will contain values of x
        public double[] x;
        // Number of steps
        public int N;
        // Step size
        public double h;
        // Constant from exact solution
        public double c;

        public Grid(int N, double x0, double y0, double X)
        {
            try
            {
                h = (X - x0) / N;
                x = new double[N];
                // Fromula for constant is derived from exact solution
                c = Math.Abs(x0 * Math.Sqrt(y0) - Math.Sin(x0));

                // If step size or y0 are negeative or x0 = 0 exception will be thrown
                if (h <= 0 || y0 < 0 || x0 == 0)
                {
                    throw new Exception();
                }
                // Otherwise we can find all values of x using step size
                for (int i = 0; i < N; i++)
                {
                    if (i == 0)
                    {
                        x[i] = x0;
                    }
                    else
                    {
                        x[i] = x[i - 1] + h;
                    }
                }
            }
            // Message that will appear in case of error
            catch
            {
                MessageBox.Show("Wrong input");
            }
        }
    }
}
