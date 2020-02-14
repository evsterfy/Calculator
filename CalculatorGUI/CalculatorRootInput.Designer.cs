namespace CalculatorGUI
{
    partial class frmRoot
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
            this.lblRoot = new System.Windows.Forms.Label();
            this.txtRootInput = new System.Windows.Forms.TextBox();
            this.btnRootSubmit = new System.Windows.Forms.Button();
            this.btnRootCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRoot
            // 
            this.lblRoot.AutoSize = true;
            this.lblRoot.Location = new System.Drawing.Point(154, 80);
            this.lblRoot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoot.Name = "lblRoot";
            this.lblRoot.Size = new System.Drawing.Size(87, 20);
            this.lblRoot.TabIndex = 0;
            this.lblRoot.Text = "Enter Root";
            // 
            // txtRootInput
            // 
            this.txtRootInput.Location = new System.Drawing.Point(82, 123);
            this.txtRootInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRootInput.Name = "txtRootInput";
            this.txtRootInput.Size = new System.Drawing.Size(232, 26);
            this.txtRootInput.TabIndex = 1;
            this.txtRootInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRootSubmit
            // 
            this.btnRootSubmit.Location = new System.Drawing.Point(204, 183);
            this.btnRootSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRootSubmit.Name = "btnRootSubmit";
            this.btnRootSubmit.Size = new System.Drawing.Size(112, 35);
            this.btnRootSubmit.TabIndex = 2;
            this.btnRootSubmit.Text = "OK";
            this.btnRootSubmit.UseVisualStyleBackColor = true;
            this.btnRootSubmit.Click += new System.EventHandler(this.btnRootSubmit_Click);
            // 
            // btnRootCancel
            // 
            this.btnRootCancel.Location = new System.Drawing.Point(82, 183);
            this.btnRootCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRootCancel.Name = "btnRootCancel";
            this.btnRootCancel.Size = new System.Drawing.Size(112, 35);
            this.btnRootCancel.TabIndex = 3;
            this.btnRootCancel.Text = "Cancel";
            this.btnRootCancel.UseVisualStyleBackColor = true;
            this.btnRootCancel.Click += new System.EventHandler(this.btnRootCancel_Click);
            // 
            // frmRoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 269);
            this.Controls.Add(this.btnRootCancel);
            this.Controls.Add(this.btnRootSubmit);
            this.Controls.Add(this.txtRootInput);
            this.Controls.Add(this.lblRoot);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRoot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Root";
            this.Load += new System.EventHandler(this.frmRoot_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRoot_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRoot;
        private System.Windows.Forms.TextBox txtRootInput;
        private System.Windows.Forms.Button btnRootSubmit;
        private System.Windows.Forms.Button btnRootCancel;
    }
}