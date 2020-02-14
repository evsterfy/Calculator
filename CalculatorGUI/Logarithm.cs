using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGUI
{
    class Logarithm
    {
        public void GetBase(Main main)
        {
            if (Char.IsDigit(main.Input[main.ParOpen - 1]))
            {
                main.OperandCounter = main.ParOpen - 1;
            }
            else if (main.Input[main.ParOpen - 1] == ')')
            {
                main.OperandCounter = main.ParOpen - 2;
            }

            while (main.OperandCounter >= 0 && (Char.IsDigit(main.Input[main.OperandCounter]) || main.Input[main.OperandCounter] == '.'))
            {
                main.OperandCounter--;
            }

            if (main.OperandCounter >= 0 && main.Input[main.OperandCounter] != '(')
            {
                main.OperandCounter++;
            }

            if (main.OperandCounter > 0 && main.Input[main.OperandCounter - 1] == 'b')
            {
                main.OperandOne = Convert.ToDouble(main.Input.Substring(main.OperandCounter, main.ParOpen - main.OperandCounter));
            }
        }

        public void SolveBase(Main main)
        {
            if (main.OperandCounter > 0 && main.Input[main.OperandCounter - 1] == 'b')
            {
                main.Operand = Convert.ToString(Math.Log(main.OperandTwo, main.OperandOne));

                main.StartReplace = main.OperandCounter - 4;
            }
        }

        public void SolveNatural(Main main)
        {
            main.Operand = Convert.ToString(Math.Log(main.OperandTwo));

            main.StartReplace = main.ParOpen - 2;
        }

        public void SolveBaseTen(Main main)
        {
            main.Operand = Convert.ToString(Math.Log10(main.OperandTwo));

            main.StartReplace = main.ParOpen - 3;
        }
    }
}
