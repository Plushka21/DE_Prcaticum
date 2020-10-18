using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DE_Practicum
{
    // Class to find values of solution using Improved Euler method
    class ImprovedEuler : ApproxSol
    {
        public ImprovedEuler(int N, double x0, double y0, double X) : base(N, x0, y0, X)
        {
            // Arrays that will contain values of K_{1i} and K_{2i}
            double[] K1 = new double[N];
            double[] K2 = new double[N];

            // For each value of x_i and y_i find y_{i+1} using formula
            for (int i = 0; i < N; i++)
            {
                try
                {
                    if (i == 0)
                    {
                        // First we need to find K_{10} and K_{20} using initial values of x and y 
                        K1[i] = (2 * Math.Sqrt(y[i]) / x[i]) * (Math.Cos(x[i]) - Math.Sqrt(y[i]));
                        K2[i] = (2 * Math.Sqrt(y[i] + h * K1[i]) / (x[i] + h)) * (Math.Cos(x[i] + h) - Math.Sqrt(y[i] + h * K1[i]));
                    }
                    else
                    {
                        // Then we can find other values of y, K_{1i} and K_{2i}
                        y[i] = y[i - 1] + h / 2 * (K1[i - 1] + K2[i - 1]);
                        K1[i] = (2 * Math.Sqrt(y[i]) / x[i]) * (Math.Cos(x[i]) - Math.Sqrt(y[i]));
                        K2[i] = (2 * Math.Sqrt(y[i] + h * K1[i]) / (x[i] + h)) * (Math.Cos(x[i] + h) - Math.Sqrt(y[i] + h * K1[i]));

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
