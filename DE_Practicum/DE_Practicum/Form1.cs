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
    public partial class Solutions : Form
    {
        public Solutions()
        {
            InitializeComponent();
        }

        public double parse(String line)
        {
            String pi = "";
            double num = 0;
            foreach (char c in line)
            {
                if (Char.IsDigit(c))
                {
                    num = num * 10 + Int32.Parse(c.ToString());
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
                chart2LTE.Visible = false;
                chart3GTE.Visible = false;
                chart4Errors.Visible = false;

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

                // Solutions
                Exact es = new Exact(N, x0, y0, X);
                Euler ES = new Euler(N, x0, y0, X);
                ImprovedEuler IE = new ImprovedEuler(N, x0, y0, X);
                RungeKutta RK = new RungeKutta(N, x0, y0, X);
                //

                // GTE
                GTE GES = new GTE(es.y, ES.y, N);
                GTE GIE = new GTE(es.y, IE.y, N);
                GTE GRK = new GTE(es.y, RK.y, N);
                // 

                // chart1 with graph of solutions
                chart1Sol.Series[0].Points.DataBindXY(es.x, es.y);
                chart1Sol.Series[1].Points.DataBindXY(ES.x, ES.y);
                chart1Sol.Series[2].Points.DataBindXY(IE.x, IE.y);
                chart1Sol.Series[3].Points.DataBindXY(RK.x, RK.y);

                chart1Sol.ChartAreas[0].AxisX.Minimum = x0;
                chart1Sol.ChartAreas[0].AxisX.Maximum = X;

                //chart 3 with GTE
                chart3GTE.Series[0].Points.DataBindXY(ES.x, GES.e);
                chart3GTE.Series[1].Points.DataBindXY(IE.x, GIE.e);
                chart3GTE.Series[2].Points.DataBindXY(RK.x, GRK.e);

                chart3GTE.ChartAreas[0].AxisX.Minimum = x0;
                chart3GTE.ChartAreas[0].AxisX.Maximum = X;
            }

            catch
            {
                MessageBox.Show("Wrong input");
            }
        }

        private void buttonLTE_Click(object sender, EventArgs e)
        {
            chart1Sol.Visible = false;
            chart2LTE.Visible = true;
            chart3GTE.Visible = false;
            chart4Errors.Visible = false;
        }

        private void buttonGTE_Click(object sender, EventArgs e)
        {
            Plot_Click(sender, e);
            chart1Sol.Visible = false;
            chart2LTE.Visible = false;
            chart3GTE.Visible = true;
            chart4Errors.Visible = false;
        }

        private void MaxErrors_Click(object sender, EventArgs e)
        {
            chart1Sol.Visible = false;
            chart2LTE.Visible = false;
            chart3GTE.Visible = false;
            chart4Errors.Visible = true;
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
            chart3GTE.Series[0].Enabled = checkBox_Euler.Checked;
        }

        private void checkBox_Impr_CheckedChanged(object sender, EventArgs e)
        {
            chart1Sol.Series[2].Enabled = checkBox_Impr.Checked;
            chart3GTE.Series[1].Enabled = checkBox_Impr.Checked;
        }

        private void checkBox_RK_CheckedChanged(object sender, EventArgs e)
        {
            chart1Sol.Series[3].Enabled = checkBox_RK.Checked;
            chart3GTE.Series[2].Enabled = checkBox_RK.Checked;
        }

    }
}
