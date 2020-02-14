namespace CalculatorGUI
{
    partial class ExtrapolationFrm
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
            this.btnExtrapFrm = new System.Windows.Forms.Button();
            this.lblExtrapFrm = new System.Windows.Forms.Label();
            this.txtExtrapFrm = new System.Windows.Forms.TextBox();
            this.lstExtrap = new System.Windows.Forms.ListBox();
            this.btnDegRad = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.extrapolationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quadraticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interpolationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExtrapFrm
            // 
            this.btnExtrapFrm.Location = new System.Drawing.Point(191, 152);
            this.btnExtrapFrm.Name = "btnExtrapFrm";
            this.btnExtrapFrm.Size = new System.Drawing.Size(122, 48);
            this.btnExtrapFrm.TabIndex = 1;
            this.btnExtrapFrm.Text = "Extrapolate";
            this.btnExtrapFrm.UseVisualStyleBackColor = true;
            this.btnExtrapFrm.Click += new System.EventHandler(this.BtnExtrapFrm_Click);
            // 
            // lblExtrapFrm
            // 
            this.lblExtrapFrm.AutoSize = true;
            this.lblExtrapFrm.Location = new System.Drawing.Point(166, 83);
            this.lblExtrapFrm.Name = "lblExtrapFrm";
            this.lblExtrapFrm.Size = new System.Drawing.Size(176, 20);
            this.lblExtrapFrm.TabIndex = 1;
            this.lblExtrapFrm.Text = "Enter Function Using \'x\'";
            // 
            // txtExtrapFrm
            // 
            this.txtExtrapFrm.Location = new System.Drawing.Point(73, 120);
            this.txtExtrapFrm.Name = "txtExtrapFrm";
            this.txtExtrapFrm.Size = new System.Drawing.Size(387, 26);
            this.txtExtrapFrm.TabIndex = 0;
            this.txtExtrapFrm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstExtrap
            // 
            this.lstExtrap.FormattingEnabled = true;
            this.lstExtrap.ItemHeight = 20;
            this.lstExtrap.Location = new System.Drawing.Point(12, 206);
            this.lstExtrap.Name = "lstExtrap";
            this.lstExtrap.Size = new System.Drawing.Size(501, 384);
            this.lstExtrap.TabIndex = 3;
            // 
            // btnDegRad
            // 
            this.btnDegRad.Location = new System.Drawing.Point(385, 152);
            this.btnDegRad.Name = "btnDegRad";
            this.btnDegRad.Size = new System.Drawing.Size(75, 37);
            this.btnDegRad.TabIndex = 2;
            this.btnDegRad.Text = "DEG";
            this.btnDegRad.UseVisualStyleBackColor = true;
            this.btnDegRad.Click += new System.EventHandler(this.BtnDegRad_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(525, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extrapolationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(525, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // extrapolationToolStripMenuItem
            // 
            this.extrapolationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.quadraticToolStripMenuItem,
            this.interpolationToolStripMenuItem});
            this.extrapolationToolStripMenuItem.Name = "extrapolationToolStripMenuItem";
            this.extrapolationToolStripMenuItem.Size = new System.Drawing.Size(128, 29);
            this.extrapolationToolStripMenuItem.Text = "Extrapolation";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(174, 30);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.CalculatorToolStripMenuItem_Click_1);
            // 
            // quadraticToolStripMenuItem
            // 
            this.quadraticToolStripMenuItem.Name = "quadraticToolStripMenuItem";
            this.quadraticToolStripMenuItem.Size = new System.Drawing.Size(174, 30);
            this.quadraticToolStripMenuItem.Text = "Quadratic";
            this.quadraticToolStripMenuItem.Click += new System.EventHandler(this.QuadraticToolStripMenuItem_Click_1);
            // 
            // interpolationToolStripMenuItem
            // 
            this.interpolationToolStripMenuItem.Name = "interpolationToolStripMenuItem";
            this.interpolationToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.interpolationToolStripMenuItem.Text = "Interpolation";
            this.interpolationToolStripMenuItem.Click += new System.EventHandler(this.InterpolationToolStripMenuItem_Click);
            // 
            // ExtrapolationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 606);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnDegRad);
            this.Controls.Add(this.lstExtrap);
            this.Controls.Add(this.txtExtrapFrm);
            this.Controls.Add(this.lblExtrapFrm);
            this.Controls.Add(this.btnExtrapFrm);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ExtrapolationFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extrapolation";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExtrapFrm;
        private System.Windows.Forms.Label lblExtrapFrm;
        private System.Windows.Forms.TextBox txtExtrapFrm;
        private System.Windows.Forms.ListBox lstExtrap;
        private System.Windows.Forms.Button btnDegRad;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem extrapolationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quadraticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interpolationToolStripMenuItem;
    }
}