namespace AmbilightController
{
    partial class LedDisplayForm
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
            this.ledDisplay = new AmbilightController.LedDisplay();
            this.SuspendLayout();
            // 
            // ledDisplay
            // 
            this.ledDisplay.AutoSize = true;
            this.ledDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ledDisplay.Location = new System.Drawing.Point(10, 10);
            this.ledDisplay.Name = "ledDisplay";
            this.ledDisplay.Size = new System.Drawing.Size(780, 430);
            this.ledDisplay.TabIndex = 0;
            // 
            // LedDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ledDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LedDisplayForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "LedDisplayForm";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public LedDisplay ledDisplay;
    }
}