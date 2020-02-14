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
    public partial class Quadratic : Form
    {
        public Quadratic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                double A = Convert.ToDouble(txtA.Text);
                double B = Convert.ToDouble(txtB.Text);
                double C = Convert.ToDouble(txtC.Text);

                double x1 = 0;
                double x2 = 0;

                x1 = ((B / -1) + Math.Sqrt((B * B) - (4 * A * C))) / (2 * A);
                x2 = ((B / -1) - Math.Sqrt((B * B) - (4 * A * C))) / (2 * A);

                txtX1.Text = Convert.ToString(x1);
                txtX2.Text = Convert.ToString(x2);
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quadratic quad = new Quadratic();
            frmCalc frm = new frmCalc();
            
            Hide();
            frm.ShowDialog();
            Close();
        }

        private void frmCalc_FormClosed(object sender, EventArgs e)
        {
            Close();
        }

        private void Quadratic_FormClosed(object sender, EventArgs e)
        {
            Close();
        }

        private void Quadratic_Load(object sender, EventArgs e)
        {
            lblQuadWarn.BackColor = Color.Transparent;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtX1.Text = "";
            txtX2.Text = "";
        }

        private void ExtrapolationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExtrapolationFrm frm = new ExtrapolationFrm();
            Hide();
            frm.ShowDialog();
            Close();
        }

        private void InterpolationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interpolation frm = new Interpolation();

            Hide();
            frm.ShowDialog();
            Close();
        }
    }
}
