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
    public partial class frmExtrap : Form
    {
        public frmExtrap()
        {
            InitializeComponent();

            this.ControlBox = false;
        }

        private void BtnExtrap_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string getX()
        {
            return txtExtrap.Text;
        }

        public double GetH()
        {
            return Convert.ToDouble(txtStepSize.Text);
        }

        private void BtnExtrapCancel_Click(object sender, EventArgs e)
        {
            txtExtrap.Text = "";
            Close();
        }
    }
}
