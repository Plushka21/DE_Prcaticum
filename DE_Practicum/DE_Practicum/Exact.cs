using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE_Practicum
{
    public class Exact : Grid
    {
        public Exact(int N, double x0, double y0, double X) : base(N, x0, y0, X)
        {
            try
            {
                if (x0 == 0)
                {
                    throw new Exception();
                }
                for (int i = 1; i < N; i++)
                {
                    y[i] = Math.Pow(((Math.Sin(x[i]) + c) / (x[i])), 2);
                }
            }
            catch
            {
                MessageBox.Show("x0 cannot be 0.\n Change input please", "Error");
            }

        }
    }
}
