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
    public partial class ExtrapolationFrm : Form
    {
        private Trigonometry trig = new Trigonometry();

        internal Trigonometry Trig { get => trig; set => trig = value; }

        public ExtrapolationFrm()
        {
            InitializeComponent();
        }

        private void BtnExtrapFrm_Click(object sender, EventArgs e)
        {
            lstExtrap.Items.Clear();

            frmExtrap frm = new frmExtrap();

            frmCalc calc = new frmCalc();

            Main main = new Main();

            string function = txtExtrapFrm.Text;

            frm.ShowDialog();

            string TempXValue = frm.getX();

            TempXValue = TempXValue.Replace("Pi", "(" + Math.PI.ToString() + ")");
            TempXValue = TempXValue.Replace("e", "(" + Math.E.ToString() + ")");
            TempXValue = TempXValue.Replace(" ", String.Empty);

            double XValue = Convert.ToDouble(main.Solve(TempXValue, calc, Trig));

            double h = frm.GetH();

            double tempH = h;

            function = function.ToLower();

            double[] OrderTwo = new double[4];
            double[] OrderFour = new double[3];
            double[] OrderSix = new double[2];
            double[] OrderEight = new double[1];

            lstExtrap.Items.Add("O(h^2)");

            for (int i = 0; i < OrderTwo.Length; i++)
            {
                string XPlusH = function.Replace("x", "(" + (XValue + h).ToString() + ")");
                string XMinusH = function.Replace("x", "(" + (XValue - h).ToString() + ")");
                XPlusH = main.Solve(XPlusH, calc, Trig).ToString();
                XMinusH = main.Solve(XMinusH, calc, Trig).ToString();
                OrderTwo[i] = (Convert.ToDouble(XPlusH) - Convert.ToDouble(XMinusH)) / ((double)2 * h);
                h /= 2;
                lstExtrap.Items.Add(OrderTwo[i]);
            }

            lstExtrap.Items.Add(String.Empty);

            double[][] Arrays = new double[3][];

            for (int i = 0; i < Arrays.Length; i++)
            {
                Arrays[i] = new double[Arrays.Length - i];
            }

            OrderHRecursive(Arrays, OrderTwo, Arrays[0], 0, 2);

            int n = 4;

            for (int i = 0; i < Arrays.Length; i++)
            {
                lstExtrap.Items.Add("O(h^" + n + ")");

                for (int j = 0; j < Arrays[i].Length; j++)
                {
                    lstExtrap.Items.Add(Arrays[i][j]);
                }

                lstExtrap.Items.Add(String.Empty);

                n += 2;
            }
        }

        private void OrderHRecursive(double[][] Arrays, double[] CurrentArray, double[] NextArray, int j, int n)
        {
            for (int i = 0; i < CurrentArray.Length - 1; i++)
            {
                NextArray[i] = (Math.Pow(2, n) * CurrentArray[i + 1] - CurrentArray[i]) / (Math.Pow(2, n) - 1);
            }

            if (j < Arrays.Length - 1)
            {
                OrderHRecursive(Arrays, Arrays[j], Arrays[++j], j, n + 2);
            }
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

        private void CalculatorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCalc frm = new frmCalc();
            Hide();
            frm.ShowDialog();
            Close();
        }

        private void QuadraticToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Quadratic frm = new Quadratic();
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
