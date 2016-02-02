/*
 * Lorne Roy
 * 0034514
 */

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CalculatorOperations;


namespace CSHP811A_Assignment_02
{
    public partial class FormSimpleCalculator : Form
    {
        #region private fields

        /// <summary>
        /// this is the first number entered for the calculation
        /// </summary>
        private decimal _number1;

        /// <summary>
        /// this is the operator selected for the calculation
        /// </summary>
        private string _operator;

        #endregion

        #region constructor

        public FormSimpleCalculator()
        {
            InitializeComponent();
        }

        #endregion

        #region methods

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// this method attempts to parse the contents of textBoxCalcDisplay to a decimal value
        /// </summary>
        /// <returns>decimal representation of the text box</returns>
        private decimal tryParseTextBox()
        {
            decimal retVal;

            if (!decimal.TryParse(textBoxCalcDisplay.Text, out retVal))
            {
                MessageBox.Show("Bad Syntax");
            }

            return retVal;

        }

        #endregion

        #region delegates

        private void numberButton_Click(object sender, EventArgs e)
        {
            //delete the content of the display if the last button pressed was "=" and more numbers are entered
            if (_operator == "=")
            {
                textBoxCalcDisplay.Text = string.Empty;
                _operator = string.Empty;
            }
            textBoxCalcDisplay.Text += (string)((Button)sender).Text;
        }

        private void operatorButton_Click(object sender, EventArgs e)
        {
            _operator = (string)((Button)sender).Text;
            _number1 = tryParseTextBox();
            textBoxCalcDisplay.Clear();
            textBoxPreviousEntry.Text = _number1 + " " + _operator;

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCalcDisplay.Clear();
            textBoxPreviousEntry.Clear();
            _operator = String.Empty;
            _number1 = 0;
        }
        
        private void buttonSign_Click(object sender, EventArgs e)
        {
            //if the display number has a minus sign remove it
            if (textBoxCalcDisplay.Text.StartsWith("-"))
            {
                textBoxCalcDisplay.Text = textBoxCalcDisplay.Text.Substring(1);
            }
            //if it doesn't, add it
            else
            {
                textBoxCalcDisplay.Text = "-" + textBoxCalcDisplay.Text;
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            try
            {

                switch (_operator)
                {
                    case "+":
                        textBoxCalcDisplay.Text = Calculation.add(_number1, tryParseTextBox()).ToString();
                        break;
                    case "-":
                        textBoxCalcDisplay.Text = Calculation.subtract(_number1, tryParseTextBox()).ToString();
                        break;
                    case "*":
                        textBoxCalcDisplay.Text = Calculation.multiply(_number1, tryParseTextBox()).ToString();
                        break;
                    case "/":
                        textBoxCalcDisplay.Text = Calculation.divide(_number1, tryParseTextBox()).ToString();
                        break;
                    default:
                        //do nothing
                        break;
                }

                _operator = "=";
                textBoxPreviousEntry.Clear();

            }
            catch (Exception)
            {

                textBoxCalcDisplay.Text = "ERROR";
            }

        }

        #endregion
    }
}
