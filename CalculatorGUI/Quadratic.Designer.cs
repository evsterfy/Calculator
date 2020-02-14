namespace CalculatorGUI
{
    partial class Quadratic
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblX1 = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quadraticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extrapolationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblQuadWarn = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.interpolationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(189, 85);
            this.txtA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(148, 26);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(189, 125);
            this.txtB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(148, 26);
            this.txtB.TabIndex = 1;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(189, 165);
            this.txtC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(148, 26);
            this.txtC.TabIndex = 2;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(150, 89);
            this.lblA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(28, 20);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "A :";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(150, 129);
            this.lblB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(28, 20);
            this.lblB.TabIndex = 4;
            this.lblB.Text = "B :";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(150, 169);
            this.lblC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(28, 20);
            this.lblC.TabIndex = 5;
            this.lblC.Text = "C :";
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Location = new System.Drawing.Point(18, 274);
            this.lblX1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(28, 20);
            this.lblX1.TabIndex = 6;
            this.lblX1.Text = "X :";
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(18, 314);
            this.lblX2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(28, 20);
            this.lblX2.TabIndex = 7;
            this.lblX2.Text = "X :";
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(57, 269);
            this.txtX1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(433, 26);
            this.txtX1.TabIndex = 8;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(57, 309);
            this.txtX2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(433, 26);
            this.txtX2.TabIndex = 9;
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(380, 397);
            this.btnSolve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(112, 35);
            this.btnSolve.TabIndex = 10;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quadraticToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(510, 35);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quadraticToolStripMenuItem
            // 
            this.quadraticToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.extrapolationToolStripMenuItem,
            this.interpolationToolStripMenuItem});
            this.quadraticToolStripMenuItem.Name = "quadraticToolStripMenuItem";
            this.quadraticToolStripMenuItem.Size = new System.Drawing.Size(101, 29);
            this.quadraticToolStripMenuItem.Text = "Quadratic";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // extrapolationToolStripMenuItem
            // 
            this.extrapolationToolStripMenuItem.Name = "extrapolationToolStripMenuItem";
            this.extrapolationToolStripMenuItem.Size = new System.Drawing.Size(200, 30);
            this.extrapolationToolStripMenuItem.Text = "Extrapolation";
            this.extrapolationToolStripMenuItem.Click += new System.EventHandler(this.ExtrapolationToolStripMenuItem_Click);
            // 
            // lblQuadWarn
            // 
            this.lblQuadWarn.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblQuadWarn.ForeColor = System.Drawing.Color.Red;
            this.lblQuadWarn.Location = new System.Drawing.Point(15, 218);
            this.lblQuadWarn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuadWarn.Name = "lblQuadWarn";
            this.lblQuadWarn.Size = new System.Drawing.Size(477, 31);
            this.lblQuadWarn.TabIndex = 26;
            this.lblQuadWarn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(57, 397);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 35);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // interpolationToolStripMenuItem
            // 
            this.interpolationToolStripMenuItem.Name = "interpolationToolStripMenuItem";
            this.interpolationToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.interpolationToolStripMenuItem.Text = "Interpolation";
            this.interpolationToolStripMenuItem.Click += new System.EventHandler(this.InterpolationToolStripMenuItem_Click);
            // 
            // Quadratic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 451);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblQuadWarn);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.lblX2);
            this.Controls.Add(this.lblX1);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Quadratic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quadratic";
            this.Load += new System.EventHandler(this.Quadratic_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quadraticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.Label lblQuadWarn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripMenuItem extrapolationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interpolationToolStripMenuItem;
    }
}