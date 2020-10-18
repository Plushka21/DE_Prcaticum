using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE_Practicum
{
    public class Euler: Grid
    {
        public Euler(int N, double x0, double y0, double X) : base(N, x0, y0, X)
        {
            try
            {
                double h = (X - x0) / N;
                for (int i = 1; i < N; i++)
                {
                    y[i] = y[i - 1] + h * (2 * Math.Sqrt(y[i - 1]) / x[i - 1]) * (Math.Cos(x[i - 1]) - Math.Sqrt(y[i - 1]));
                    if (y[i] < 0)
                    {
                        throw new Exception(); 
                    }
                }
            }
            catch
            {
                MessageBox.Show("Negative value of y.\nTry to increase N.","Error");
            }   
        }
    }
}
