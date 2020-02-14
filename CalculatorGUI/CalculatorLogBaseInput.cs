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
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();

            this.ControlBox = false;
        }

        private void btnLogSubmit_Click(object sender, EventArgs e)
        {
            if (txtLogBase.Text.Length > 0)
            {
                txtLogBase.Text = txtLogBase.Text.Insert(0, "logb(");
                txtLogBase.Text += ")(";
                Close();
            }
        }

        private void btnLogCancel_Click(object sender, EventArgs e)
        {
            txtLogBase.Text = "";
            Close();
        }

        private void txtLogBase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogSubmit.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtLogBase.Text = "";
            }
        }

        public string GetLog
        {
            get { return txtLogBase.Text; }
        }

        private void frmLog_Load(object sender, EventArgs e)
        {
            txtLogBase.Focus();
        }
    }
}
