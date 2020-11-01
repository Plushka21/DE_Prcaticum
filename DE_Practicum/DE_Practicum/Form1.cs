using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DE_Practicum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double parse(String line)
        {
            String pi = "";
            double num = 0;
            int frac = 0;
            foreach (char c in line)
            {
                if (Char.IsDigit(c))
                {
                    if (frac == 0)
                    {
                        num = num * 10 + Int32.Parse(c.ToString());
                    }
                    else
                    {
                        num = num + Double.Parse(c.ToString()) / frac;
                        frac *= 10;
                    }
                }
                else if (Char.IsPunctuation(c))
                {
                    frac = 10;
                }
                else
                {
                    pi += c;
                }
            }

            if (pi == "pi" || pi == "PI" || pi == "Pi")
            {
                if (num == 0)
                {
                    num = Math.PI;
                }
                else
                {
                    num *= Math.PI;
                }
            }
            return num;
        }

        // Buttons
        private void Plot_Click(object sender, EventArgs e)
        {
            try
            {
                chart1Sol.Visible = true;
                chart2GTE.Visible = false;
                chart3Errors.Visible = false;

                // Since input may have number and pi we read line as string and then divide it into components
                String in_x0 = textBox_x0.Text;
                double x0 = parse(in_x0);

                String in_X = textBox_X.Text;
                double X = parse(in_X);

                if (x0 == 0 || X < x0)
                {
                    throw new Exception();
                }

                int N = Int32.Parse(textBox_N.Text);
                double y0 = Double.Parse(textBox_y0.Text);

                int N0 = Int32.Parse(textBox_N0.Text);
                int MaxN = Int32.Parse(textBox_MaxN.Text);
                if (MaxN <= N0)
                {
                    throw new Exception();
                }

                // Solutions
                Exact es = new Exact(N, x0, y0, X);
                Euler ES = new Euler(N, x0, y0, X);
                ImprovedEuler IE = new ImprovedEuler(N, x0, y0, X);
                RungeKutta RK = new RungeKutta(N, x0, y0, X);
                //

                // chart1 with graph of solutions
                chart1Sol.Series[0].Points.DataBindXY(es.x, es.y);
                chart1Sol.Series[1].Points.DataBindXY(ES.x, ES.y);
                chart1Sol.Series[2].Points.DataBindXY(IE.x, IE.y);
                chart1Sol.Series[3].Points.DataBindXY(RK.x, RK.y);

                chart1Sol.ChartAreas[0].AxisX.Minimum = x0;
                chart1Sol.ChartAreas[0].AxisX.Maximum = X;
                //

                // GTE
                GTE GES = new GTE(es.y, ES.y, N);
                GTE GIE = new GTE(es.y, IE.y, N);
                GTE GRK = new GTE(es.y, RK.y, N);
                //

                //chart 2 with GTE
                chart2GTE.Series[0].Points.DataBindXY(ES.x, GES.e);
                chart2GTE.Series[1].Points.DataBindXY(IE.x, GIE.e);
                chart2GTE.Series[2].Points.DataBindXY(RK.x, GRK.e);

                chart2GTE.ChartAreas[0].AxisX.Minimum = x0;
                chart2GTE.ChartAreas[0].AxisX.Maximum = X;
                //

                // Max Errors
                MaxError MES = new MaxError(N0, MaxN, 1, x0, y0, X);
                MaxError MIE = new MaxError(N0, MaxN, 2, x0, y0, X);
                MaxError MRK = new MaxError(N0, MaxN, 3, x0, y0, X);
                //

                // cahrt3 with max errors
                int[] n = new int[MaxN - N0];
                for (int i = N0; i < MaxN; i++)
                {
                    n[i - N0] = i;
                }

                chart3Errors.Series[0].Points.DataBindXY(n, MES.MaxGTE);
                chart3Errors.Series[1].Points.DataBindXY(n, MIE.MaxGTE);
                chart3Errors.Series[2].Points.DataBindXY(n, MRK.MaxGTE);

                chart3Errors.ChartAreas[0].AxisX.Minimum = N0;
                chart3Errors.ChartAreas[0].AxisX.Maximum = MaxN;
                //
            }

            catch
            {
                MessageBox.Show("Wrong input.\nPlease change initial values");
            }
        }

        private void buttonGTE_Click(object sender, EventArgs e)
        {
            Plot_Click(sender, e);
            chart1Sol.Visible = false;
            chart2GTE.Visible = true;
            chart3Errors.Visible = false;
        }

        private void MaxErrors_Click(object sender, EventArgs e)
        {
            Plot_Click(sender, e);
            chart1Sol.Visible = false;
            chart2GTE.Visible = false;
            chart3Errors.Visible = true;
        }
        //

        private void Chart_Shown(object sender, EventArgs e)
        {
            Plot_Click(sender, e);
        }


        private void checkBox_Exact_CheckedChanged(object sender, EventArgs e)
        {
            chart1Sol.Series[0].Enabled = checkBox_Exact.Checked;
        }

        private void checkBox_Euler_CheckedChanged(object sender, EventArgs e)
        {
            chart1Sol.Series[1].Enabled = checkBox_Euler.Checked;
            chart2GTE.Series[0].Enabled = checkBox_Euler.Checked;
            chart3Errors.Series[0].Enabled = checkBox_Euler.Checked;
        }

        private void checkBox_Impr_CheckedChanged(object sender, EventArgs e)
        {
            chart1Sol.Series[2].Enabled = checkBox_Impr.Checked;
            chart2GTE.Series[1].Enabled = checkBox_Impr.Checked;
            chart3Errors.Series[1].Enabled = checkBox_Impr.Checked;
        }

        private void checkBox_RK_CheckedChanged(object sender, EventArgs e)
        {
            chart1Sol.Series[3].Enabled = checkBox_RK.Checked;
            chart2GTE.Series[2].Enabled = checkBox_RK.Checked;
            chart3Errors.Series[2].Enabled = checkBox_RK.Checked;
        }
    }
}
