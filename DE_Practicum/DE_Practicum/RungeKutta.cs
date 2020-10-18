using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE_Practicum
{
    class RungeKutta : Grid
    {
        public RungeKutta(int N, double x0, double y0, double X) : base(N, x0, y0, X)
        {
            try
            {
                double h = (X - x0) / N;
                double[] K1 = new double[N];
                double[] K2 = new double[N];
                double[] K3 = new double[N];
                double[] K4 = new double[N];
                for (int i = 0; i < N; i++)
                {
                    if (i == 0)
                    {
                        K1[i] = (2 * Math.Sqrt(y[i]) / x[i]) * (Math.Cos(x[i]) - Math.Sqrt(y[i]));
                        K2[i] = (2 * Math.Sqrt(y[i] + h / 2 * K1[i]) / (x[i] + h / 2)) * (Math.Cos(x[i] + h / 2) - Math.Sqrt(y[i] + h / 2 * K1[i]));
                        K3[i] = (2 * Math.Sqrt(y[i] + h / 2 * K2[i]) / (x[i] + h / 2)) * (Math.Cos(x[i] + h / 2) - Math.Sqrt(y[i] + h / 2 * K2[i]));
                        K4[i] = (2 * Math.Sqrt(y[i] + h * K3[i]) / (x[i] + h)) * (Math.Cos(x[i] + h) - Math.Sqrt(y[i] + h * K3[i]));
                    }
                    else
                    {
                        y[i] = y[i - 1] + h / 6 * (K1[i - 1] + 2 * K2[i - 1] + 2 * K3[i - 1] + K4[i - 1]);
                        K1[i] = (2 * Math.Sqrt(y[i]) / x[i]) * (Math.Cos(x[i]) - Math.Sqrt(y[i]));
                        K2[i] = (2 * Math.Sqrt(y[i] + h / 2 * K1[i]) / (x[i] + h / 2)) * (Math.Cos(x[i] + h / 2) - Math.Sqrt(y[i] + h / 2 * K1[i]));
                        K3[i] = (2 * Math.Sqrt(y[i] + h / 2 * K2[i]) / (x[i] + h / 2)) * (Math.Cos(x[i] + h / 2) - Math.Sqrt(y[i] + h / 2 * K2[i]));
                        K4[i] = (2 * Math.Sqrt(y[i] + h * K3[i]) / (x[i] + h)) * (Math.Cos(x[i] + h) - Math.Sqrt(y[i] + h * K3[i]));

                        if (y[i] < 0)
                        {
                            throw new Exception();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Negative value of y.\nTry to increase N.", "Error");
            }
        }
    }
}