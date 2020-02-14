namespace CalculatorGUI
{
    partial class frmExtrap
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
            this.btnExtrap = new System.Windows.Forms.Button();
            this.txtExtrap = new System.Windows.Forms.TextBox();
            this.lblExtrap = new System.Windows.Forms.Label();
            this.btnExtrapCancel = new System.Windows.Forms.Button();
            this.lblStepSize = new System.Windows.Forms.Label();
            this.txtStepSize = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExtrap
            // 
            this.btnExtrap.Location = new System.Drawing.Point(256, 198);
            this.btnExtrap.Name = "btnExtrap";
            this.btnExtrap.Size = new System.Drawing.Size(124, 29);
            this.btnExtrap.TabIndex = 2;
            this.btnExtrap.Text = "Extrapolate";
            this.btnExtrap.UseVisualStyleBackColor = true;
            this.btnExtrap.Click += new System.EventHandler(this.BtnExtrap_Click);
            // 
            // txtExtrap
            // 
            this.txtExtrap.Location = new System.Drawing.Point(82, 51);
            this.txtExtrap.Name = "txtExtrap";
            this.txtExtrap.Size = new System.Drawing.Size(298, 26);
            this.txtExtrap.TabIndex = 0;
            this.txtExtrap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblExtrap
            // 
            this.lblExtrap.AutoSize = true;
            this.lblExtrap.Location = new System.Drawing.Point(168, 28);
            this.lblExtrap.Name = "lblExtrap";
            this.lblExtrap.Size = new System.Drawing.Size(108, 20);
            this.lblExtrap.TabIndex = 2;
            this.lblExtrap.Text = "Enter X Value";
            // 
            // btnExtrapCancel
            // 
            this.btnExtrapCancel.Location = new System.Drawing.Point(82, 198);
            this.btnExtrapCancel.Name = "btnExtrapCancel";
            this.btnExtrapCancel.Size = new System.Drawing.Size(108, 29);
            this.btnExtrapCancel.TabIndex = 3;
            this.btnExtrapCancel.Text = "Cancel";
            this.btnExtrapCancel.UseVisualStyleBackColor = true;
            this.btnExtrapCancel.Click += new System.EventHandler(this.BtnExtrapCancel_Click);
            // 
            // lblStepSize
            // 
            this.lblStepSize.AutoSize = true;
            this.lblStepSize.Location = new System.Drawing.Point(168, 95);
            this.lblStepSize.Name = "lblStepSize";
            this.lblStepSize.Size = new System.Drawing.Size(121, 20);
            this.lblStepSize.TabIndex = 4;
            this.lblStepSize.Text = "Enter Step Size";
            // 
            // txtStepSize
            // 
            this.txtStepSize.Location = new System.Drawing.Point(82, 118);
            this.txtStepSize.Name = "txtStepSize";
            this.txtStepSize.Size = new System.Drawing.Size(298, 26);
            this.txtStepSize.TabIndex = 1;
            this.txtStepSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmExtrap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 255);
            this.Controls.Add(this.txtStepSize);
            this.Controls.Add(this.lblStepSize);
            this.Controls.Add(this.btnExtrapCancel);
            this.Controls.Add(this.lblExtrap);
            this.Controls.Add(this.txtExtrap);
            this.Controls.Add(this.btnExtrap);
            this.Name = "frmExtrap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extrapolation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExtrap;
        private System.Windows.Forms.TextBox txtExtrap;
        private System.Windows.Forms.Label lblExtrap;
        private System.Windows.Forms.Button btnExtrapCancel;
        private System.Windows.Forms.Label lblStepSize;
        private System.Windows.Forms.TextBox txtStepSize;
    }
}