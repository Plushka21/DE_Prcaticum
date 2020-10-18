using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DE_Practicum
{
    // Class to find values of solution using Euler method
    public class Euler : ApproxSol
    {
        public Euler(int N, double x0, double y0, double X) : base(N, x0, y0, X)
        {
            for (int i = 1; i < N; i++)
            {
                try
                {
                    // For each value of x_i and y_i find y_{i+1} using formula
                    y[i] = y[i - 1] + h * (2 * Math.Sqrt(y[i - 1]) / x[i - 1]) * (Math.Cos(x[i - 1]) - Math.Sqrt(y[i - 1]));
                    
                    // y cannot be negative because it is under square root and x cannot be zero because it is in denominator
                    // in any of htese cases exception will be thrown
                    if (y[i] < 0 || x[i] == 0)
                    {
                        throw new Exception();
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
