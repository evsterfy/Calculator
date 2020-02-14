using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGUI
{
    class Mathematics
    {
        // Solves regular expressions based on the operator we pass.
        public void solveOperands(ref Main main)
        {
            switch (main.Input[main.IndexCurOp])
            {
                case '^':
                    main.Operand = Convert.ToString(Math.Pow(main.OperandOne, main.OperandTwo)); // pointless
                    break;

                case '*':
                    main.Operand = Convert.ToString(main.OperandOne * main.OperandTwo);
                    break;

                case '/':
                    main.Operand = Convert.ToString(main.OperandOne / main.OperandTwo);
                    break;

                case '%':
                    main.Operand = Convert.ToString(main.OperandOne % main.OperandTwo);
                    break;

                case '+':
                    main.Operand = Convert.ToString(main.OperandOne + main.OperandTwo);
                    break;

                case '-':
                    main.Operand = Convert.ToString(main.OperandOne - main.OperandTwo);
                    break;
            }

            // find the decimal point in the new main.Operand.
            main.Decimal = main.Operand.IndexOf('.');

            /* Just uncomment this out if you want to 'round' to certain amount of decimal places.
             * Currently rounds to 2 places.
             * 
            // if decimal is found, cut off at 2 decimal places. And if the two remaining places 
            // are 0, just erase.
            if (@decimal >= 0)
            {
                int decLen = main.Operand.Length - @decimal - 1;

                if (decLen > 2)
                {
                    main.Operand = main.Operand.Remove(@decimal + 3);
                }
                if (main.Operand[@decimal + 1] == '0' && main.Operand[@decimal + 2] == '0')
                {
                    main.Operand = main.Operand.Remove(@decimal);
                }
            } */
        }

        public void SolveRegular(Main main)
        {
            main.OperandCounter = main.IndexCurOp;

            main.GetOp2();

            main.EndReplace = main.OperandCounter;

            main.OperandCounter = main.IndexCurOp; // reset main.OperandCounter and go left

            main.GetOp1();

            main.StartReplace = main.OperandCounter;

            main.OperandCounter = main.IndexCurOp; // pointless

            main.LenReplace = main.EndReplace - main.StartReplace + 1;

            solveOperands(ref main);

            main.ReplaceOp();

            main.IndexCurOp = -1;

            main.CurOp = 0;
        }

        public bool ImplicitMultiplication(Main main, ref int iterateOp, ref bool operandGot)
        {
            int endImplicitOp = 0;
            main.StartReplace = 0;
            main.LenReplace = 0;

            // Get main.Operand inside parentheses for implicit multiplication.
            if (main.ParOpen > 0 && (Char.IsDigit(main.Input[main.ParOpen - 1]) || main.Input[main.ParOpen - 1] == ')'))
            {
                main.OperandTwo = Convert.ToDouble(main.Input.Substring(main.ParOpen + 1, (main.ParClose - main.ParOpen - 1)));
            }

            // Left to right, if left of main.ParOpen is digit, store the number for use in main.OperandOne.
            if (main.ParOpen > 0 && Char.IsDigit(main.Input[main.ParOpen - 1]))
            {
                main.StartReplace = main.ParOpen;
                endImplicitOp = main.StartReplace;
                main.StartReplace--;

                while ((main.StartReplace >= 0 && (Char.IsDigit(main.Input[main.StartReplace]) ||
                main.Input[main.StartReplace] == '.')) || (main.StartReplace > 0 && main.Input[main.StartReplace] == '-' &&
                (!Char.IsDigit(main.Input[main.StartReplace - 1]) && main.Input[main.StartReplace - 1] != ')')))
                {
                    main.StartReplace--;
                }

                main.StartReplace++;

                main.OperandOne = Convert.ToDouble(main.Input.Substring(main.StartReplace, endImplicitOp - main.StartReplace));
            }

            // No digit to left, store number in parentheses as main.OperandOne.
            // If to right of main.ParClose is parenthesis, remove parentheses from main.OperandOne.
            // After we do that, program should loop and remove any pairs around the second main.Operand
            // we want to get. Then come back here and iterate through string until it gets main.OperandTwo.
            else if (main.ParClose + 1 < main.Input.Length && (Char.IsDigit(main.Input[main.ParClose + 1]) || main.Input[main.ParClose + 1] == '('))
            {
                main.OperandOne = Convert.ToDouble(main.Input.Substring(main.ParOpen + 1, main.ParClose - main.ParOpen - 1));

                main.StartReplace = main.ParOpen;

                main.TempPastParClose++;

                if (iterateOp >= 6 && main.Input[main.ParClose + 1] == '(')
                {
                    main.Input = main.Input.Remove(main.ParClose, 1);
                    main.Input = main.Input.Remove(main.ParOpen, 1);

                    main.IndexCurOp = -1;
                    main.CurOp = 0;
                    return true;
                }

                if (main.Input[main.TempPastParClose] == '(')
                {
                    main.TempPastParClose++;
                }

                while (main.TempPastParClose < main.Input.Length && (Char.IsDigit(main.Input[main.TempPastParClose]) ||
                        main.Input[main.TempPastParClose] == '.' || (main.Input[main.TempPastParClose] == '-' &&
                        !Char.IsDigit(main.Input[main.TempPastParClose - 1]))))
                {
                    main.TempPastParClose++;
                }

                main.TempPastParClose--;

                if (main.ParClose < main.Input.Length - 2 && main.Input[main.ParClose + 1] == '(' && Char.IsDigit(main.Input[main.ParClose + 2]))
                {
                    main.OperandTwo = Convert.ToDouble(main.Input.Substring(main.ParClose + 2, (main.TempPastParClose - (main.ParClose + 1))));
                }
                else if (main.ParClose < main.Input.Length - 1 && Char.IsDigit(main.Input[main.ParClose + 1]))
                {
                    main.OperandTwo = Convert.ToDouble(main.Input.Substring(main.ParClose + 1, (main.TempPastParClose - main.ParClose)));
                }

                if (main.Input[main.ParClose + 1] == '(')
                {
                    main.LenReplace = Convert.ToString(main.OperandTwo).Length + (main.ParClose - main.ParOpen) + 3;
                }
                else
                {
                    main.LenReplace = Convert.ToString(main.OperandTwo).Length + (main.ParClose - main.ParOpen) + 1;
                }

            }


            // I forget what this does. I think I was having problems with main.Operand or
            // main.OperandTwo ending up with wrong values and this seems to have no problems.
            if (!operandGot)
            {
                main.Operand = Convert.ToString(main.OperandTwo);
            }

            // If replace is at index 0 and we have something in main.Operand, solve for new main.Operand.
            // If start is at 0, we don't have a negative before main.StartReplace.
            if (main.StartReplace == 0 && main.Operand.Length > 0)
            {
                main.Operand = Convert.ToString(main.OperandOne * Convert.ToDouble(main.Operand));
            }
            else
            {
                // If main.OperandOne is negative. Account for that.
                if (main.StartReplace > 0 && main.Input[main.StartReplace - 1] == '-')
                {
                    if (main.StartReplace == 1 || (!Char.IsDigit(main.Input[main.StartReplace - 2]) &&
                                                main.Input[main.StartReplace - 2] != ')'))
                    {
                        if (main.Operand.Length > 0)
                        {
                            main.Operand = Convert.ToString((main.OperandOne / -1) * Convert.ToDouble(main.Operand));
                        }
                        else
                        {
                            main.Operand = Convert.ToString((main.OperandOne / -1) * main.OperandTwo);
                        }

                        main.StartReplace--;

                        if (main.LenReplace > 0)
                        {
                            main.LenReplace++;
                        }
                    }
                }

                // Else just multiply opOne and opTwo.
                else
                {
                    if (main.Operand.Length > 0)
                    {
                        main.Operand = Convert.ToString(main.OperandOne * Convert.ToDouble(main.Operand));
                    }
                    else
                    {
                        main.Operand = Convert.ToString(main.OperandOne * main.OperandTwo);
                    }
                }
            }

            // Insert parentheses around the substr to replace, to not cause problems with
            // the next loop.
            if (main.LenReplace == 0)
            {
                main.LenReplace = main.ParClose - main.StartReplace + 1;

                main.Input = main.Input.Insert(main.StartReplace, "(");
                main.Input = main.Input.Insert((main.StartReplace + main.LenReplace), ")");
            }
            else
            {
                main.Input = main.Input.Insert(main.StartReplace, "(");
                main.Input = main.Input.Insert((main.StartReplace + main.LenReplace + 1), ")");
            }

            main.StartReplace++;
            main.EndReplace++;
            return true;
        }
    }
}
