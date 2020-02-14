using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/* 3/28/18 - PEMDAS precedence support fully implemented along with negative number support.
 * 3/30/18 - Cleaned up program, removed unnecessary statements, functions, variables, and loops.
 * 4/1/18  - Root, Trig, Log, implicit multiplication, and other support added.
 * 4/1/18  - Mod support added.
 * 4/10/18 - Pretty much full support for a lot of expressions. Works great as far as I can tell.
 *           Also added decent comments.
 * */


namespace CalculatorGUI
{
    public partial class frmCalc : Form
    {
        private Trigonometry trig = new Trigonometry();

        internal Trigonometry Trig { get => trig; set => trig = value; }

        public frmCalc()
        {
            InitializeComponent();
        }

        public void solve_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Solve(String.Empty, this, Trig);
        }

        public string GetInputBox()
        {
            return Application.OpenForms["frmCalc"].Controls["inputBox"].Text;
        }

        public void SetInputBox(string input)
        {
            Application.OpenForms["frmCalc"].Controls["inputBox"].Text = input;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            inputBox.Text += '0';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputBox.Text += '1';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inputBox.Text += '2';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inputBox.Text += '3';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inputBox.Text += '4';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inputBox.Text += '5';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            inputBox.Text += '6';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            inputBox.Text += '7';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inputBox.Text += '8';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            inputBox.Text += '9';
        }

        private void butOpenP_Click(object sender, EventArgs e)
        {
            inputBox.Text += '(';
        }

        private void butCloseP_Click(object sender, EventArgs e)
        {
            if (inputBox.Text.Length > 0)
            {
                inputBox.Text += ')';
            }
        }

        private void butPow_Click(object sender, EventArgs e)
        {
            if (inputBox.Text.Length > 0)
            {
                inputBox.Text += '^';
            }
        }

        private void butMult_Click(object sender, EventArgs e)
        {
            if (inputBox.Text.Length > 0)
            {
                inputBox.Text += '*';
            }
        }

        private void butDiv_Click(object sender, EventArgs e)
        {
            if (inputBox.Text.Length > 0)
            {
                inputBox.Text += '/';
            }
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            if (inputBox.Text.Length > 0)
            {
                inputBox.Text += '+';
            }
        }

        private void butSub_Click(object sender, EventArgs e)
        {
            inputBox.Text += '-';
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (inputBox.Text.Length > 0)
            {
                inputBox.Text = inputBox.Text.Remove(inputBox.Text.Length - 1);
            }
            if (inputBox.Text.Length == 0)
            {
                warningLbl.Text = "";
            }
        }

        private void butAns_Click(object sender, EventArgs e)
        {
            Main main = new Main();

            inputBox.Text += main.PrevAns;
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            inputBox.Text = "";
            warningLbl.Text = "";
        }

        private void butPi_Click(object sender, EventArgs e)
        {
            inputBox.Text += "Pi";
        }

        private void butSq_Click(object sender, EventArgs e)
        {
            if (inputBox.Text.Length > 0)
            {
                inputBox.Text += "^2";
            }
        }

        private void frmCalc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                inputBox.Text = "";
            }
            else if (e.KeyCode == Keys.Enter)
            {
                solve.PerformClick();
            }
        }

        private void quadraticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quadratic quad = new Quadratic();

            Hide();
            quad.ShowDialog();
            Close();

        }

        private void frmCalc_Load(object sender, EventArgs e)
        {
            warningLbl.BackColor = Color.Transparent;
        }

        private void frmCalc_FormClosed(object sender, EventArgs e)
        {
            Close();
        }

        private void Quadratic_FormClosed(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPowX_Click(object sender, EventArgs e)
        {
            if (inputBox.Text.Length > 0)
            {
                inputBox.Text += "^";
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            inputBox.Text += "<>(";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            inputBox.Text += '.';
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            if (btnSin.Text == "sin")
            {
                inputBox.Text += "sin(";
            }
            else
            {
                inputBox.Text += "asin(";
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            if (btnCos.Text == "cos")
            {
                inputBox.Text += "cos(";
            }
            else
            {
                inputBox.Text += "acos(";
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            if (btnTan.Text == "tan")
            {
                inputBox.Text += "tan(";
            }
            else
            {
                inputBox.Text += "atan(";
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            inputBox.Text += "log(";
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            inputBox.Text += "ln(";
        }

        private void quadraticToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Quadratic quad = new Quadratic();

            Hide();
            quad.ShowDialog();
            Close();
        }

        private void frmCalc_Shown(object sender, EventArgs e)
        {
            inputBox.Focus();
        }

        private void btnNRoot_Click(object sender, EventArgs e)
        {
            frmRoot root = new frmRoot();
            root.ShowDialog();

            inputBox.Text += root.GetRoot;
        }

        public void btnDegRad_Click(object sender, EventArgs e)
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

        private void button10_Click(object sender, EventArgs e)
        {
            inputBox.Text += "e";
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            inputBox.Text += "%";
        }

        private void btnLogN_Click(object sender, EventArgs e)
        {
            frmLog log = new frmLog();
            log.ShowDialog();

            inputBox.Text += log.GetLog;
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            if (btnSin.Text == "sin")
            {
                btnSin.Text = "asin";
            }
            else
            {
                btnSin.Text = "sin";
            }

            if (btnCos.Text == "cos")
            {
                btnCos.Text = "acos";
            }
            else
            {
                btnCos.Text = "cos";
            }

            if (btnTan.Text == "tan")
            {
                btnTan.Text = "atan";
            }
            else
            {
                btnTan.Text = "tan";
            }
        }

        public void SetWarningLbl(string label)
        {
            Application.OpenForms["frmCalc"].Controls["warningLbl"].Text = label;
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