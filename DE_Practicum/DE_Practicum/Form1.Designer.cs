namespace DE_Practicum
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chart3Errors = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2GTE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1Sol = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBox_RK = new System.Windows.Forms.CheckBox();
            this.checkBox_Impr = new System.Windows.Forms.CheckBox();
            this.checkBox_Euler = new System.Windows.Forms.CheckBox();
            this.checkBox_Exact = new System.Windows.Forms.CheckBox();
            this.textBox_MaxN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Plot = new System.Windows.Forms.Button();
            this.textBox_N0 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonGTE = new System.Windows.Forms.Button();
            this.MaxErrors = new System.Windows.Forms.Button();
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_y0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_x0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3Errors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2GTE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1Sol)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chart3Errors);
            this.splitContainer1.Panel1.Controls.Add(this.chart2GTE);
            this.splitContainer1.Panel1.Controls.Add(this.chart1Sol);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.checkBox_RK);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox_Impr);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox_Euler);
            this.splitContainer1.Panel2.Controls.Add(this.checkBox_Exact);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_MaxN);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.Plot);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_N0);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.buttonGTE);
            this.splitContainer1.Panel2.Controls.Add(this.MaxErrors);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_N);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_X);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_y0);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_x0);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1574, 1129);
            this.splitContainer1.SplitterDistance = 1186;
            this.splitContainer1.TabIndex = 0;
            // 
            // chart3Errors
            // 
            chartArea1.Name = "ChartArea1";
            this.chart3Errors.ChartAreas.Add(chartArea1);
            this.chart3Errors.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chart3Errors.Legends.Add(legend1);
            this.chart3Errors.Location = new System.Drawing.Point(0, 0);
            this.chart3Errors.Name = "chart3Errors";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Lime;
            series1.Legend = "Legend1";
            series1.Name = "Eueler";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.Name = "Improved Euler";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "Runge-Kutta";
            this.chart3Errors.Series.Add(series1);
            this.chart3Errors.Series.Add(series2);
            this.chart3Errors.Series.Add(series3);
            this.chart3Errors.Size = new System.Drawing.Size(1186, 1129);
            this.chart3Errors.TabIndex = 3;
            this.chart3Errors.Text = "chart1";
            // 
            // chart2GTE
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2GTE.ChartAreas.Add(chartArea2);
            this.chart2GTE.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart2GTE.Legends.Add(legend2);
            this.chart2GTE.Location = new System.Drawing.Point(0, 0);
            this.chart2GTE.Name = "chart2GTE";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Lime;
            series4.LabelBorderWidth = 3;
            series4.Legend = "Legend1";
            series4.LegendText = "Euler";
            series4.Name = "Euler method";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Blue;
            series5.LabelBorderWidth = 3;
            series5.Legend = "Legend1";
            series5.LegendText = "Improved Euler";
            series5.Name = "Improved Euler";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Red;
            series6.LabelBorderWidth = 3;
            series6.Legend = "Legend1";
            series6.LegendText = "Runge-Kutta";
            series6.Name = "Runge-Kutta";
            this.chart2GTE.Series.Add(series4);
            this.chart2GTE.Series.Add(series5);
            this.chart2GTE.Series.Add(series6);
            this.chart2GTE.Size = new System.Drawing.Size(1186, 1129);
            this.chart2GTE.TabIndex = 2;
            this.chart2GTE.Text = "chart1";
            // 
            // chart1Sol
            // 
            chartArea3.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.BlanchedAlmond;
            chartArea3.Name = "ChartArea1";
            this.chart1Sol.ChartAreas.Add(chartArea3);
            this.chart1Sol.Cursor = System.Windows.Forms.Cursors.Default;
            this.chart1Sol.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.chart1Sol.Legends.Add(legend3);
            this.chart1Sol.Location = new System.Drawing.Point(0, 0);
            this.chart1Sol.Name = "chart1Sol";
            series7.BorderColor = System.Drawing.Color.Black;
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.Yellow;
            series7.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series7.LabelForeColor = System.Drawing.Color.BlanchedAlmond;
            series7.Legend = "Legend1";
            series7.LegendText = "Exact";
            series7.Name = "Exact solution";
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.Lime;
            series8.Legend = "Legend1";
            series8.LegendText = "Euler";
            series8.Name = "Euler\'s method";
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Color = System.Drawing.Color.Blue;
            series9.Legend = "Legend1";
            series9.LegendText = "Improved Euler";
            series9.Name = "Improved Euler\'s method";
            series10.BorderWidth = 3;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Color = System.Drawing.Color.Red;
            series10.Legend = "Legend1";
            series10.LegendText = "Runge-Kutta";
            series10.Name = "Runge-Kutta method";
            this.chart1Sol.Series.Add(series7);
            this.chart1Sol.Series.Add(series8);
            this.chart1Sol.Series.Add(series9);
            this.chart1Sol.Series.Add(series10);
            this.chart1Sol.Size = new System.Drawing.Size(1186, 1129);
            this.chart1Sol.TabIndex = 0;
            this.chart1Sol.Text = "chart1";
            this.chart1Sol.Visible = false;
            // 
            // checkBox_RK
            // 
            this.checkBox_RK.AutoSize = true;
            this.checkBox_RK.Checked = true;
            this.checkBox_RK.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_RK.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox_RK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_RK.Location = new System.Drawing.Point(0, 792);
            this.checkBox_RK.Name = "checkBox_RK";
            this.checkBox_RK.Size = new System.Drawing.Size(384, 46);
            this.checkBox_RK.TabIndex = 39;
            this.checkBox_RK.Text = "Runge-Kutta method";
            this.checkBox_RK.UseVisualStyleBackColor = true;
            this.checkBox_RK.CheckedChanged += new System.EventHandler(this.checkBox_RK_CheckedChanged);
            // 
            // checkBox_Impr
            // 
            this.checkBox_Impr.AutoSize = true;
            this.checkBox_Impr.Checked = true;
            this.checkBox_Impr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Impr.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox_Impr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_Impr.Location = new System.Drawing.Point(0, 746);
            this.checkBox_Impr.Name = "checkBox_Impr";
            this.checkBox_Impr.Size = new System.Drawing.Size(384, 46);
            this.checkBox_Impr.TabIndex = 38;
            this.checkBox_Impr.Text = "Improved Euler method";
            this.checkBox_Impr.UseVisualStyleBackColor = true;
            this.checkBox_Impr.CheckedChanged += new System.EventHandler(this.checkBox_Impr_CheckedChanged);
            // 
            // checkBox_Euler
            // 
            this.checkBox_Euler.AutoSize = true;
            this.checkBox_Euler.Checked = true;
            this.checkBox_Euler.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Euler.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox_Euler.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_Euler.Location = new System.Drawing.Point(0, 700);
            this.checkBox_Euler.Name = "checkBox_Euler";
            this.checkBox_Euler.Size = new System.Drawing.Size(384, 46);
            this.checkBox_Euler.TabIndex = 37;
            this.checkBox_Euler.Text = "Euler method";
            this.checkBox_Euler.UseVisualStyleBackColor = true;
            this.checkBox_Euler.CheckedChanged += new System.EventHandler(this.checkBox_Euler_CheckedChanged);
            // 
            // checkBox_Exact
            // 
            this.checkBox_Exact.AutoSize = true;
            this.checkBox_Exact.Checked = true;
            this.checkBox_Exact.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Exact.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox_Exact.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_Exact.Location = new System.Drawing.Point(0, 654);
            this.checkBox_Exact.Name = "checkBox_Exact";
            this.checkBox_Exact.Size = new System.Drawing.Size(384, 46);
            this.checkBox_Exact.TabIndex = 36;
            this.checkBox_Exact.Text = "Exact solution";
            this.checkBox_Exact.UseVisualStyleBackColor = true;
            this.checkBox_Exact.CheckedChanged += new System.EventHandler(this.checkBox_Exact_CheckedChanged);
            // 
            // textBox_MaxN
            // 
            this.textBox_MaxN.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_MaxN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_MaxN.Location = new System.Drawing.Point(0, 605);
            this.textBox_MaxN.Margin = new System.Windows.Forms.Padding(7);
            this.textBox_MaxN.Name = "textBox_MaxN";
            this.textBox_MaxN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_MaxN.Size = new System.Drawing.Size(384, 49);
            this.textBox_MaxN.TabIndex = 35;
            this.textBox_MaxN.Text = "100";
            this.textBox_MaxN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(0, 545);
            this.label6.Margin = new System.Windows.Forms.Padding(7);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5);
            this.label6.Size = new System.Drawing.Size(384, 60);
            this.label6.TabIndex = 34;
            this.label6.Text = "MAX N";
            // 
            // Plot
            // 
            this.Plot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Plot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Plot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Plot.Location = new System.Drawing.Point(0, 889);
            this.Plot.Name = "Plot";
            this.Plot.Padding = new System.Windows.Forms.Padding(5);
            this.Plot.Size = new System.Drawing.Size(384, 80);
            this.Plot.TabIndex = 33;
            this.Plot.Text = "Plot";
            this.Plot.UseVisualStyleBackColor = false;
            this.Plot.Click += new System.EventHandler(this.Plot_Click);
            // 
            // textBox_N0
            // 
            this.textBox_N0.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_N0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_N0.Location = new System.Drawing.Point(0, 496);
            this.textBox_N0.Margin = new System.Windows.Forms.Padding(7);
            this.textBox_N0.Name = "textBox_N0";
            this.textBox_N0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_N0.Size = new System.Drawing.Size(384, 49);
            this.textBox_N0.TabIndex = 28;
            this.textBox_N0.Text = "50";
            this.textBox_N0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(0, 436);
            this.label5.Margin = new System.Windows.Forms.Padding(7);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(384, 60);
            this.label5.TabIndex = 27;
            this.label5.Text = "N₀";
            // 
            // buttonGTE
            // 
            this.buttonGTE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonGTE.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonGTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGTE.Location = new System.Drawing.Point(0, 969);
            this.buttonGTE.Name = "buttonGTE";
            this.buttonGTE.Padding = new System.Windows.Forms.Padding(5);
            this.buttonGTE.Size = new System.Drawing.Size(384, 80);
            this.buttonGTE.TabIndex = 26;
            this.buttonGTE.Text = "GTE";
            this.buttonGTE.UseVisualStyleBackColor = false;
            this.buttonGTE.Click += new System.EventHandler(this.buttonGTE_Click);
            // 
            // MaxErrors
            // 
            this.MaxErrors.BackColor = System.Drawing.Color.Aqua;
            this.MaxErrors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MaxErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxErrors.Location = new System.Drawing.Point(0, 1049);
            this.MaxErrors.Name = "MaxErrors";
            this.MaxErrors.Padding = new System.Windows.Forms.Padding(5);
            this.MaxErrors.Size = new System.Drawing.Size(384, 80);
            this.MaxErrors.TabIndex = 25;
            this.MaxErrors.Text = "MaxErrors";
            this.MaxErrors.UseVisualStyleBackColor = false;
            this.MaxErrors.Click += new System.EventHandler(this.MaxErrors_Click);
            // 
            // textBox_N
            // 
            this.textBox_N.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_N.Location = new System.Drawing.Point(0, 387);
            this.textBox_N.Margin = new System.Windows.Forms.Padding(7);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_N.Size = new System.Drawing.Size(384, 49);
            this.textBox_N.TabIndex = 20;
            this.textBox_N.Text = "20";
            this.textBox_N.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 327);
            this.label3.Margin = new System.Windows.Forms.Padding(7);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(384, 60);
            this.label3.TabIndex = 19;
            this.label3.Text = "N";
            // 
            // textBox_X
            // 
            this.textBox_X.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_X.Location = new System.Drawing.Point(0, 278);
            this.textBox_X.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_X.Size = new System.Drawing.Size(384, 49);
            this.textBox_X.TabIndex = 18;
            this.textBox_X.Text = "5pi";
            this.textBox_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(7);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(384, 60);
            this.label2.TabIndex = 17;
            this.label2.Text = "X";
            // 
            // textBox_y0
            // 
            this.textBox_y0.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_y0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_y0.Location = new System.Drawing.Point(0, 169);
            this.textBox_y0.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.textBox_y0.Name = "textBox_y0";
            this.textBox_y0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_y0.Size = new System.Drawing.Size(384, 49);
            this.textBox_y0.TabIndex = 12;
            this.textBox_y0.Text = "2";
            this.textBox_y0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(7);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(7);
            this.label4.Size = new System.Drawing.Size(384, 60);
            this.label4.TabIndex = 11;
            this.label4.Text = "y₀";
            // 
            // textBox_x0
            // 
            this.textBox_x0.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_x0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_x0.Location = new System.Drawing.Point(0, 60);
            this.textBox_x0.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.textBox_x0.Name = "textBox_x0";
            this.textBox_x0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_x0.Size = new System.Drawing.Size(384, 49);
            this.textBox_x0.TabIndex = 1;
            this.textBox_x0.Text = "pi";
            this.textBox_x0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(7);
            this.label1.Size = new System.Drawing.Size(384, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "x₀";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 1129);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(1600, 1200);
            this.Name = "Form1";
            this.Text = "Solutions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Chart_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3Errors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2GTE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1Sol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1Sol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_x0;
        private System.Windows.Forms.TextBox textBox_y0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_N;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGTE;
        private System.Windows.Forms.Button MaxErrors;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2GTE;
        private System.Windows.Forms.TextBox textBox_N0;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Plot;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3Errors;
        private System.Windows.Forms.TextBox textBox_MaxN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox_RK;
        private System.Windows.Forms.CheckBox checkBox_Impr;
        private System.Windows.Forms.CheckBox checkBox_Euler;
        private System.Windows.Forms.CheckBox checkBox_Exact;
    }
}

