using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGUI
{
    class Roots
    {
        public bool SolveSquare(Main main, frmCalc calc)
        {
            main.OperandTwo = Convert.ToDouble(main.Input.Substring((main.ParOpen + 1), (main.ParClose - main.ParOpen - 1)));

            if (main.Input[main.ParOpen - 2] != '<')
            {
                calc.SetWarningLbl("Incorrect format!");
                return false;
            }

            if (main.OperandTwo < 0)
            {
                calc.SetWarningLbl("Can't take square root of negative number.");
                return false;
            }

            main.Operand = Convert.ToString(Math.Sqrt(main.OperandTwo));

            main.StartReplace = main.ParOpen - 2;

            return true;
        }

        public bool SolveN(Main main, frmCalc calc)
        {
            main.OperandCounter = main.ParOpen - 1;

            while (main.Input[main.OperandCounter] != '>')
            {
                main.OperandCounter--;
            }

            main.OperandCounter++;

            main.OperandOne = Convert.ToDouble(main.Input.Substring(main.OperandCounter, ((main.ParOpen - 1) - main.OperandCounter)));

            if (main.OperandOne % 2 == 0 && main.Input[main.ParOpen + 1] == '-')
            {
                calc.SetWarningLbl("Can't take even root of negative number.");

                return false;
            }
            else
            {
                main.OperandTwo = Convert.ToDouble(main.Input.Substring(main.ParOpen + 1, (main.ParClose - main.ParOpen - 1)));

                main.Operand = Convert.ToString(Math.Pow(Math.Abs(main.OperandTwo), (1.0 / main.OperandOne)));

                if (main.OperandTwo < 0)
                {
                    main.Operand = Convert.ToString(Convert.ToDouble(main.Operand) / -1);
                }

                main.StartReplace = main.OperandCounter - 1;
            }

            return true;
        }
    }
}
