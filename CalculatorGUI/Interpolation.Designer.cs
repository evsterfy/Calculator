namespace CalculatorGUI
{
    partial class Interpolation
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
            this.lblFunc = new System.Windows.Forms.Label();
            this.txtFunc = new System.Windows.Forms.TextBox();
            this.txtSec = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblRangeA = new System.Windows.Forms.Label();
            this.lblRangeB = new System.Windows.Forms.Label();
            this.txtRangeA = new System.Windows.Forms.TextBox();
            this.txtRangeB = new System.Windows.Forms.TextBox();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.lblAns = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.interpolationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extrapolationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quadraticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDegRad = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFunc
            // 
            this.lblFunc.AutoSize = true;
            this.lblFunc.Location = new System.Drawing.Point(179, 86);
            this.lblFunc.Name = "lblFunc";
            this.lblFunc.Size = new System.Drawing.Size(168, 20);
            this.lblFunc.TabIndex = 0;
            this.lblFunc.Text = "Enter function using \'x\'";
            // 
            // txtFunc
            // 
            this.txtFunc.Location = new System.Drawing.Point(123, 109);
            this.txtFunc.Name = "txtFunc";
            this.txtFunc.Size = new System.Drawing.Size(280, 26);
            this.txtFunc.TabIndex = 1;
            this.txtFunc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSec
            // 
            this.txtSec.Location = new System.Drawing.Point(123, 173);
            this.txtSec.Name = "txtSec";
            this.txtSec.Size = new System.Drawing.Size(280, 26);
            this.txtSec.TabIndex = 2;
            this.txtSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(159, 150);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(210, 20);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "Enter number of sections (n)";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(208, 275);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(101, 40);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // lblRangeA
            // 
            this.lblRangeA.AutoSize = true;
            this.lblRangeA.Location = new System.Drawing.Point(137, 211);
            this.lblRangeA.Name = "lblRangeA";
            this.lblRangeA.Size = new System.Drawing.Size(67, 20);
            this.lblRangeA.TabIndex = 8;
            this.lblRangeA.Text = "Enter \'a\'";
            // 
            // lblRangeB
            // 
            this.lblRangeB.AutoSize = true;
            this.lblRangeB.Location = new System.Drawing.Point(321, 211);
            this.lblRangeB.Name = "lblRangeB";
            this.lblRangeB.Size = new System.Drawing.Size(67, 20);
            this.lblRangeB.TabIndex = 9;
            this.lblRangeB.Text = "Enter \'b\'";
            // 
            // txtRangeA
            // 
            this.txtRangeA.Location = new System.Drawing.Point(123, 234);
            this.txtRangeA.Name = "txtRangeA";
            this.txtRangeA.Size = new System.Drawing.Size(100, 26);
            this.txtRangeA.TabIndex = 3;
            this.txtRangeA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRangeB
            // 
            this.txtRangeB.Location = new System.Drawing.Point(303, 234);
            this.txtRangeB.Name = "txtRangeB";
            this.txtRangeB.Size = new System.Drawing.Size(100, 26);
            this.txtRangeB.TabIndex = 4;
            this.txtRangeB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAns
            // 
            this.txtAns.Location = new System.Drawing.Point(123, 373);
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(280, 26);
            this.txtAns.TabIndex = 7;
            this.txtAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Location = new System.Drawing.Point(231, 350);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(62, 20);
            this.lblAns.TabIndex = 13;
            this.lblAns.Text = "Answer";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interpolationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(536, 33);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // interpolationToolStripMenuItem
            // 
            this.interpolationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem,
            this.extrapolationToolStripMenuItem,
            this.quadraticToolStripMenuItem});
            this.interpolationToolStripMenuItem.Name = "interpolationToolStripMenuItem";
            this.interpolationToolStripMenuItem.Size = new System.Drawing.Size(126, 29);
            this.interpolationToolStripMenuItem.Text = "Interpolation";
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.CalculatorToolStripMenuItem_Click);
            // 
            // extrapolationToolStripMenuItem
            // 
            this.extrapolationToolStripMenuItem.Name = "extrapolationToolStripMenuItem";
            this.extrapolationToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.extrapolationToolStripMenuItem.Text = "Extrapolation";
            this.extrapolationToolStripMenuItem.Click += new System.EventHandler(this.ExtrapolationToolStripMenuItem_Click);
            // 
            // quadraticToolStripMenuItem
            // 
            this.quadraticToolStripMenuItem.Name = "quadraticToolStripMenuItem";
            this.quadraticToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.quadraticToolStripMenuItem.Text = "Quadratic";
            this.quadraticToolStripMenuItem.Click += new System.EventHandler(this.QuadraticToolStripMenuItem_Click);
            // 
            // btnDegRad
            // 
            this.btnDegRad.Location = new System.Drawing.Point(342, 275);
            this.btnDegRad.Name = "btnDegRad";
            this.btnDegRad.Size = new System.Drawing.Size(61, 40);
            this.btnDegRad.TabIndex = 5;
            this.btnDegRad.Text = "DEG";
            this.btnDegRad.UseVisualStyleBackColor = true;
            this.btnDegRad.Click += new System.EventHandler(this.BtnDegRad_Click);
            // 
            // Interpolation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 440);
            this.Controls.Add(this.btnDegRad);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.txtRangeB);
            this.Controls.Add(this.txtRangeA);
            this.Controls.Add(this.lblRangeB);
            this.Controls.Add(this.lblRangeA);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.txtSec);
            this.Controls.Add(this.txtFunc);
            this.Controls.Add(this.lblFunc);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Interpolation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interpolation";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFunc;
        private System.Windows.Forms.TextBox txtFunc;
        private System.Windows.Forms.TextBox txtSec;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblRangeA;
        private System.Windows.Forms.Label lblRangeB;
        private System.Windows.Forms.TextBox txtRangeA;
        private System.Windows.Forms.TextBox txtRangeB;
        private System.Windows.Forms.TextBox txtAns;
        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem interpolationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extrapolationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quadraticToolStripMenuItem;
        private System.Windows.Forms.Button btnDegRad;
    }
}