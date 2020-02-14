namespace CalculatorGUI
{
    partial class frmLog
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
            this.btnLogSubmit = new System.Windows.Forms.Button();
            this.btnLogCancel = new System.Windows.Forms.Button();
            this.lblLogBase = new System.Windows.Forms.Label();
            this.txtLogBase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLogSubmit
            // 
            this.btnLogSubmit.Location = new System.Drawing.Point(207, 215);
            this.btnLogSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogSubmit.Name = "btnLogSubmit";
            this.btnLogSubmit.Size = new System.Drawing.Size(112, 35);
            this.btnLogSubmit.TabIndex = 0;
            this.btnLogSubmit.Text = "OK";
            this.btnLogSubmit.UseVisualStyleBackColor = true;
            this.btnLogSubmit.Click += new System.EventHandler(this.btnLogSubmit_Click);
            // 
            // btnLogCancel
            // 
            this.btnLogCancel.Location = new System.Drawing.Point(86, 215);
            this.btnLogCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogCancel.Name = "btnLogCancel";
            this.btnLogCancel.Size = new System.Drawing.Size(112, 35);
            this.btnLogCancel.TabIndex = 1;
            this.btnLogCancel.Text = "Cancel";
            this.btnLogCancel.UseVisualStyleBackColor = true;
            this.btnLogCancel.Click += new System.EventHandler(this.btnLogCancel_Click);
            // 
            // lblLogBase
            // 
            this.lblLogBase.AutoSize = true;
            this.lblLogBase.Location = new System.Drawing.Point(140, 95);
            this.lblLogBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogBase.Name = "lblLogBase";
            this.lblLogBase.Size = new System.Drawing.Size(120, 20);
            this.lblLogBase.TabIndex = 2;
            this.lblLogBase.Text = "Enter Log Base";
            // 
            // txtLogBase
            // 
            this.txtLogBase.Location = new System.Drawing.Point(86, 151);
            this.txtLogBase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLogBase.Name = "txtLogBase";
            this.txtLogBase.Size = new System.Drawing.Size(232, 26);
            this.txtLogBase.TabIndex = 3;
            this.txtLogBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLogBase.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLogBase_KeyDown);
            // 
            // frmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 269);
            this.Controls.Add(this.txtLogBase);
            this.Controls.Add(this.lblLogBase);
            this.Controls.Add(this.btnLogCancel);
            this.Controls.Add(this.btnLogSubmit);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Log Base";
            this.Load += new System.EventHandler(this.frmLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogSubmit;
        private System.Windows.Forms.Button btnLogCancel;
        private System.Windows.Forms.Label lblLogBase;
        private System.Windows.Forms.TextBox txtLogBase;
    }
}