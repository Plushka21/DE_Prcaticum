using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE_Practicum
{
    // Class to find values of solution using Runge-Kutta method
    class RungeKutta : ApproxSol
    {
        public RungeKutta(int N, double x0, double y0, double X) : base(N, x0, y0, X)
        {
            double[] K1 = new double[N];
            double[] K2 = new double[N];
            double[] K3 = new double[N];
            double[] K4 = new double[N];

            // For each value of x_i and y_i find y_{i+1} using formula
            for (int i = 0; i < N; i++)
            {
                try
                {
                    if (i == 0)
                    {
                        // First we need to find K_{10}, K_{20}, K_{30} and K_{40} using initial values of x and y 
                        K1[i] = (2 * Math.Sqrt(y[i]) / x[i]) * (Math.Cos(x[i]) - Math.Sqrt(y[i]));
                        K2[i] = (2 * Math.Sqrt(y[i] + h / 2 * K1[i]) / (x[i] + h / 2)) * (Math.Cos(x[i] + h / 2) - Math.Sqrt(y[i] + h / 2 * K1[i]));
                        K3[i] = (2 * Math.Sqrt(y[i] + h / 2 * K2[i]) / (x[i] + h / 2)) * (Math.Cos(x[i] + h / 2) - Math.Sqrt(y[i] + h / 2 * K2[i]));
                        K4[i] = (2 * Math.Sqrt(y[i] + h * K3[i]) / (x[i] + h)) * (Math.Cos(x[i] + h) - Math.Sqrt(y[i] + h * K3[i]));
                    }
                    else
                    {
                        // Then we can find other values of y, K_{1i}, K_{2i}, K_{3i} and K_{4i}
                        y[i] = y[i - 1] + h / 6 * (K1[i - 1] + 2 * K2[i - 1] + 2 * K3[i - 1] + K4[i - 1]);
                        K1[i] = (2 * Math.Sqrt(y[i]) / x[i]) * (Math.Cos(x[i]) - Math.Sqrt(y[i]));
                        K2[i] = (2 * Math.Sqrt(y[i] + h / 2 * K1[i]) / (x[i] + h / 2)) * (Math.Cos(x[i] + h / 2) - Math.Sqrt(y[i] + h / 2 * K1[i]));
                        K3[i] = (2 * Math.Sqrt(y[i] + h / 2 * K2[i]) / (x[i] + h / 2)) * (Math.Cos(x[i] + h / 2) - Math.Sqrt(y[i] + h / 2 * K2[i]));
                        K4[i] = (2 * Math.Sqrt(y[i] + h * K3[i]) / (x[i] + h)) * (Math.Cos(x[i] + h) - Math.Sqrt(y[i] + h * K3[i]));

                        // y cannot be negative because it is under square root and x cannot be zero because it is in denominator
                        // in any of htese cases exception will be thrown
                        if (y[i] < 0 || x[i] == 0)
                        {
                            throw new Exception();
                        }
                    }
                }
                // Message that will appear in case of error
                catch
                {
                    MessageBox.Show("Negative value of y or x = 0.\nTry to increase N.", "Error");
                }
            }
        }
    }
}