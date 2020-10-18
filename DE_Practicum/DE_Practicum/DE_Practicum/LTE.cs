using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE_Practicum
{
    // Class to find LTE for each method
    public class LTE
    {
        // Arrays taht will contain local errors and values of each method based on previous exact solution
        public double[] e;
        public double[] yLoc;

        // m represents each of the methods
        // m = 1 - Euler method
        // m = 2 - Improved Euler method
        // m = 3 - Runge-Kutta method
        public LTE(double[] yEx, double[] x, double h, int N, int m)
        {
            e = new double[N];
            yLoc = new double[N];

            // Euler method
            if (m == 1)
            {
                for (int i = 0; i < N; i++)
                {
                    try
                    {
                        if (i == 0)
                        {
                            // Initial values are the same
                            yLoc[0] = yEx[0];
                        }
                        else
                        {
                            // For each value of x_i and y_i find y_{i+1} using formula
                            yLoc[i] = yEx[i - 1] + h * (2 * Math.Sqrt(yEx[i - 1]) / x[i - 1]) * (Math.Cos(x[i - 1]) - Math.Sqrt(yEx[i - 1]));

                            // y cannot be negative because it is under square root and x cannot be zero because it is in denominator
                            // in any of htese cases exception will be thrown
                            if (yLoc[i] < 0 || x[i] == 0)
                            {
                                throw new Exception();
                            }
                        }
                        e[i] = Math.Abs(yEx[i] - yLoc[i]);
                    }
                    // Message that will appear in case of error
                    catch
                    {
                        MessageBox.Show("Negative value of y or x = 0.\nTry to increase N.", "Error");
                    }
                }
            }

            // Improved Euler method
            else if (m == 2)
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
                            // Initial values are the same
                            yLoc[0] = yEx[0]; 
                            // First we need to find K_{10} and K_{20} using initial values of x and y 
                            K1[i] = (2 * Math.Sqrt(yEx[i]) / x[i]) * (Math.Cos(x[i]) - Math.Sqrt(yEx[i]));
                            K2[i] = (2 * Math.Sqrt(yEx[i] + h * K1[i]) / (x[i] + h)) * (Math.Cos(x[i] + h) - Math.Sqrt(yEx[i] + h * K1[i]));
                        }
                        else
                        {
                            // Then we can find other values of y, K_{1i} and K_{2i}
                            yLoc[i] = yEx[i - 1] + h / 2 * (K1[i - 1] + K2[i - 1]);
                            K1[i] = (2 * Math.Sqrt(yEx[i]) / x[i]) * (Math.Cos(x[i]) - Math.Sqrt(yEx[i]));
                            K2[i] = (2 * Math.Sqrt(yEx[i] + h * K1[i]) / (x[i] + h)) * (Math.Cos(x[i] + h) - Math.Sqrt(yEx[i] + h * K1[i]));

                            // y cannot be negative because it is under square root and x cannot be zero because it is in denominator
                            // in any of htese cases exception will be thrown
                            if (yLoc[i] < 0 || x[i] == 0)
                            {
                                throw new Exception();
                            }
                        }
                        e[i] = Math.Abs(yEx[i] - yLoc[i]);
                    }
                    // Message that will appear in case of error
                    catch
                    {
                        MessageBox.Show("Negative value of y or x = 0.\nTry to increase N.", "Error");
                    }

                }
            }

            // Runge-Kutta method
            else if (m == 3)
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
                            // Initial values are the same
                            yLoc[0] = yEx[0];
                            // First we need to find K_{10}, K_{20}, K_{30} and K_{40} using initial values of x and y 
                            K1[i] = (2 * Math.Sqrt(yEx[i]) / x[i]) * (Math.Cos(x[i]) - Math.Sqrt(yEx[i]));
                            K2[i] = (2 * Math.Sqrt(yEx[i] + h / 2 * K1[i]) / (x[i] + h / 2)) * (Math.Cos(x[i] + h / 2) - Math.Sqrt(yEx[i] + h / 2 * K1[i]));
                            K3[i] = (2 * Math.Sqrt(yEx[i] + h / 2 * K2[i]) / (x[i] + h / 2)) * (Math.Cos(x[i] + h / 2) - Math.Sqrt(yEx[i] + h / 2 * K2[i]));
                            K4[i] = (2 * Math.Sqrt(yEx[i] + h * K3[i]) / (x[i] + h)) * (Math.Cos(x[i] + h) - Math.Sqrt(yEx[i] + h * K3[i]));
                        }
                        else
                        {
                            // Then we can find other values of y, K_{1i}, K_{2i}, K_{3i} and K_{4i}
                            yLoc[i] = yEx[i - 1] + h / 6 * (K1[i - 1] + 2 * K2[i - 1] + 2 * K3[i - 1] + K4[i - 1]);
                            K1[i] = (2 * Math.Sqrt(yEx[i]) / x[i]) * (Math.Cos(x[i]) - Math.Sqrt(yEx[i]));
                            K2[i] = (2 * Math.Sqrt(yEx[i] + h / 2 * K1[i]) / (x[i] + h / 2)) * (Math.Cos(x[i] + h / 2) - Math.Sqrt(yEx[i] + h / 2 * K1[i]));
                            K3[i] = (2 * Math.Sqrt(yEx[i] + h / 2 * K2[i]) / (x[i] + h / 2)) * (Math.Cos(x[i] + h / 2) - Math.Sqrt(yEx[i] + h / 2 * K2[i]));
                            K4[i] = (2 * Math.Sqrt(yEx[i] + h * K3[i]) / (x[i] + h)) * (Math.Cos(x[i] + h) - Math.Sqrt(yEx[i] + h * K3[i]));

                            // y cannot be negative because it is under square root and x cannot be zero because it is in denominator
                            // in any of htese cases exception will be thrown
                            if (yLoc[i] < 0 || x[i] == 0)
                            {
                                throw new Exception();
                            }
                        }
                        e[i] = Math.Abs(yEx[i] - yLoc[i]);
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
}
