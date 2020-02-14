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
    public partial class Interpolation : Form
    {
        private Trigonometry trig = new Trigonometry();
        internal Trigonometry Trig { get => trig; set => trig = value; }

        public Interpolation()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            txtAns.Text = String.Empty;

            Main main = new Main();

            frmCalc calc = new frmCalc();

            string function = txtFunc.Text;
            function = function.ToLower();

            double sections = Convert.ToDouble(txtSec.Text);

            string rangeA = txtRangeA.Text;

            string rangeB = txtRangeB.Text;

            rangeA = rangeA.Replace("Pi", "(" + Math.PI.ToString() + ")");
            rangeA = rangeA.Replace("e", "(" + Math.E.ToString() + ")");
            rangeA = rangeA.Replace(" ", String.Empty);

            rangeB = rangeB.Replace("Pi", "(" + Math.PI.ToString() + ")");
            rangeB = rangeB.Replace("e", "(" + Math.E.ToString() + ")");
            rangeB = rangeB.Replace(" ", String.Empty);

            rangeA = main.Solve(rangeA, calc, Trig).ToString();
            rangeB = main.Solve(rangeB, calc, Trig).ToString();

            string tempFunc = String.Empty;

            double h = (Convert.ToDouble(rangeB) - Convert.ToDouble(rangeA)) / sections;

            if (sections == 2)
            {
                double answer = (Convert.ToDouble(rangeB) - Convert.ToDouble(rangeA)) / sections / 3;

                double temp = main.Solve(function.Replace("x", "(" + (Convert.ToDouble(rangeA)) + ")"), calc, Trig);

                temp += 4 * main.Solve(function.Replace("x", "(" + (Convert.ToDouble(rangeA) + Convert.ToDouble(rangeB)) / 2 + ")"), calc, Trig);

                temp += main.Solve(function.Replace("x", "(" + Convert.ToDouble(rangeB) + ")"), calc, Trig);

                answer *= temp;

                txtAns.Text = answer.ToString();
            }
            else if (sections > 2)
            {
                double answer = 0;
                double temp = 0;

                answer = (Convert.ToDouble(rangeB) - Convert.ToDouble(rangeA)) / sections / 3;

                for (int i = 1; i <= sections / 2; i++)
                {
                    tempFunc = function.Replace("x", "(" + (Convert.ToDouble(rangeA) + (2 * i - 2) * h).ToString() + ")");

                    temp += main.Solve(tempFunc, calc, Trig);

                    tempFunc = function.Replace("x", "(" + (Convert.ToDouble(rangeA) + (2 * i - 1) * h).ToString() + ")");

                    temp += 4 * main.Solve(tempFunc, calc, Trig);

                    tempFunc = function.Replace("x", "(" + (Convert.ToDouble(rangeA) + (2 * i) * h).ToString() + ")");

                    temp += main.Solve(tempFunc, calc, Trig);
                }

                answer *= temp;

                txtAns.Text = answer.ToString();
            }
        }

        private void CalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalc frm = new frmCalc();

            Hide();
            frm.ShowDialog();
            Close();
        }

        private void ExtrapolationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExtrapolationFrm frm = new ExtrapolationFrm();

            Hide();
            frm.ShowDialog();
            Close();
        }

        private void QuadraticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quadratic frm = new Quadratic();

            Hide();
            frm.ShowDialog();
            Close();
        }

        private void BtnDegRad_Click(object sender, EventArgs e)
        {
            if (btnDegRad.Text == "DEG")
            {
                btnDegRad.Text = "RAD";
                Trig.Deg = false;
            }
            else
            {
                btnDegRad.Text = "DEG";
                Trig.Deg = true;
            }
        }
    }
}
