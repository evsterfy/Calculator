namespace CalculatorGUI
{
    partial class frmCalc
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
            this.solve = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.butOpenP = new System.Windows.Forms.Button();
            this.butCloseP = new System.Windows.Forms.Button();
            this.butSub = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butDiv = new System.Windows.Forms.Button();
            this.butMult = new System.Windows.Forms.Button();
            this.butPow = new System.Windows.Forms.Button();
            this.butAns = new System.Windows.Forms.Button();
            this.butClear = new System.Windows.Forms.Button();
            this.butPi = new System.Windows.Forms.Button();
            this.butSq = new System.Windows.Forms.Button();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quadraticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warningLbl = new System.Windows.Forms.Label();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnLog10 = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculatorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quadraticToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.extrapolationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNRoot = new System.Windows.Forms.Button();
            this.btnDegRad = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnLogN = new System.Windows.Forms.Button();
            this.btnInverse = new System.Windows.Forms.Button();
            this.interpolationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // solve
            // 
            this.solve.Location = new System.Drawing.Point(381, 505);
            this.solve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(112, 35);
            this.solve.TabIndex = 0;
            this.solve.Text = "=";
            this.solve.UseVisualStyleBackColor = true;
            this.solve.Click += new System.EventHandler(this.solve_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(16, 91);
            this.inputBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(475, 26);
            this.inputBox.TabIndex = 1;
            this.inputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 460);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 460);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(260, 460);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 415);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 35);
            this.button4.TabIndex = 5;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(138, 415);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 35);
            this.button5.TabIndex = 6;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(260, 415);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 35);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(16, 371);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 35);
            this.button7.TabIndex = 8;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(138, 371);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(112, 35);
            this.button8.TabIndex = 9;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(260, 371);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(112, 35);
            this.button9.TabIndex = 10;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(138, 505);
            this.button0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(112, 35);
            this.button0.TabIndex = 11;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(138, 148);
            this.delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(112, 35);
            this.delete.TabIndex = 12;
            this.delete.Text = "<--";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // butOpenP
            // 
            this.butOpenP.Location = new System.Drawing.Point(16, 326);
            this.butOpenP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butOpenP.Name = "butOpenP";
            this.butOpenP.Size = new System.Drawing.Size(112, 35);
            this.butOpenP.TabIndex = 13;
            this.butOpenP.Text = "(";
            this.butOpenP.UseVisualStyleBackColor = true;
            this.butOpenP.Click += new System.EventHandler(this.butOpenP_Click);
            // 
            // butCloseP
            // 
            this.butCloseP.Location = new System.Drawing.Point(138, 326);
            this.butCloseP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butCloseP.Name = "butCloseP";
            this.butCloseP.Size = new System.Drawing.Size(112, 35);
            this.butCloseP.TabIndex = 14;
            this.butCloseP.Text = ")";
            this.butCloseP.UseVisualStyleBackColor = true;
            this.butCloseP.Click += new System.EventHandler(this.butCloseP_Click);
            // 
            // butSub
            // 
            this.butSub.Location = new System.Drawing.Point(381, 460);
            this.butSub.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butSub.Name = "butSub";
            this.butSub.Size = new System.Drawing.Size(112, 35);
            this.butSub.TabIndex = 15;
            this.butSub.Text = "- \\ neg";
            this.butSub.UseVisualStyleBackColor = true;
            this.butSub.Click += new System.EventHandler(this.butSub_Click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(381, 415);
            this.butAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(112, 35);
            this.butAdd.TabIndex = 16;
            this.butAdd.Text = "+";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butDiv
            // 
            this.butDiv.Location = new System.Drawing.Point(381, 371);
            this.butDiv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butDiv.Name = "butDiv";
            this.butDiv.Size = new System.Drawing.Size(112, 35);
            this.butDiv.TabIndex = 17;
            this.butDiv.Text = "/";
            this.butDiv.UseVisualStyleBackColor = true;
            this.butDiv.Click += new System.EventHandler(this.butDiv_Click);
            // 
            // butMult
            // 
            this.butMult.Location = new System.Drawing.Point(381, 326);
            this.butMult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butMult.Name = "butMult";
            this.butMult.Size = new System.Drawing.Size(112, 35);
            this.butMult.TabIndex = 18;
            this.butMult.Text = "*";
            this.butMult.UseVisualStyleBackColor = true;
            this.butMult.Click += new System.EventHandler(this.butMult_Click);
            // 
            // butPow
            // 
            this.butPow.Location = new System.Drawing.Point(380, 192);
            this.butPow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butPow.Name = "butPow";
            this.butPow.Size = new System.Drawing.Size(112, 35);
            this.butPow.TabIndex = 19;
            this.butPow.Text = "x^y";
            this.butPow.UseVisualStyleBackColor = true;
            this.butPow.Click += new System.EventHandler(this.butPow_Click);
            // 
            // butAns
            // 
            this.butAns.Location = new System.Drawing.Point(260, 505);
            this.butAns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butAns.Name = "butAns";
            this.butAns.Size = new System.Drawing.Size(112, 35);
            this.butAns.TabIndex = 20;
            this.butAns.Text = "Ans";
            this.butAns.UseVisualStyleBackColor = true;
            this.butAns.Click += new System.EventHandler(this.butAns_Click);
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(16, 148);
            this.butClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(112, 35);
            this.butClear.TabIndex = 21;
            this.butClear.Text = "Clear";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // butPi
            // 
            this.butPi.Location = new System.Drawing.Point(260, 326);
            this.butPi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butPi.Name = "butPi";
            this.butPi.Size = new System.Drawing.Size(112, 35);
            this.butPi.TabIndex = 22;
            this.butPi.Text = "Pi";
            this.butPi.UseVisualStyleBackColor = true;
            this.butPi.Click += new System.EventHandler(this.butPi_Click);
            // 
            // butSq
            // 
            this.butSq.Location = new System.Drawing.Point(381, 237);
            this.butSq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butSq.Name = "butSq";
            this.butSq.Size = new System.Drawing.Size(112, 35);
            this.butSq.TabIndex = 23;
            this.butSq.Text = "x^2";
            this.butSq.UseVisualStyleBackColor = true;
            this.butSq.Click += new System.EventHandler(this.butSq_Click);
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quadraticToolStripMenuItem});
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            // 
            // quadraticToolStripMenuItem
            // 
            this.quadraticToolStripMenuItem.Name = "quadraticToolStripMenuItem";
            this.quadraticToolStripMenuItem.Size = new System.Drawing.Size(173, 30);
            this.quadraticToolStripMenuItem.Text = "Quadratic";
            this.quadraticToolStripMenuItem.Click += new System.EventHandler(this.quadraticToolStripMenuItem_Click);
            // 
            // warningLbl
            // 
            this.warningLbl.BackColor = System.Drawing.SystemColors.GrayText;
            this.warningLbl.ForeColor = System.Drawing.Color.Red;
            this.warningLbl.Location = new System.Drawing.Point(16, 55);
            this.warningLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warningLbl.Name = "warningLbl";
            this.warningLbl.Size = new System.Drawing.Size(477, 31);
            this.warningLbl.TabIndex = 25;
            this.warningLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSqrt
            // 
            this.btnSqrt.Location = new System.Drawing.Point(138, 282);
            this.btnSqrt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(112, 35);
            this.btnSqrt.TabIndex = 26;
            this.btnSqrt.Text = "sqrt";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnSin
            // 
            this.btnSin.Location = new System.Drawing.Point(16, 192);
            this.btnSin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(112, 35);
            this.btnSin.TabIndex = 27;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(138, 192);
            this.btnCos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(112, 35);
            this.btnCos.TabIndex = 28;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnTan
            // 
            this.btnTan.Location = new System.Drawing.Point(260, 192);
            this.btnTan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(112, 35);
            this.btnTan.TabIndex = 29;
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnLog10
            // 
            this.btnLog10.Location = new System.Drawing.Point(138, 237);
            this.btnLog10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLog10.Name = "btnLog10";
            this.btnLog10.Size = new System.Drawing.Size(112, 35);
            this.btnLog10.TabIndex = 30;
            this.btnLog10.Text = "log10";
            this.btnLog10.UseVisualStyleBackColor = true;
            this.btnLog10.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Location = new System.Drawing.Point(16, 505);
            this.btnDecimal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(112, 35);
            this.btnDecimal.TabIndex = 31;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnLn
            // 
            this.btnLn.Location = new System.Drawing.Point(260, 237);
            this.btnLn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(112, 35);
            this.btnLn.TabIndex = 32;
            this.btnLn.Text = "ln";
            this.btnLn.UseVisualStyleBackColor = true;
            this.btnLn.Click += new System.EventHandler(this.btnLn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(510, 35);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculatorToolStripMenuItem1
            // 
            this.calculatorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quadraticToolStripMenuItem1,
            this.extrapolationToolStripMenuItem,
            this.interpolationToolStripMenuItem});
            this.calculatorToolStripMenuItem1.Name = "calculatorToolStripMenuItem1";
            this.calculatorToolStripMenuItem1.Size = new System.Drawing.Size(102, 29);
            this.calculatorToolStripMenuItem1.Text = "Calculator";
            // 
            // quadraticToolStripMenuItem1
            // 
            this.quadraticToolStripMenuItem1.Name = "quadraticToolStripMenuItem1";
            this.quadraticToolStripMenuItem1.Size = new System.Drawing.Size(252, 30);
            this.quadraticToolStripMenuItem1.Text = "Quadratic";
            this.quadraticToolStripMenuItem1.Click += new System.EventHandler(this.quadraticToolStripMenuItem1_Click);
            // 
            // extrapolationToolStripMenuItem
            // 
            this.extrapolationToolStripMenuItem.Name = "extrapolationToolStripMenuItem";
            this.extrapolationToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.extrapolationToolStripMenuItem.Text = "Extrapolation";
            this.extrapolationToolStripMenuItem.Click += new System.EventHandler(this.ExtrapolationToolStripMenuItem_Click);
            // 
            // btnNRoot
            // 
            this.btnNRoot.Location = new System.Drawing.Point(16, 282);
            this.btnNRoot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNRoot.Name = "btnNRoot";
            this.btnNRoot.Size = new System.Drawing.Size(112, 35);
            this.btnNRoot.TabIndex = 34;
            this.btnNRoot.Text = "nRoot";
            this.btnNRoot.UseVisualStyleBackColor = true;
            this.btnNRoot.Click += new System.EventHandler(this.btnNRoot_Click);
            // 
            // btnDegRad
            // 
            this.btnDegRad.Location = new System.Drawing.Point(381, 148);
            this.btnDegRad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDegRad.Name = "btnDegRad";
            this.btnDegRad.Size = new System.Drawing.Size(112, 35);
            this.btnDegRad.TabIndex = 35;
            this.btnDegRad.Text = "DEG";
            this.btnDegRad.UseVisualStyleBackColor = true;
            this.btnDegRad.Click += new System.EventHandler(this.btnDegRad_Click);
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(260, 282);
            this.btnE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(112, 35);
            this.btnE.TabIndex = 36;
            this.btnE.Text = "e";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(381, 282);
            this.btnMod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(112, 35);
            this.btnMod.TabIndex = 37;
            this.btnMod.Text = "% \\ Mod";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnLogN
            // 
            this.btnLogN.Location = new System.Drawing.Point(16, 237);
            this.btnLogN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogN.Name = "btnLogN";
            this.btnLogN.Size = new System.Drawing.Size(112, 35);
            this.btnLogN.TabIndex = 38;
            this.btnLogN.Text = "logn";
            this.btnLogN.UseVisualStyleBackColor = true;
            this.btnLogN.Click += new System.EventHandler(this.btnLogN_Click);
            // 
            // btnInverse
            // 
            this.btnInverse.Location = new System.Drawing.Point(260, 148);
            this.btnInverse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(112, 35);
            this.btnInverse.TabIndex = 39;
            this.btnInverse.Text = "Inverse";
            this.btnInverse.UseVisualStyleBackColor = true;
            this.btnInverse.Click += new System.EventHandler(this.btnInverse_Click);
            // 
            // interpolationToolStripMenuItem
            // 
            this.interpolationToolStripMenuItem.Name = "interpolationToolStripMenuItem";
            this.interpolationToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.interpolationToolStripMenuItem.Text = "Interpolation";
            this.interpolationToolStripMenuItem.Click += new System.EventHandler(this.InterpolationToolStripMenuItem_Click);
            // 
            // frmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 558);
            this.Controls.Add(this.btnInverse);
            this.Controls.Add(this.btnLogN);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnDegRad);
            this.Controls.Add(this.btnNRoot);
            this.Controls.Add(this.btnLn);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnLog10);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.warningLbl);
            this.Controls.Add(this.butSq);
            this.Controls.Add(this.butPi);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.butAns);
            this.Controls.Add(this.butPow);
            this.Controls.Add(this.butMult);
            this.Controls.Add(this.butDiv);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.butSub);
            this.Controls.Add(this.butCloseP);
            this.Controls.Add(this.butOpenP);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.solve);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.frmCalc_Load);
            this.Shown += new System.EventHandler(this.frmCalc_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCalc_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button solve;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button butOpenP;
        private System.Windows.Forms.Button butCloseP;
        private System.Windows.Forms.Button butSub;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butDiv;
        private System.Windows.Forms.Button butMult;
        private System.Windows.Forms.Button butPow;
        private System.Windows.Forms.Button butAns;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button butPi;
        private System.Windows.Forms.Button butSq;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quadraticToolStripMenuItem;
        private System.Windows.Forms.Label warningLbl;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnLog10;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quadraticToolStripMenuItem1;
        private System.Windows.Forms.Button btnNRoot;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnLogN;
        private System.Windows.Forms.Button btnInverse;
        private System.Windows.Forms.ToolStripMenuItem extrapolationToolStripMenuItem;
        public System.Windows.Forms.Button btnDegRad;
        private System.Windows.Forms.ToolStripMenuItem interpolationToolStripMenuItem;
    }
}

