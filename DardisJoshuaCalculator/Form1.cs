using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DardisJoshuaCalculator
{
    public partial class calculatorForm : Form
    {
        // holds the operation that will perform once equal is pressed
        int operation;
        // first number entered in textIO
        double firstNumber = double.NaN;
        // second number entered in textIO
        double secondNumber = double.NaN;
        // Holds the current operations that have been used in a string
        string history;

        public calculatorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// calculations computes the new value to be held by firstNumber
        /// </summary>
        private void calculations(int currOperation) 
        {
            Double.TryParse(this.txtIO.Text, out this.secondNumber);
            // if this.operation equals 1, the plus operations will run
            if (currOperation == 1)
            {
                this.firstNumber += this.secondNumber;
                this.history += " + " + this.secondNumber.ToString();
            }
            // if this.operation equals 2, the subtraction operations will run
            else if (currOperation == 2)
            {
                this.firstNumber -= this.secondNumber;
                this.history += " - " + this.secondNumber.ToString();
            }
            // if this.operation equals 3, the multiplication operations will run
            else if (currOperation == 3)
            {
                this.firstNumber *= this.secondNumber;
                this.history += " x " + this.secondNumber.ToString();
            }
            // if this.operation equals 4, the division operations will run
            else if (currOperation == 4)
            {
                if (this.secondNumber == 0)
                {
                    this.history += " / " + this.secondNumber.ToString();
                    this.firstNumber = double.NaN;
                }
                else
                {
                    this.firstNumber /= this.secondNumber;
                    this.history += " / " + this.secondNumber.ToString();
                }
            }
            // if this.operation equals 5, the power operations will run
            else if (currOperation == 5)
            {
                this.firstNumber = Math.Pow(this.firstNumber, this.secondNumber);
                this.history += " ^ " + this.secondNumber.ToString();
            }
        }

        /// <summary>
        /// initializes the form
        /// </summary>
        /// <param name="sender">butten object</param>
        /// <param name="e">event type</param>
        private void calculatorForm_Load(object sender, EventArgs e)
        {
            // KeyPress is attactech to the Form1_KeyPress function to link the function with the form
            KeyPress += calculatorForm_KeyPress;
        }

        /// <summary>
        /// Handles keys entered by the user
        /// </summary>
        /// <param name="sender">butten object</param>
        /// <param name="e">event type</param>
        private void calculatorForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch ((int)e.KeyChar)
            {
                // runs if 'backspace' is entered
                case 8:
                    btnDel_Click(btnDel, new EventArgs());
                    break;
                // runs if 'enter' or '=' is entered
                case 61:
                case 13:
                    btnEquals_Click(btnEquals, new EventArgs());
                    break;
                // runs if '+' is entered
                case 43:
                    btnAdd_Click(btnAdd, new EventArgs());
                    break;
                // runs if '-' is entered
                case 45:
                    btnSub_Click(btnSub, new EventArgs());
                    break;
                // runs if '.' is entered
                case 46:
                    btnDec_Click(btnDec, new EventArgs());
                    break;
                // runs if '/' is entered
                case 47:
                    btnDiv_Click(btnDiv, new EventArgs());
                    break;
                // runs if '0' is entered
                case 48:
                    btn0_Click( btn0, new EventArgs());
                    break;
                // runs if '1' is entered
                case 49:
                    btn1_Click_1(btn1, new EventArgs());
                    break;
                // runs if '2' is entered
                case 50:
                    btn2_Click_1(btn2, new EventArgs());
                    break;
                // runs if '3' is entered
                case 51:
                    btn3_Click_1(btn3, new EventArgs());
                    break;
                // runs if '4' is entered
                case 52:
                    btn4_Click(btn4, new EventArgs());
                    break;
                // runs if '5' is entered
                case 53:
                    btn5_Click(btn5, new EventArgs());
                    break;
                // runs if '6' is entered
                case 54:
                    btn6_Click(btn6, new EventArgs());
                    break;
                // runs if '7' is entered
                case 55:
                    btn7_Click(btn7, new EventArgs());
                    break;
                // runs if '8' is entered
                case 56:
                    btn8_Click(btn8, new EventArgs());
                    break;
                // runs if '0' is entered
                case 57:
                    btn9_Click(btn9, new EventArgs());
                    break;
                // runs if '^' is entered
                case 94:
                    btnPow_Click(btnPow, new EventArgs());
                    break;
                // runs if 'x', 'X', or '*' is entered
                case 42:
                case 88:
                case 120:
                    btnMult_Click(btnMult, new EventArgs());
                    break;

                default:
                    break;
            }
        }

        #region
        /// <summary>
        /// Handles event when btn0 is pressed
        /// </summary>
        /// <param name="sender">butten object</param>
        /// <param name="e">event type</param>
        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtIO.Text == "0")
            {
                this.txtIO.Text = "0";
            } else
            {
                this.txtIO.Text += "0";
            }
        }
        /// <summary>
        /// Handles event when btn1 is pressed
        /// </summary>
        /// <param name="sender">butten object</param>
        /// <param name="e">event type</param>
        private void btn1_Click_1(object sender, EventArgs e)
        {
            // replace 0 with 1 or add 1 onto end of number in the textbox
            if (txtIO.Text == "0")
            {
                this.txtIO.Text = "1";
            }
            else
            {
                this.txtIO.Text += "1";
            }
        }
        /// <summary>
        /// Handles event when btn2 is pressed
        /// </summary>
        /// <param name="sender">butten object</param>
        /// <param name="e">event type</param>
        private void btn2_Click_1(object sender, EventArgs e)
        {
            // replace 0 with 2 or add 2 onto end of number in the textbox
            if (this.txtIO.Text == "0")
            {
                this.txtIO.Text = "2";
            }
            else
            {
                this.txtIO.Text += "2";
            }
        }
        /// <summary>
        /// Handles event when btn3 is pressed
        /// </summary>
        /// <param name="sender">butten object</param>
        /// <param name="e">event type</param>
        private void btn3_Click_1(object sender, EventArgs e)
        {
            // replace 0 with 3 or add 3 onto end of number in the textbox
            if (this.txtIO.Text == "0")
            {
                this.txtIO.Text = "3";
            }
            else
            {
                this.txtIO.Text += "3";
            }
        }
        /// <summary>
        /// Handles event when btn4 is pressed
        /// </summary>
        /// <param name="sender">butten object</param>
        /// <param name="e">event type</param>
        private void btn4_Click(object sender, EventArgs e)
        {
            // replace 0 with 4 or add 4 onto end of number in the textbox
            if (this.txtIO.Text == "0")
            {
                this.txtIO.Text = "4";
            }
            else
            {
                this.txtIO.Text += "4";
            }
        }
        /// <summary>
        /// Handles event when btn5 is pressed
        /// </summary>
        /// <param name="sender">butten object</param>
        /// <param name="e">event type</param>
        private void btn5_Click(object sender, EventArgs e)
        {
            // replace 0 with 5 or add 5 onto end of number in the textbox
            if (this.txtIO.Text == "0")
            {
                this.txtIO.Text = "5";
            }
            else
            {
                this.txtIO.Text += "5";
            }
        }
        /// <summary>
        /// Handles event when btn6 is pressed
        /// </summary>
        /// <param name="sender">butten object</param>
        /// <param name="e">event type</param>
        private void btn6_Click(object sender, EventArgs e)
        {
            // replace 0 with 6 or add 6 onto end of number in the textbox
            if (this.txtIO.Text == "0")
            {
                this.txtIO.Text = "6";
            }
            else
            {
                this.txtIO.Text += "6";
            }
        }
        /// <summary>
        /// Handles event when btn7 is pressed
        /// </summary>
        /// <param name="sender">butten object</param>
        /// <param name="e">event type</param>
        private void btn7_Click(object sender, EventArgs e)
        {
            // replace 0 with 7 or add 7 onto end of number in the textbox
            if (this.txtIO.Text == "0")
            {
                this.txtIO.Text = "7";
            }
            else
            {
                this.txtIO.Text += "7";
            }
        }
        /// <summary>
        /// Handles event when btn8 is pressed
        /// </summary>
        /// <param name="sender">butten object</param>
        /// <param name="e">event type</param>
        private void btn8_Click(object sender, EventArgs e)
        {
            // replace 0 with 8 or add 8 onto end of number in the textbox
            if (this.txtIO.Text == "0")
            {
                this.txtIO.Text = "8";
            }
            else
            {
                this.txtIO.Text += "8";
            }
        }
        /// <summary>
        /// Handles event when btn9 is pressed
        /// </summary>
        /// <param name="sender">butten object</param>
        /// <param name="e">event type</param>
        private void btn9_Click(object sender, EventArgs e)
        {
            // replace 0 with 9 or add 9 onto end of number in the textbox
            if (this.txtIO.Text == "0")
            {
                this.txtIO.Text = "9";
            }
            else
            {
                this.txtIO.Text += "9";
            }
        }
        /// <summary>
        /// Handles event when btnDec is pressed
        /// </summary>
        /// <param name="sender">butten object</param>
        /// <param name="e">event type</param>
        private void btnDec_Click(object sender, EventArgs e)
        {
            // check string to see if a decimal has been entered
            int index = this.txtIO.Text.IndexOf('.');

            // if a decimal has not been entered add a decimal
            if (index == -1)
            {
                this.txtIO.Text += ".";
            }
        }
        #endregion

        /// <summary>
        /// Handles event when btnEquals is pressed
        /// </summary>
        /// <param name="sender">butten object</param>
        /// <param name="e">event type</param>
        private void btnEquals_Click(object sender, EventArgs e)
        {
            // set secondNumber to the number in the text box
            Double.TryParse(this.txtIO.Text, out this.secondNumber);

            // if this.operation equals 1, the plus operations will run
            if (this.operation == 1)
            {
                this.firstNumber += this.secondNumber;
                this.history += " + " + this.secondNumber.ToString();
            }
            // if this.operation equals 2, the subtraction operations will run
            else if (this.operation == 2)
            {
                this.firstNumber -= this.secondNumber;
                this.history += " - " + this.secondNumber.ToString();

            }
            // if this.operation equals 3, the multiplication operations will run
            else if (this.operation == 3)
            {
                this.firstNumber *= this.secondNumber;
                this.history += " x " + this.secondNumber.ToString();
            }
            // if this.operation equals 4, the division operations will run
            else if (this.operation == 4)
            {
                // if secondNumber equals 0 set firstNumber to NaN, otherwise run operation
                if (this.secondNumber == 0)
                {
                    this.history += " / " + this.secondNumber.ToString();
                    this.firstNumber = double.NaN;
                } else
                {
                    this.firstNumber /= this.secondNumber;
                    this.history += " / " + this.secondNumber.ToString();
                }
            }
            // if this.operation equals 5, the power operations will run
            else if (this.operation == 5)
            {
                this.firstNumber = Math.Pow(this.firstNumber, this.secondNumber);
                this.history += " ^ " + this.secondNumber.ToString();
            }

            // Output information on equations
            this.operation = 0;
            this.lblOutput.Text = "Output: " + this.firstNumber.ToString();
            this.history += " = " + this.firstNumber.ToString();
            // output built equation to rich text box
            this.richTxtEntries.Text += this.history + "\n";
            this.txtIO.Text = this.firstNumber.ToString();
            // clear entries
            this.firstNumber = double.NaN;
            this.secondNumber = double.NaN;
        }

        #region

        /// <summary>
        /// Handles event when btnAdd has been pressed.
        /// </summary>
        /// <param name="sender">butten object</param>
        /// <param name="e">event type</param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Double.TryParse(this.txtIO.Text, out this.secondNumber);
            // if firstNumber is NaN move second number to firstNumber
            if (Double.IsNaN(this.firstNumber))
            {
                this.firstNumber = this.secondNumber;
                // set the first entry on history to firstNumber
                this.history = this.txtIO.Text;
            }
            // else calculate the new value using the previous operator 
            else
            {
                calculations(this.operation);
                // show new number held by firstNumber
                this.lblOutput.Text = "Output: " + this.firstNumber.ToString();
            }

            // set text bot to 0 for easier entry
            this.txtIO.Text = "0";
            // set operator to 1 for next button press
            this.operation = 1;
        }

        /// <summary>
        /// Handles event when btnSub has been pressed.
        /// </summary>
        /// <param name="sender">butten object</param>
        /// <param name="e">event type</param>
        private void btnSub_Click(object sender, EventArgs e)
        {
            Double.TryParse(this.txtIO.Text, out this.secondNumber);
            // if firstNumber is NaN move second number to firstNumber
            if (Double.IsNaN(this.firstNumber))
            {
                this.firstNumber = this.secondNumber;
                // set the first entry on history to firstNumber
                this.history = this.txtIO.Text;
            }
            // else calculate the new value using the previous operator
            else
            {
                calculations(this.operation);
                // show new number held by firstNumber
                this.lblOutput.Text = "Output: " + this.firstNumber.ToString();
            }

            // set text bot to 0 for easier entry
            this.txtIO.Text = "0";
            // set operator to 2 for next button press
            this.operation = 2;
        }

        /// <summary>
        /// Handles event when btnMult has been pressed.
        /// </summary>
        /// <param name="sender">butten object</param>
        /// <param name="e">event type</param>
        private void btnMult_Click(object sender, EventArgs e)
        {
            Double.TryParse(this.txtIO.Text, out this.secondNumber);
            // if firstNumber is NaN move second number to firstNumber
            if (Double.IsNaN(this.firstNumber))
            {
                this.firstNumber = this.secondNumber;
                // set the first entry on history to firstNumber
                this.history = this.txtIO.Text;
            }
            // else calculate the new value using the previous operator
            else
            {
                calculations(this.operation);
                // show new number held by firstNumber
                this.lblOutput.Text = "Output: " + this.firstNumber.ToString();
            }

            // set text bot to 0 for easier entry
            this.txtIO.Text = "0";
            // set operator to 3 for next button press
            this.operation = 3;
        }

        /// <summary>
        /// Handles event when btnDiv has been pressed.
        /// </summary>
        /// <param name="sender">butten object</param>
        /// <param name="e">event type</param>
        private void btnDiv_Click(object sender, EventArgs e)
        {
            Double.TryParse(this.txtIO.Text, out this.secondNumber);
            // if firstNumber is NaN move second number to firstNumber
            if (Double.IsNaN(this.firstNumber))
            {
                this.firstNumber = this.secondNumber;
                // set the first entry on history to firstNumber
                this.history = this.txtIO.Text;
            }
            // else calculate the new value using the previous operator
            else
            {
                calculations(this.operation);
                // show new number held by firstNumber
                this.lblOutput.Text = "Output: " + this.firstNumber.ToString();
            }

            // set text bot to 0 for easier entry
            this.txtIO.Text = "0";
            // set operator to 4 for next button press
            this.operation = 4;
        }

        /// <summary>
        /// Handles event when btnPow has been pressed.
        /// </summary>
        /// <param name="sender">butten object</param>
        /// <param name="e">event type</param>
        private void btnPow_Click(object sender, EventArgs e)
        {
            Double.TryParse(this.txtIO.Text, out this.secondNumber);
            // if firstNumber is NaN move second number to firstNumber
            if (Double.IsNaN(this.firstNumber))
            {
                this.firstNumber = this.secondNumber;
                // set the first entry on history to firstNumber
                this.history = this.txtIO.Text;
            }
            // else calculate the new value using the previous operator
            else
            {
                calculations(this.operation);
                // show new number held by firstNumber
                this.lblOutput.Text = "Output: " + this.firstNumber.ToString();
            }

            // set text bot to 0 for easier entry
            this.txtIO.Text = "0";
            // set operator to 5 for next button press
            this.operation = 5;
        }

        /// <summary>
        /// Handles event when btnSign has been pressed.
        /// </summary>
        /// <param name="sender">butten object</param>
        /// <param name="e">event type</param>
        private void btnSign_Click(object sender, EventArgs e)
        {
            double convertValue;
            Double.TryParse(this.txtIO.Text, out convertValue);
            // multiply current number in text box by -1 
            convertValue = convertValue * -1;
            this.txtIO.Text = convertValue.ToString();
            this.lblOutput.Text = "Output: " + this.firstNumber.ToString();
        }

        /// <summary>
        /// Handles event when btnSqrt has been pressed.
        /// </summary>
        /// <param name="sender">butten object</param>
        /// <param name="e">event type</param>
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            btnEquals_Click(btnEquals, new EventArgs());
            Double.TryParse(this.txtIO.Text, out this.firstNumber);
            // if number is not negative take the square root to the number
            if (this.firstNumber >= 0) {
                this.history = " ==> Sqrt(" + this.firstNumber.ToString() + ")";
                this.firstNumber = Math.Sqrt(this.firstNumber);
            }

            this.txtIO.Text = this.firstNumber.ToString();
            this.lblOutput.Text = "Output: " + this.firstNumber.ToString();
        }

        /// <summary>
        /// Handles event when btnSquared has been pressed.
        /// </summary>
        /// <param name="sender">butten object</param>
        /// <param name="e">event type</param>
        private void btnSquared_Click(object sender, EventArgs e)
        {
            btnEquals_Click(btnEquals, new EventArgs());
            Double.TryParse(this.txtIO.Text, out this.firstNumber);
            this.history = " ==> " + this.firstNumber.ToString() + " ^ 2 ";
            this.firstNumber = Math.Pow(this.firstNumber, 2);
            this.txtIO.Text = this.firstNumber.ToString();
            this.lblOutput.Text = "Output: " + this.firstNumber.ToString();
        }

        /// <summary>
        /// Handles event when btnFrac has been pressed.
        /// </summary>
        /// <param name="sender">butten object</param>
        /// <param name="e">event type</param>
        private void btnFrac_Click(object sender, EventArgs e)
        {
            btnEquals_Click(btnEquals, new EventArgs());
            Double.TryParse(this.txtIO.Text, out this.firstNumber);
            this.history = " ==> " + this.firstNumber.ToString() + " ^ -1 ";
            if (this.firstNumber != 0)
            {
                this.firstNumber = 1 / this.firstNumber;
            }

            this.txtIO.Text = this.firstNumber.ToString();
            this.lblOutput.Text = "Output: " + this.firstNumber.ToString();
        }

        #endregion

        #region

        /// <summary>
        /// Handles event when btnClear has been pressed.
        /// </summary>
        /// <param name="sender">butten object</param>
        /// <param name="e">event type</param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            // reset all variables
            this.firstNumber = double.NaN;
            this.secondNumber = double.NaN;
            this.txtIO.Text = "0";
            this.lblOutput.Text = "Output: ";
        }

        /// <summary>
        /// Handles event when btnClrEntry has been pressed.
        /// </summary>
        /// <param name="sender">butten object</param>
        /// <param name="e">event type</param>
        private void btnClrEntry_Click(object sender, EventArgs e)
        {
            // clear text box
            this.txtIO.Text = "0";
        }

        /// <summary>
        /// Handles event when btnDel has been pressed.
        /// </summary>
        /// <param name="sender">butten object</param>
        /// <param name="e">event type</param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            double errorCheck;
            string replaceTxtIO;
            Double.TryParse(this.txtIO.Text, out errorCheck);

            // if a number is a single digit set to 0
            if (errorCheck < 10 && errorCheck > -10)
            {
                replaceTxtIO = "0";
            } 
            // else delete last number added
            else 
            {
                // copy everything but last character
                replaceTxtIO = this.txtIO.Text.Remove(this.txtIO.Text.Length - 1, 1);
            }
            // set text box to new value
            this.txtIO.Text = replaceTxtIO;
        }

        #endregion

    }
}
