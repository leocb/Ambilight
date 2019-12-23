namespace AmbilightController
{
    partial class ConfigForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ledPanelLeft = new System.Windows.Forms.Panel();
            this.ledPanelTop = new System.Windows.Forms.Panel();
            this.ledPanelRight = new System.Windows.Forms.Panel();
            this.ledPanelBottom = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ledFirstIndex = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ledChangeDirection = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ledCountBottom = new System.Windows.Forms.NumericUpDown();
            this.ledCountRight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ledCountTop = new System.Windows.Forms.NumericUpDown();
            this.ledCountLeft = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ledMode = new DesktopDuplication.Demo.LedModeConfigure();
            this.ledTopIndexLow = new System.Windows.Forms.Label();
            this.ledTopIndexHigh = new System.Windows.Forms.Label();
            this.ledRightIndexLow = new System.Windows.Forms.Label();
            this.ledRightIndexHigh = new System.Windows.Forms.Label();
            this.ledBottomIndexHigh = new System.Windows.Forms.Label();
            this.ledLeftIndexLow = new System.Windows.Forms.Label();
            this.ledLeftIndexHigh = new System.Windows.Forms.Label();
            this.ledBottomIndexLow = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ledBrightness = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledFirstIndex)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledCountBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledCountRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledCountTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledCountLeft)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // ledPanelLeft
            // 
            this.ledPanelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ledPanelLeft.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ledPanelLeft.Location = new System.Drawing.Point(12, 12);
            this.ledPanelLeft.Name = "ledPanelLeft";
            this.ledPanelLeft.Size = new System.Drawing.Size(29, 460);
            this.ledPanelLeft.TabIndex = 4;
            // 
            // ledPanelTop
            // 
            this.ledPanelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ledPanelTop.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ledPanelTop.Location = new System.Drawing.Point(47, 12);
            this.ledPanelTop.Name = "ledPanelTop";
            this.ledPanelTop.Size = new System.Drawing.Size(819, 29);
            this.ledPanelTop.TabIndex = 5;
            // 
            // ledPanelRight
            // 
            this.ledPanelRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ledPanelRight.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ledPanelRight.Location = new System.Drawing.Point(872, 12);
            this.ledPanelRight.Name = "ledPanelRight";
            this.ledPanelRight.Size = new System.Drawing.Size(29, 460);
            this.ledPanelRight.TabIndex = 5;
            // 
            // ledPanelBottom
            // 
            this.ledPanelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ledPanelBottom.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ledPanelBottom.Location = new System.Drawing.Point(47, 443);
            this.ledPanelBottom.Name = "ledPanelBottom";
            this.ledPanelBottom.Size = new System.Drawing.Size(819, 29);
            this.ledPanelBottom.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.ledBrightness);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.ledFirstIndex);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ledChangeDirection);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(47, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 390);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LED Settings";
            // 
            // ledFirstIndex
            // 
            this.ledFirstIndex.Location = new System.Drawing.Point(9, 129);
            this.ledFirstIndex.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ledFirstIndex.Name = "ledFirstIndex";
            this.ledFirstIndex.Size = new System.Drawing.Size(49, 20);
            this.ledFirstIndex.TabIndex = 10;
            this.ledFirstIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "First LED Index:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Direction:";
            // 
            // ledChangeDirection
            // 
            this.ledChangeDirection.Location = new System.Drawing.Point(9, 178);
            this.ledChangeDirection.Name = "ledChangeDirection";
            this.ledChangeDirection.Size = new System.Drawing.Size(108, 23);
            this.ledChangeDirection.TabIndex = 7;
            this.ledChangeDirection.Text = "Clockwise";
            this.ledChangeDirection.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.ledCountBottom, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ledCountRight, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ledCountTop, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ledCountLeft, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(196, 81);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // ledCountBottom
            // 
            this.ledCountBottom.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ledCountBottom.Location = new System.Drawing.Point(73, 58);
            this.ledCountBottom.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ledCountBottom.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ledCountBottom.Name = "ledCountBottom";
            this.ledCountBottom.Size = new System.Drawing.Size(49, 20);
            this.ledCountBottom.TabIndex = 1;
            this.ledCountBottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ledCountBottom.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // ledCountRight
            // 
            this.ledCountRight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ledCountRight.Location = new System.Drawing.Point(144, 30);
            this.ledCountRight.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ledCountRight.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ledCountRight.Name = "ledCountRight";
            this.ledCountRight.Size = new System.Drawing.Size(49, 20);
            this.ledCountRight.TabIndex = 3;
            this.ledCountRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ledCountRight.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Location = new System.Drawing.Point(73, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Count";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledCountTop
            // 
            this.ledCountTop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ledCountTop.Location = new System.Drawing.Point(73, 3);
            this.ledCountTop.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ledCountTop.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ledCountTop.Name = "ledCountTop";
            this.ledCountTop.Size = new System.Drawing.Size(49, 20);
            this.ledCountTop.TabIndex = 0;
            this.ledCountTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ledCountTop.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // ledCountLeft
            // 
            this.ledCountLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ledCountLeft.Location = new System.Drawing.Point(3, 30);
            this.ledCountLeft.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ledCountLeft.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ledCountLeft.Name = "ledCountLeft";
            this.ledCountLeft.Size = new System.Drawing.Size(49, 20);
            this.ledCountLeft.TabIndex = 2;
            this.ledCountLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ledCountLeft.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ledMode);
            this.groupBox2.Location = new System.Drawing.Point(261, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 390);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mode";
            // 
            // ledMode
            // 
            this.ledMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ledMode.Location = new System.Drawing.Point(3, 16);
            this.ledMode.Name = "ledMode";
            this.ledMode.Size = new System.Drawing.Size(599, 371);
            this.ledMode.TabIndex = 0;
            // 
            // ledTopIndexLow
            // 
            this.ledTopIndexLow.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ledTopIndexLow.Location = new System.Drawing.Point(50, 0);
            this.ledTopIndexLow.Name = "ledTopIndexLow";
            this.ledTopIndexLow.Size = new System.Drawing.Size(27, 13);
            this.ledTopIndexLow.TabIndex = 1;
            this.ledTopIndexLow.Text = "0";
            // 
            // ledTopIndexHigh
            // 
            this.ledTopIndexHigh.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ledTopIndexHigh.Location = new System.Drawing.Point(836, 0);
            this.ledTopIndexHigh.Name = "ledTopIndexHigh";
            this.ledTopIndexHigh.Size = new System.Drawing.Size(27, 13);
            this.ledTopIndexHigh.TabIndex = 10;
            this.ledTopIndexHigh.Text = "59";
            this.ledTopIndexHigh.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ledRightIndexLow
            // 
            this.ledRightIndexLow.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ledRightIndexLow.Location = new System.Drawing.Point(874, 0);
            this.ledRightIndexLow.Name = "ledRightIndexLow";
            this.ledRightIndexLow.Size = new System.Drawing.Size(27, 13);
            this.ledRightIndexLow.TabIndex = 11;
            this.ledRightIndexLow.Text = "60";
            this.ledRightIndexLow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledRightIndexHigh
            // 
            this.ledRightIndexHigh.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ledRightIndexHigh.Location = new System.Drawing.Point(873, 471);
            this.ledRightIndexHigh.Name = "ledRightIndexHigh";
            this.ledRightIndexHigh.Size = new System.Drawing.Size(27, 13);
            this.ledRightIndexHigh.TabIndex = 12;
            this.ledRightIndexHigh.Text = "99";
            this.ledRightIndexHigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledBottomIndexHigh
            // 
            this.ledBottomIndexHigh.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ledBottomIndexHigh.Location = new System.Drawing.Point(50, 471);
            this.ledBottomIndexHigh.Name = "ledBottomIndexHigh";
            this.ledBottomIndexHigh.Size = new System.Drawing.Size(27, 13);
            this.ledBottomIndexHigh.TabIndex = 14;
            this.ledBottomIndexHigh.Text = "159";
            // 
            // ledLeftIndexLow
            // 
            this.ledLeftIndexLow.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ledLeftIndexLow.Location = new System.Drawing.Point(13, 471);
            this.ledLeftIndexLow.Name = "ledLeftIndexLow";
            this.ledLeftIndexLow.Size = new System.Drawing.Size(27, 13);
            this.ledLeftIndexLow.TabIndex = 15;
            this.ledLeftIndexLow.Text = "160";
            this.ledLeftIndexLow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledLeftIndexHigh
            // 
            this.ledLeftIndexHigh.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ledLeftIndexHigh.Location = new System.Drawing.Point(13, 0);
            this.ledLeftIndexHigh.Name = "ledLeftIndexHigh";
            this.ledLeftIndexHigh.Size = new System.Drawing.Size(27, 13);
            this.ledLeftIndexHigh.TabIndex = 16;
            this.ledLeftIndexHigh.Text = "199";
            this.ledLeftIndexHigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledBottomIndexLow
            // 
            this.ledBottomIndexLow.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ledBottomIndexLow.Location = new System.Drawing.Point(836, 471);
            this.ledBottomIndexLow.Name = "ledBottomIndexLow";
            this.ledBottomIndexLow.Size = new System.Drawing.Size(27, 13);
            this.ledBottomIndexLow.TabIndex = 17;
            this.ledBottomIndexLow.Text = "100";
            this.ledBottomIndexLow.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Brightness:";
            // 
            // ledBrightness
            // 
            this.ledBrightness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ledBrightness.Location = new System.Drawing.Point(9, 232);
            this.ledBrightness.Maximum = 100;
            this.ledBrightness.Name = "ledBrightness";
            this.ledBrightness.Size = new System.Drawing.Size(193, 45);
            this.ledBrightness.TabIndex = 12;
            this.ledBrightness.TickFrequency = 5;
            this.ledBrightness.Value = 100;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 484);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ledPanelBottom);
            this.Controls.Add(this.ledPanelRight);
            this.Controls.Add(this.ledPanelTop);
            this.Controls.Add(this.ledPanelLeft);
            this.Controls.Add(this.ledBottomIndexLow);
            this.Controls.Add(this.ledLeftIndexHigh);
            this.Controls.Add(this.ledLeftIndexLow);
            this.Controls.Add(this.ledBottomIndexHigh);
            this.Controls.Add(this.ledRightIndexHigh);
            this.Controls.Add(this.ledRightIndexLow);
            this.Controls.Add(this.ledTopIndexHigh);
            this.Controls.Add(this.ledTopIndexLow);
            this.DoubleBuffered = true;
            this.Name = "ConfigForm";
            this.Text = "Ambilight Configurator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDemo_FormClosing);
            this.Shown += new System.EventHandler(this.ConfigForm_Shown);
            this.ResizeBegin += new System.EventHandler(this.FormDemo_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.FormDemo_ResizeEnd);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledFirstIndex)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ledCountBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledCountRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledCountTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledCountLeft)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ledBrightness)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ledPanelLeft;
        private System.Windows.Forms.Panel ledPanelTop;
        private System.Windows.Forms.Panel ledPanelRight;
        private System.Windows.Forms.Panel ledPanelBottom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown ledCountTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ledChangeDirection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown ledCountBottom;
        private System.Windows.Forms.NumericUpDown ledCountRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ledCountLeft;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown ledFirstIndex;
        private System.Windows.Forms.Label label4;
        private DesktopDuplication.Demo.LedModeConfigure ledMode;
        private System.Windows.Forms.TrackBar ledBrightness;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label ledTopIndexLow;
        private System.Windows.Forms.Label ledTopIndexHigh;
        private System.Windows.Forms.Label ledRightIndexLow;
        private System.Windows.Forms.Label ledRightIndexHigh;
        private System.Windows.Forms.Label ledBottomIndexHigh;
        private System.Windows.Forms.Label ledLeftIndexLow;
        private System.Windows.Forms.Label ledLeftIndexHigh;
        private System.Windows.Forms.Label ledBottomIndexLow;
    }
}

