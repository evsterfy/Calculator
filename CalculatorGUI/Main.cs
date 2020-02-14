using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGUI
{
    class Main
    {
        private string prevAns = String.Empty;
        private string input = String.Empty;
        private readonly string operators = "^*/%+-";
        private double operandOne = 0;
        private double operandTwo = 0;
        private string operand = String.Empty;
        private int @decimal = 0;
        private int parOpen = 0;
        private int parClose = 0;
        private int parCount = 0;
        private int curOp = 0;
        private int indexCurOp = 0;
        private int indexPrecOp = 0;
        private int switchPrecOp = 0;
        private int startReplace = 0;
        private int endReplace = 0;
        private int lenReplace = 0;
        private int subLen = 0;
        private int operandCounter = 0;
        private int tempPastParClose = 0;
        private Trigonometry trig = new Trigonometry();
        private Logarithm log = new Logarithm();
        private Roots root = new Roots();
        private Mathematics maths = new Mathematics();

        public string Input { get => input; set => input = value; }
        public string Operators => operators;
        public double OperandOne { get => operandOne; set => operandOne = value; }
        internal Trigonometry Trig { get => trig; set => trig = value; }
        internal Logarithm Log { get => log; set => log = value; }
        internal Roots Root { get => root; set => root = value; }
        internal Mathematics Maths { get => maths; set => maths = value; }
        public double OperandTwo { get => operandTwo; set => operandTwo = value; }
        public string Operand { get => operand; set => operand = value; }
        public int Decimal { get => @decimal; set => @decimal = value; }
        public int ParOpen { get => parOpen; set => parOpen = value; }
        public int ParClose { get => parClose; set => parClose = value; }
        public int ParCount { get => parCount; set => parCount = value; }
        public int CurOp { get => curOp; set => curOp = value; }
        public int IndexCurOp { get => indexCurOp; set => indexCurOp = value; }
        public int IndexPrecOp { get => indexPrecOp; set => indexPrecOp = value; }
        public int SwitchPrecOp { get => switchPrecOp; set => switchPrecOp = value; }
        public int StartReplace { get => startReplace; set => startReplace = value; }
        public int EndReplace { get => endReplace; set => endReplace = value; }
        public int LenReplace { get => lenReplace; set => lenReplace = value; }
        public int SubLen { get => subLen; set => subLen = value; }
        public int OperandCounter { get => operandCounter; set => operandCounter = value; }
        public int TempPastParClose { get => tempPastParClose; set => tempPastParClose = value; }
        public string PrevAns { get => prevAns; set => prevAns = value; }

        // Count parentheses pairs and return error if non-matching.
        public void CheckParentheses()
        {
            for (int y = 0; y < Input.Length; y++)
            {
                if (Input[y] == '(')
                {
                    ParCount++;
                }
                else if (Input[y] == ')')
                {
                    ParCount--;
                }
            }
        }

        // Replace spaces, e, and Pi with respective #.
        // Add parentheses around # to support implicit multiplcation.
        public void ReplaceInput()
        {
            Input = Input.Replace(" ", String.Empty);
            Input = Input.Replace("e", "(" + Math.E.ToString() + ")");
            Input = Input.Replace("Pi", "(" + Math.PI.ToString() + ")");
        }

        public int GetOperator()
        {
            int iterateOp = 0;
            IndexCurOp = -1;

            // Loop through each operator in 'operators' until we find one at an index inside
            // the parentheses pair. We start at index 0 for 'operators' because the string
            // is written with higher precedence on left.
            while ((IndexCurOp < 0 || IndexCurOp < ParOpen || IndexCurOp > ParClose)
                        && iterateOp < 6)
            {
                IndexCurOp = Input.IndexOf(Convert.ToString(operators[iterateOp]), ParOpen);

                // If we get to this statement, it didn't find any other operators besides '-'
                // so if it is a negative sign and not a minus sign, we check for any minus
                // past it. If we don't find one at all or if it is past the current
                // parentheses pair, IndexCurOp is set to -1 and we handle that later.
                if (iterateOp == 5 && IndexCurOp > ParOpen && IndexCurOp < ParClose)
                {
                    if (Input[IndexCurOp - 1] == '(')
                    {
                        IndexCurOp = Input.IndexOf(Convert.ToString(operators[5]), IndexCurOp + 1);

                        if (IndexCurOp >= 0 && IndexCurOp > ParOpen + 1 && IndexCurOp > ParClose)
                        {
                            IndexCurOp = -1;
                        }
                    }
                }

                iterateOp++;
            }

            return iterateOp;
        }

        // -(-8/-7+-6--5*-4^3)+-(-8/-7+-6--5*-4^3)
        public double Solve(string XWithH, frmCalc calc, Trigonometry trig)
        {
            if (XWithH == String.Empty)
            {
                Input = calc.GetInputBox();
            }
            else
            {
                Input = XWithH;
            }

            if (trig != null)
            {
                Trig = trig;
            }

            CheckParentheses();

            if (ParCount != 0)
            {
                calc.SetWarningLbl("Non-Matching Parentheses");
                return 0;
            }
            else
            {
                calc.SetWarningLbl(String.Empty);
            }

            ReplaceInput();

            // Loop is pretty much just for finding the operator in the Input.
            // And for kepping the calculation running until we solve the whole equation.
            // Most of the time I look for the operator we are currently on in 'operators' string.
            // Some statements change the Input/output string and we just reset IndexCurOp and 
            // curOp (current operator in 'operators') to 0 and keep looping until it hits a condition
            // that checks if there are any operators at all in the Input/output string.
            for (IndexCurOp = 0; IndexCurOp < Input.Length; IndexCurOp++)
            {
                // Left to right. Find first closing parenthesis, if it doesn't exist, we handle that.
                ParClose = Input.IndexOf(Convert.ToString(')'));
                ParOpen = ParClose;

                // If Input string has parentheses at any time, we run this statement and don't really
                // ever go past it until all pairs are removed/solved.
                // Just continue the for loop after we make changes to Input/output.
                if (ParOpen >= 0)
                {
                    // Iterate backwards through Input until it finds an opening parenthesis.
                    while (Input[ParOpen] != '(')
                    {
                        ParOpen--;
                    }

                    // Just to make sure the while loop didn't mess up.
                    if (ParOpen >= 0)
                    {
                        int iterateOp = GetOperator();


                        // If we find any operator inside the parentheses, decrement iterateOp
                        // because it will be 1 number too high from previous while. Then set
                        // curOp to the same operator as IndexCurOp, not the same index, but the
                        // same operator in their respective strings.

                        /* If iterateOp isn't the same index as '-' in 'operators', we have to handle
                         * precedence. In other words, don't check precedence if we are looking at '-'.
                         * Because we handle negatives in other statements and loop through 'operators'
                         * and handle precedence of '+' anyway.
                         * If iterateOp is index of '^' we don't have to deal with precedence.
                         * 
                         * GetPrecedence() checks for precedence of other same level operators.
                         */
                        if (IndexCurOp >= 0 && IndexCurOp < ParClose && IndexCurOp > ParOpen)
                        {
                            iterateOp--;
                            CurOp = operators.IndexOf(Input[IndexCurOp]);

                            if (iterateOp < 5 && operators[iterateOp] != '^')
                            {
                                GetPrecedence();
                            }
                        }


                        // At this point, if we searched for the best operator and didn't find it
                        // or it's outside the parentheses and we have tested every operator (iterateOp)
                        // we know we just need to check for implicit multiplication, negatives, and
                        // functions and solve them.
                        if ((IndexCurOp < 0 || IndexCurOp < ParOpen || IndexCurOp > ParClose) &&
                                iterateOp >= 6)
                        {
                            // Removed a pair of parentheses, restart loop.
                            if (RemoveParentheses()) { continue; }

                            // If char to left of parOpen is a function or digit.
                            // Anything we do in this statement results in resetting index variables
                            // and looping again. Each of these statements does different calculations
                            // and replaces different lengths in the Input/output string.
                            if ((ParOpen > 0 && (Input[ParOpen - 1] == '>' || Input[ParOpen - 1] == '<' ||
                                Input[ParOpen - 1] == 'g' || Input[ParOpen - 1] == 'n' || Input[ParOpen - 1] == 's' ||
                                Char.IsDigit(Input[ParOpen - 1]) || Input[ParOpen - 1] == ')')) ||
                                (ParClose + 1 < Input.Length && (Char.IsDigit(Input[ParClose + 1]) ||
                                    Input[ParClose + 1] == '(')))
                            {
                                // If we already store a substr in 'operand' set to true
                                // so we don't replace it later on.
                                bool operandGot = false; 

                                StartReplace = 0;

                                TempPastParClose = ParClose;


                                // nth root statement. 
                                // Find start of nth root syntax '>' and
                                // store the root. If root is even number and other operand is negative
                                // return warning. Otherwise just take nth root of number inside parentheses.
                                if (ParOpen > 0 && !operandGot && Input[ParOpen - 1] == '<')
                                {
                                    bool solved = Root.SolveN(this, calc);

                                    if (!solved) return 0;

                                    operandGot = true;
                                }

                                // Square root.
                                // If operand is negative, return warning.
                                // Otherwise replace square root of operandTwo in string.
                                else if (ParOpen > 0 && !operandGot && Input[ParOpen - 1] == '>')
                                {
                                    bool solved = Root.SolveSquare(this, calc);

                                    if (!solved) return 0;

                                    operandGot = true;
                                }

                                // sin/cos/tan.
                                else if (!operandGot && (ParOpen > 2 && 
                                        ((Input[ParOpen - 1] == 'n' && Input[ParOpen - 2] != 'l') ||
                                            Input[ParOpen - 1] == 's')))
                                {
                                    OperandTwo = Convert.ToDouble(Input.Substring((ParOpen + 1), (ParClose - ParOpen - 1)));

                                    // sin or tan.
                                    if (Input[ParOpen - 1] == 'n')
                                    {
                                        // sin.
                                        // Support for degrees or radians.
                                        if (Input[ParOpen - 2] == 'i')
                                        {
                                            bool solved = Trig.SolveSin(this, calc);

                                            if (!solved) { return 0; }
                                        }

                                        // tan.
                                        // Degrees or radians.
                                        else if (Input[ParOpen - 2] == 'a')
                                        {
                                            bool solved = Trig.SolveTan(this, calc);

                                            if (!solved) { return 0; }
                                        }

                                        operandGot = true;
                                    }

                                    // cos.
                                    // Degrees or radians.
                                    else if (Input[ParOpen - 1] == 's')
                                    {
                                        OperandTwo = Convert.ToDouble(Input.Substring((ParOpen + 1), (ParClose - ParOpen - 1)));

                                        bool solved = Trig.SolveCos(this, calc);

                                        if (!solved) { return 0; }

                                        operandGot = true;
                                    }


                                    // Starting index of replacement. If (index - 1) is 'a', decrement.
                                    StartReplace = ParOpen - 3;

                                    if (ParOpen > 3 && Input[ParOpen - 4] == 'a')
                                    {
                                        StartReplace--;
                                    }
                                }

                                // Gets the base of a log. Syntax is 'logb(b)(x)' -- parentheses required
                                // for equations within pair, otherwise if just a number, not required.
                                if ((ParOpen > 0 && Char.IsDigit(Input[ParOpen - 1])) || (ParOpen > 1 && Char.IsDigit(Input[ParOpen - 2])))
                                {
                                    Log.GetBase(this);
                                }

                                // log/ln statement.
                                if (!operandGot && ((ParOpen > 1 && (Input[ParOpen - 1] == 'g' ||
                                        (ParOpen > 1 && Input[ParOpen - 1] == 'n' && Input[ParOpen - 2] == 'l')))
                                            || (OperandCounter > 0 && Input[OperandCounter - 1] == 'b')))
                                {
                                    // Operand inside parentheses.
                                    OperandTwo = Convert.ToDouble(Input.Substring(ParOpen + 1, (ParClose - ParOpen - 1)));

                                    // Can't take log of negative number.
                                    if (OperandTwo < 0)
                                    {
                                        calc.SetWarningLbl("Incorrect log operand");
                                        return 0;
                                    }

                                    // Solve log with base.
                                    if ((Char.IsDigit(Input[ParOpen - 1])))
                                    {
                                        Log.SolveBase(this);
                                    }

                                    // Solve natural log.
                                    else if (ParOpen > 1 && Input[ParOpen - 1] == 'n' && Input[ParOpen - 2] == 'l')
                                    {
                                        Log.SolveNatural(this);
                                    }

                                    // Solve log10.
                                    else if (Input[ParOpen - 1] == 'g')
                                    {
                                        Log.SolveBaseTen(this);
                                    }

                                    operandGot = true;
                                }


                                // Implicit multiplication.
                                if (!operandGot && ((StartReplace > 0 && Char.IsDigit(Input[StartReplace - 1])) ||
                                    (ParOpen > 0 && (Char.IsDigit(Input[ParOpen - 1]) || Input[ParOpen - 1] == ')')) ||
                                    (ParClose + 1 < Input.Length && (Char.IsDigit(Input[ParClose + 1]) ||
                                    Input[ParClose + 1] == '('))))
                                {
                                    bool solved = Maths.ImplicitMultiplication(this, ref iterateOp, ref operandGot);

                                    if (solved)
                                    {
                                        ReplaceOp();

                                        IndexCurOp = -1;
                                        CurOp = 0;

                                        continue;
                                    }
                                }


                                // Length of operands, operators, parenthses etc to replace.
                                LenReplace = ParClose - StartReplace + 1;

                                // Parentheses around replacement.
                                Input = Input.Insert(StartReplace, "(");
                                Input = Input.Insert((StartReplace + LenReplace), ")");

                                // Increment because we added parentheses.
                                StartReplace++;

                                ReplaceOp();

                                IndexCurOp = -1;
                                CurOp = 0;
                                continue;
                            }

                            // Deals with negative signs. If inside of parOpen.
                            if (Input[ParOpen + 1] == '-')
                            {
                                // If double negative, remove both and parentheses.
                                if (ParOpen > 0 && Input[ParOpen - 1] == '-')
                                {
                                    Input = Input.Remove(ParClose, 1);
                                    Input = Input.Remove(ParOpen - 1, 3);
                                }

                                // Just remove parentheses.
                                else
                                {
                                    Input = Input.Remove(ParClose, 1);
                                    Input = Input.Remove(ParOpen, 1);
                                }
                            }

                            // Otherwise if outside of parOpen just remove parentheses.
                            else if ((ParOpen > 0 && Input[ParOpen - 1] == '-') || ParOpen >= 0)
                            {
                                Input = Input.Remove(ParClose, 1);
                                Input = Input.Remove(ParOpen, 1);
                            }

                            IndexCurOp = -1;
                            CurOp = 0;
                            continue;
                        }

                        // Just solve regular expressions inside the parentheses pair.
                        else if (IndexCurOp >= 0)
                        {
                            Maths.SolveRegular(this);

                            continue;
                        }
                    }
                }

                // No parentheses. Fix '-0'?
                else
                {
                    // Not sure if this is needed after fixing a few things but it doesn't hurt.
                    if (Input.IndexOf(operators[0]) < 0 && Input.IndexOf(operators[1]) < 0
                        && Input.IndexOf(operators[2]) < 0 && Input.IndexOf(operators[3]) < 0
                        && Input.IndexOf(operators[4]) < 0)
                    {
                        if (Input.IndexOf(operators[5]) == 0)
                        {
                            if (Input.LastIndexOf(operators[5]) == 0)
                            {
                                if (Input == "-0")
                                {
                                    Input = "0";
                                }

                                PrevAns = Input;
                                calc.SetInputBox(Input);
                                return Convert.ToDouble(Input);
                            }
                        }
                        else if (Input.IndexOf(operators[5]) < 0)
                        {
                            PrevAns = Input;
                            calc.SetInputBox(Input);
                            return Convert.ToDouble(Input);
                        }
                    }
                }


                // Finds an operator. Can be used to decide to remove a pair of parentheses.
                if (ParOpen >= 0 && CurOp < 6)
                {
                    IndexCurOp = Input.IndexOf((Convert.ToString(operators[CurOp])), ParOpen);
                }
                else if (CurOp < 6)
                {
                    IndexCurOp = Input.IndexOf((Convert.ToString(operators[CurOp])));
                }


                int iTemp = IndexCurOp;


                // If IndexCurOp is a negative sign, find the next valid minus sign.
                if (IndexCurOp >= 0 && Input[IndexCurOp] == '-')
                {
                    while (IndexCurOp > 0 && (!(Char.IsDigit(Input[IndexCurOp - 1])) &&
                            Input[IndexCurOp - 1] != ')'))
                    {
                        IndexCurOp = Input.IndexOf(Convert.ToString(operators[5]), IndexCurOp + 1);
                    }

                    if (IndexCurOp < 0 || IndexCurOp > ParClose)
                    {
                        IndexCurOp = iTemp;
                    }
                }


                // if we are testing '-', no other operators after it so just set switchPrecOp to false.
                if (CurOp + 1 == 5)
                {
                    SwitchPrecOp = -1;
                }
                else if (CurOp >= 6)
                {
                    CurOp = 0;
                    IndexCurOp = -1;
                    continue;
                }

                // (*, /, and %) and also (+ and -) are same precedence so we have to make sure 
                // and do the first one of the pairs.
                else if (CurOp < 5 && (operators[CurOp] != '^'))
                {
                    GetPrecedence();
                }


                // If the current operator is outside of the parentheses pair, increment current operator to look for.
                if ((ParClose >= 0 && ParOpen >= 0 && IndexCurOp > ParClose) || IndexCurOp < 0)
                {
                    if (CurOp == 5)
                    {
                        CurOp = 0;
                    }
                    else
                    {
                        CurOp++;
                    }

                    IndexCurOp = -1;
                    continue;
                }


                // If we changed IndexCurOp because of precedence, set curOp to match.
                if (IndexCurOp >= 0 && (Input[IndexCurOp] != operators[CurOp]))
                {
                    CurOp = operators.IndexOf(Input[IndexCurOp]);
                }


                // If current operator working with is '-' and it is at index 0, find next.
                if (CurOp == 5)
                {
                    if (Input[IndexCurOp] == operators[CurOp] && Char.IsDigit(Input[IndexCurOp + 1])
                        && IndexCurOp == 0)
                    {
                        IndexCurOp = Input.IndexOf(Convert.ToString(operators[5]), IndexCurOp + 1);
                    }
                }


                // Solve regular expression.
                Maths.SolveRegular(this);
                
            } // end for


            // Just in case...
            calc.SetInputBox(Input);
            PrevAns = calc.GetInputBox();
            return Convert.ToDouble(Input);
        }

        public bool RemoveParentheses()
        {
            int tempIndex = ParOpen;
            tempIndex++;

            while (tempIndex < ParClose + 1 && (Char.IsDigit(Input[tempIndex]) ||
                    Input[tempIndex] == '.'))
            {
                tempIndex++;
            }

            if (((ParOpen > 0 && (Input[ParOpen - 1] == '>' || Input[ParOpen - 1] == '-'))
                && (ParClose + 1 < Input.Length && Input[ParClose + 1] == '<')))
            {
                Input = Input.Remove(ParClose, 1);
                Input = Input.Remove(ParOpen, 1);

                IndexCurOp = -1;
                CurOp = 0;
                return true;
            }

            // Need to review this *********************
            else if (tempIndex == ParClose)
            {
                if ((ParOpen > 0 && ParClose + 1 < Input.Length) &&
                    ((Input[ParOpen - 1] == '>' && Input[ParClose + 1] == '<') ||
                    Input[ParOpen - 1] == 'b'))
                {
                    Input = Input.Remove(ParClose, 1);
                    Input = Input.Remove(ParOpen, 1);

                    IndexCurOp = -1;
                    CurOp = 0;
                    return true;
                }
            }

            return false;
        }

        // Replace subtstr with solved expression.
        public void ReplaceOp()
        {
            Input = Input.Remove(startReplace, lenReplace);
            Input = Input.Insert(startReplace, operand);
        }


        // Checks for precedence of same level operators.
        public void GetPrecedence()
        {
            List<int> tempHighPrec = new List<int>(new int[3]);
            List<int> tempLowPrec = new List<int>(new int[2]);

            // No parentheses.
            // Inserts the indices of the high level operators into a list.
            // Then checks if they are -1 -- don't exist and removes if true.
            // Then sets IndexCurOp to the min of the remaining existing operators.

            // If low level operators, just sets IndexCurOp and indexPrecOp to first index of each.
            // Solves for correct precedence after.
            if (ParOpen < 0)
            {
                if (Input[0] == '-')
                {
                    IndexPrecOp = Input.IndexOf((Convert.ToString(operators[CurOp + 1])), 1);
                }
                else
                {
                    if (CurOp == 1 || CurOp == 2 || CurOp == 3)
                    {
                        for (int g = 0; g < tempHighPrec.Count; g++)
                        {
                            tempHighPrec[g] = Input.IndexOf(Convert.ToString(operators[g + 1]));
                        }

                        for (int g = 0; g < tempHighPrec.Count; g++)
                        {
                            if (tempHighPrec[g] < 0)
                            {
                                tempHighPrec.RemoveAt(g);
                                g--;
                            }
                        }

                        for (int g = 0; g < tempHighPrec.Count; g++)
                        {
                            if (g + 1 != tempHighPrec.Count)
                            {
                                IndexCurOp = Math.Min(tempHighPrec[g], tempHighPrec[g + 1]);
                            }

                            if (tempHighPrec.Count == 1)
                            {
                                IndexCurOp = tempHighPrec[0];
                            }
                        }

                        SwitchPrecOp = -1;
                    }
                    else
                    {
                        for (int g = 0; g < tempLowPrec.Count; g++)
                        {
                            tempLowPrec[g] = Input.IndexOf(Convert.ToString(operators[g + 4]));
                        }

                        SwitchPrecOp = 0;

                        IndexCurOp = tempLowPrec[0];
                        IndexPrecOp = tempLowPrec[1];
                    }
                }
            }

            // Parentheses.
            // Same as above but checking if operators are outside of parentheses.
            else if (ParOpen >= 0)
            {
                if (CurOp == 1 || CurOp == 2 || CurOp == 3)
                {
                    for (int g = 0; g < tempHighPrec.Count; g++)
                    {
                        tempHighPrec[g] = Input.IndexOf(Convert.ToString(operators[g + 1]), ParOpen);
                    }

                    for (int g = 0; g < tempHighPrec.Count; g++)
                    {
                        if (tempHighPrec[g] < 0 || tempHighPrec[g] > ParClose || tempHighPrec[g] < ParOpen)
                        {
                            tempHighPrec.RemoveAt(g);
                            g--;
                        }
                    }

                    for (int g = 0; g < tempHighPrec.Count; g++)
                    {
                        if (g + 1 != tempHighPrec.Count)
                        {
                            IndexCurOp = Math.Min(tempHighPrec[g], tempHighPrec[g + 1]);
                        }

                        if (tempHighPrec.Count == 1)
                        {
                            IndexCurOp = tempHighPrec[0];
                        }
                    }

                    SwitchPrecOp = -1;
                }
                else
                {
                    for (int g = 0; g < tempLowPrec.Count; g++)
                    {
                        tempLowPrec[g] = Input.IndexOf(Convert.ToString(operators[g + 4]), ParOpen);
                    }

                    SwitchPrecOp = 0;

                    IndexCurOp = tempLowPrec[0];
                    IndexPrecOp = tempLowPrec[1];

                    if (IndexCurOp > ParClose)
                    {
                        IndexCurOp = -1;
                    }
                    if (IndexPrecOp > ParClose)
                    {
                        IndexPrecOp = -1;
                    }
                }
            }

            // Takes min of IndexCurOp and precOp, this only runs if we didn't set switch to
            // -1 because we were working with 3 high level operators.
            if (SwitchPrecOp >= 0)
            {
                SwitchPrecOp = Math.Min(IndexCurOp, IndexPrecOp);
            }

            // Sets IndexCurOp to switchPrecOp if it has high precedence.
            if (SwitchPrecOp > 0)
            {
                if (Input[SwitchPrecOp] != '-' && Char.IsDigit(Input[SwitchPrecOp - 1]) &&
                    (Math.Min(IndexCurOp, IndexPrecOp) == IndexPrecOp))
                {
                    IndexCurOp = SwitchPrecOp;
                }
            }
        }


        // Gets operandTwo for a regular expression.
        // Loops forwards starting at IndexCurOp until it reaches something other than the number.
        // Then stores the number and sets a substr length to extend once we solve for operandOne.
        public void GetOp2()

        {
            OperandCounter++;

            if (Input[OperandCounter] == '-')
            {
                OperandCounter++;

                while (OperandCounter >= 0 && OperandCounter < Input.Length &&
                        (Char.IsDigit(Input[OperandCounter]) || Input[OperandCounter] == '.'))
                {
                    OperandCounter++;
                }
            }
            else
            {
                while (OperandCounter >= 0 && OperandCounter < Input.Length &&
                        (Char.IsDigit(Input[OperandCounter]) || Input[OperandCounter] == '.'))
                {
                    OperandCounter++;
                }
            }



            if (OperandCounter >= Input.Length)
            {
                OperandCounter = Input.Length - 1;
            }
            else
            {
                OperandCounter--;
            }

            SubLen = OperandCounter - IndexCurOp;

            OperandTwo = Convert.ToDouble(Input.Substring(IndexCurOp + 1, SubLen));
        }


        // Solves for operandOne in the same way as GetOp2().
        public void GetOp1()
        {
            OperandCounter--;

            // Going left.
            while (OperandCounter >= 0 && OperandCounter < Input.Length &&
                    (Char.IsDigit(Input[OperandCounter]) || Input[OperandCounter] == '.'))
            {
                OperandCounter--;
            }


            if (OperandCounter < 0)
            {
                OperandCounter = 0;
            }
            else
            {
                if (Input[OperandCounter] == '-')
                {
                    if (OperandCounter != 0 && Char.IsDigit(Input[OperandCounter - 1]))
                    {
                        OperandCounter++;
                    }
                }
                else
                {
                    OperandCounter++;
                }
            }

            SubLen = IndexCurOp - OperandCounter;

            OperandOne = Convert.ToDouble(Input.Substring(OperandCounter, SubLen));
        }
    }
}
