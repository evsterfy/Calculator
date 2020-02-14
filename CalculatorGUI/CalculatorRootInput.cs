using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorGUI
{
    public partial class frmRoot : Form
    {
        public frmRoot()
        {
            InitializeComponent();

            this.ControlBox = false;
        }

        private void btnRootSubmit_Click(object sender, EventArgs e)
        {
            if (txtRootInput.Text.Length > 0)
            {
                txtRootInput.Text = txtRootInput.Text.Insert(0, ">(");
                txtRootInput.Text += ")<(";
                Close();
            }
        }

        private void btnRootCancel_Click(object sender, EventArgs e)
        {
            txtRootInput.Text = "";
            Close();
        }

        public string GetRoot
        {
            get { return txtRootInput.Text; }
        }

        private void frmRoot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRootSubmit.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtRootInput.Text = "";
            }
        }

        private void frmRoot_Load(object sender, EventArgs e)
        {
            txtRootInput.Focus();
        }
    }
}
