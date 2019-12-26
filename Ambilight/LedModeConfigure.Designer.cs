namespace AmbilightController
{
    partial class LedModeConfigure
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabScreenCapture = new System.Windows.Forms.TabPage();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tabFixed = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRainbow = new System.Windows.Forms.TabPage();
            this.tabPulse = new System.Windows.Forms.TabPage();
            this.tabSparkle = new System.Windows.Forms.TabPage();
            this.tabMouseXY = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabScreenCapture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Interval = 200D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.Maximum = 200D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Interval = 30D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.Maximum = 90D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.Interval = 10D;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.ScaleBreakStyle.Spacing = 1D;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.Bisque;
            chartArea1.AxisY2.Interval = 10D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(6, 186);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(520, 112);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // tabScreenCapture
            // 
            this.tabScreenCapture.BackColor = System.Drawing.SystemColors.Control;
            this.tabScreenCapture.Controls.Add(this.checkBox2);
            this.tabScreenCapture.Controls.Add(this.checkBox1);
            this.tabScreenCapture.Controls.Add(this.label6);
            this.tabScreenCapture.Controls.Add(this.numericUpDown3);
            this.tabScreenCapture.Controls.Add(this.label5);
            this.tabScreenCapture.Controls.Add(this.numericUpDown2);
            this.tabScreenCapture.Controls.Add(this.radioButton2);
            this.tabScreenCapture.Controls.Add(this.radioButton1);
            this.tabScreenCapture.Controls.Add(this.label4);
            this.tabScreenCapture.Controls.Add(this.label3);
            this.tabScreenCapture.Controls.Add(this.numericUpDown1);
            this.tabScreenCapture.Controls.Add(this.label2);
            this.tabScreenCapture.Controls.Add(this.chart1);
            this.tabScreenCapture.Location = new System.Drawing.Point(4, 22);
            this.tabScreenCapture.Name = "tabScreenCapture";
            this.tabScreenCapture.Padding = new System.Windows.Forms.Padding(3);
            this.tabScreenCapture.Size = new System.Drawing.Size(532, 304);
            this.tabScreenCapture.TabIndex = 0;
            this.tabScreenCapture.Text = "Screen Capture";
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(181, 275);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(193, 17);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Text = "Monitor DXGI Capture Performance";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(138, 117);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Pull points to center";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(138, 62);
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown3.TabIndex = 16;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown3.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Points separation";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(138, 88);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown2.TabIndex = 14;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(217, 10);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(157, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "60 FPS (Higher CPU usage)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(138, 10);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "30 FPS";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Capture Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Offset from screen border";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(138, 36);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Screen points per LED";
            // 
            // tabFixed
            // 
            this.tabFixed.BackColor = System.Drawing.SystemColors.Control;
            this.tabFixed.Location = new System.Drawing.Point(4, 22);
            this.tabFixed.Name = "tabFixed";
            this.tabFixed.Padding = new System.Windows.Forms.Padding(3);
            this.tabFixed.Size = new System.Drawing.Size(532, 304);
            this.tabFixed.TabIndex = 1;
            this.tabFixed.Text = "Fixed";
            this.tabFixed.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabScreenCapture);
            this.tabControl1.Controls.Add(this.tabRainbow);
            this.tabControl1.Controls.Add(this.tabPulse);
            this.tabControl1.Controls.Add(this.tabSparkle);
            this.tabControl1.Controls.Add(this.tabFixed);
            this.tabControl1.Controls.Add(this.tabMouseXY);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(540, 330);
            this.tabControl1.TabIndex = 10;
            // 
            // tabRainbow
            // 
            this.tabRainbow.BackColor = System.Drawing.SystemColors.Control;
            this.tabRainbow.Location = new System.Drawing.Point(4, 22);
            this.tabRainbow.Name = "tabRainbow";
            this.tabRainbow.Size = new System.Drawing.Size(532, 304);
            this.tabRainbow.TabIndex = 2;
            this.tabRainbow.Text = "Rainbow";
            // 
            // tabPulse
            // 
            this.tabPulse.BackColor = System.Drawing.SystemColors.Control;
            this.tabPulse.Location = new System.Drawing.Point(4, 22);
            this.tabPulse.Name = "tabPulse";
            this.tabPulse.Size = new System.Drawing.Size(532, 304);
            this.tabPulse.TabIndex = 3;
            this.tabPulse.Text = "Pulse";
            // 
            // tabSparkle
            // 
            this.tabSparkle.BackColor = System.Drawing.SystemColors.Control;
            this.tabSparkle.Location = new System.Drawing.Point(4, 22);
            this.tabSparkle.Name = "tabSparkle";
            this.tabSparkle.Size = new System.Drawing.Size(532, 304);
            this.tabSparkle.TabIndex = 5;
            this.tabSparkle.Text = "Sparkle";
            // 
            // tabMouseXY
            // 
            this.tabMouseXY.BackColor = System.Drawing.SystemColors.Control;
            this.tabMouseXY.Location = new System.Drawing.Point(4, 22);
            this.tabMouseXY.Name = "tabMouseXY";
            this.tabMouseXY.Size = new System.Drawing.Size(532, 304);
            this.tabMouseXY.TabIndex = 4;
            this.tabMouseXY.Text = "Mouse XY";
            // 
            // LedModeConfigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "LedModeConfigure";
            this.Size = new System.Drawing.Size(540, 330);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabScreenCapture.ResumeLayout(false);
            this.tabScreenCapture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabScreenCapture;
        private System.Windows.Forms.TabPage tabFixed;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRainbow;
        private System.Windows.Forms.TabPage tabPulse;
        private System.Windows.Forms.TabPage tabMouseXY;
        private System.Windows.Forms.TabPage tabSparkle;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
    }
}
