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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ledSettingsApply = new System.Windows.Forms.Button();
            this.ledBrightnessBar = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.ledFirstIndexOffsetControl = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ledChangeDirectionButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ledCountBottomControl = new System.Windows.Forms.NumericUpDown();
            this.ledCountRightControl = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ledCountTopControl = new System.Windows.Forms.NumericUpDown();
            this.ledCountLeftControl = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledBrightnessBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledFirstIndexOffsetControl)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledCountBottomControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledCountRightControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledCountTopControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledCountLeftControl)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.ledSettingsApply);
            this.groupBox1.Controls.Add(this.ledBrightnessBar);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.ledFirstIndexOffsetControl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ledChangeDirectionButton);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 376);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LED Settings";
            // 
            // ledSettingsApply
            // 
            this.ledSettingsApply.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ledSettingsApply.Location = new System.Drawing.Point(9, 283);
            this.ledSettingsApply.Name = "ledSettingsApply";
            this.ledSettingsApply.Size = new System.Drawing.Size(190, 43);
            this.ledSettingsApply.TabIndex = 13;
            this.ledSettingsApply.Text = "Apply";
            this.ledSettingsApply.UseVisualStyleBackColor = true;
            this.ledSettingsApply.Click += new System.EventHandler(this.ledSettingsApply_Click);
            // 
            // ledBrightnessBar
            // 
            this.ledBrightnessBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ledBrightnessBar.Location = new System.Drawing.Point(9, 232);
            this.ledBrightnessBar.Maximum = 100;
            this.ledBrightnessBar.Name = "ledBrightnessBar";
            this.ledBrightnessBar.Size = new System.Drawing.Size(193, 45);
            this.ledBrightnessBar.TabIndex = 12;
            this.ledBrightnessBar.TickFrequency = 5;
            this.ledBrightnessBar.Value = 100;
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
            // ledFirstIndexOffsetControl
            // 
            this.ledFirstIndexOffsetControl.Location = new System.Drawing.Point(9, 129);
            this.ledFirstIndexOffsetControl.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ledFirstIndexOffsetControl.Name = "ledFirstIndexOffsetControl";
            this.ledFirstIndexOffsetControl.Size = new System.Drawing.Size(49, 20);
            this.ledFirstIndexOffsetControl.TabIndex = 10;
            this.ledFirstIndexOffsetControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "First LED Index offset:";
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
            // ledChangeDirectionButton
            // 
            this.ledChangeDirectionButton.Location = new System.Drawing.Point(9, 178);
            this.ledChangeDirectionButton.Name = "ledChangeDirectionButton";
            this.ledChangeDirectionButton.Size = new System.Drawing.Size(108, 23);
            this.ledChangeDirectionButton.TabIndex = 7;
            this.ledChangeDirectionButton.Text = "Clockwise";
            this.ledChangeDirectionButton.UseVisualStyleBackColor = true;
            this.ledChangeDirectionButton.Click += new System.EventHandler(this.ledChangeDirection_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.ledCountBottomControl, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ledCountRightControl, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ledCountTopControl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ledCountLeftControl, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(196, 81);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // ledCountBottomControl
            // 
            this.ledCountBottomControl.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ledCountBottomControl.Location = new System.Drawing.Point(73, 58);
            this.ledCountBottomControl.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ledCountBottomControl.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ledCountBottomControl.Name = "ledCountBottomControl";
            this.ledCountBottomControl.Size = new System.Drawing.Size(49, 20);
            this.ledCountBottomControl.TabIndex = 1;
            this.ledCountBottomControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ledCountBottomControl.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // ledCountRightControl
            // 
            this.ledCountRightControl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ledCountRightControl.Location = new System.Drawing.Point(144, 30);
            this.ledCountRightControl.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ledCountRightControl.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ledCountRightControl.Name = "ledCountRightControl";
            this.ledCountRightControl.Size = new System.Drawing.Size(49, 20);
            this.ledCountRightControl.TabIndex = 3;
            this.ledCountRightControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ledCountRightControl.Value = new decimal(new int[] {
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
            // ledCountTopControl
            // 
            this.ledCountTopControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ledCountTopControl.Location = new System.Drawing.Point(73, 3);
            this.ledCountTopControl.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ledCountTopControl.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ledCountTopControl.Name = "ledCountTopControl";
            this.ledCountTopControl.Size = new System.Drawing.Size(49, 20);
            this.ledCountTopControl.TabIndex = 0;
            this.ledCountTopControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ledCountTopControl.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // ledCountLeftControl
            // 
            this.ledCountLeftControl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ledCountLeftControl.Location = new System.Drawing.Point(3, 30);
            this.ledCountLeftControl.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ledCountLeftControl.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ledCountLeftControl.Name = "ledCountLeftControl";
            this.ledCountLeftControl.Size = new System.Drawing.Size(49, 20);
            this.ledCountLeftControl.TabIndex = 2;
            this.ledCountLeftControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ledCountLeftControl.Value = new decimal(new int[] {
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
            this.groupBox2.Location = new System.Drawing.Point(226, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 376);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mode";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 400);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ambilight Configurator";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigForm_FormClosing);
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.Shown += new System.EventHandler(this.ConfigForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledBrightnessBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledFirstIndexOffsetControl)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ledCountBottomControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledCountRightControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledCountTopControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ledCountLeftControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown ledCountTopControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ledChangeDirectionButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown ledCountBottomControl;
        private System.Windows.Forms.NumericUpDown ledCountRightControl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ledCountLeftControl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown ledFirstIndexOffsetControl;
        private System.Windows.Forms.Label label4;
        private LedModeConfigure ledMode;
        private System.Windows.Forms.TrackBar ledBrightnessBar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button ledSettingsApply;
    }
}

