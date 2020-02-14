using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGUI
{
    class Trigonometry
    {
        private bool deg = true;

        public bool Deg { get => deg; set => deg = value; }

        public bool SolveSin(Main main, frmCalc calc)
        {
            if (Deg)
            {
                if (main.ParOpen > 3 && main.Input[main.ParOpen - 4] == 'a')
                {
                    if (main.OperandTwo >= -1 && main.OperandTwo <= 1)
                    {
                        main.Operand = Convert.ToString(Math.Round(Math.Asin(main.OperandTwo) * 180 / Math.PI, 10));
                    }
                    else
                    {
                        calc.SetWarningLbl("Can't take inverse sin of " + main.OperandTwo);
                        return false;
                    }
                }
                else
                {
                    main.Operand = Convert.ToString(Math.Round(Math.Sin(main.OperandTwo * Math.PI / 180), 10));
                }
            }
            else
            {
                if (main.ParOpen > 3 && main.Input[main.ParOpen - 4] == 'a')
                {
                    if (main.OperandTwo >= -1 && main.OperandTwo <= 1)
                    {
                        main.Operand = Convert.ToString(Math.Round(Math.Asin(main.OperandTwo), 10));
                    }
                    else
                    {
                        calc.SetWarningLbl("Can't take inverse sin of " + main.OperandTwo);
                        return false;
                    }
                }
                else
                {
                    main.Operand = Convert.ToString(Math.Round(Math.Sin(main.OperandTwo), 10));
                }
            }

            return true;
        }

        public bool SolveCos(Main main, frmCalc calc)
        {
            if (Deg)
            {
                if (main.ParOpen > 3 && main.Input[main.ParOpen - 4] == 'a')
                {
                    if (main.OperandTwo >= -1 && main.OperandTwo <= 1)
                    {
                        main.Operand = Convert.ToString(Math.Round(Math.Acos(main.OperandTwo) * 180 / Math.PI, 10));
                    }
                    else
                    {
                        calc.SetWarningLbl("Can't take inverse cos of " + main.OperandTwo);
                        return false;
                    }
                }
                else
                {
                    main.Operand = Convert.ToString(Math.Round(Math.Cos(main.OperandTwo * Math.PI / 180), 10));
                }
            }
            else
            {
                if (main.ParOpen > 3 && main.Input[main.ParOpen - 4] == 'a')
                {
                    if (main.OperandTwo >= -1 && main.OperandTwo <= 1)
                    {
                        main.Operand = Convert.ToString(Math.Round(Math.Acos(main.OperandTwo), 10));
                    }
                    else
                    {
                        calc.SetWarningLbl("Can't take inverse cos of " + main.OperandTwo);
                        return false;
                    }
                }
                else
                {
                    main.Operand = Convert.ToString(Math.Round(Math.Cos(main.OperandTwo), 10));
                }
            }

            return true;
        }

        public bool SolveTan(Main main, frmCalc calc)
        {
            if (Deg)
            {
                if (main.ParOpen > 3 && main.Input[main.ParOpen - 4] == 'a')
                {
                    if (main.OperandTwo >= -1 && main.OperandTwo <= 1)
                    {
                        main.Operand = Convert.ToString(Math.Round(Math.Atan(main.OperandTwo) * 180 / Math.PI, 10));
                    }
                    else
                    {
                        calc.SetWarningLbl("Can't take inverse tan of " + main.OperandTwo);
                        return false;
                    }
                }
                else
                {
                    main.Operand = Convert.ToString(Math.Round(Math.Tan(main.OperandTwo * Math.PI / 180), 10));
                }
            }
            else
            {
                if (main.ParOpen > 3 && main.Input[main.ParOpen - 4] == 'a')
                {
                    if (main.OperandTwo >= -1 && main.OperandTwo <= 1)
                    {
                        main.Operand = Convert.ToString(Math.Round(Math.Atan(main.OperandTwo), 10));
                    }
                    else
                    {
                        calc.SetWarningLbl("Can't take inverse tan of " + main.OperandTwo);
                        return false;
                    }
                }
                else
                {
                    main.Operand = Convert.ToString(Math.Round(Math.Tan(main.OperandTwo), 10));
                }
            }

            return true;
        }
    }
}
