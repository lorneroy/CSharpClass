using System;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorOperations;
using FileAccess;


namespace CSHP811A_Assignment_03
{
    public partial class FormCalculator : Form
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

        #region properties

        public string DataFilePath
        {
            get { return System.Configuration.ConfigurationManager.AppSettings["DataFilePath"];}
            set 
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["DataFilePath"].Value = value;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

        #endregion

        #region constructor

        public FormCalculator()
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

        /// <summary>
        /// This is the event for any numeric button, including decimal point
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// this is the event for all operator buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void buttonChangeFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dataFileDialog = new OpenFileDialog();

            dataFileDialog.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            dataFileDialog.FilterIndex = 1;
            dataFileDialog.Multiselect = false;

            // Call the ShowDialog method to show the dialog box.
            DialogResult result = dataFileDialog.ShowDialog();

            // Process input if the user clicked OK.
            if (result == DialogResult.OK)
            {
                DataFilePath = dataFileDialog.FileName;

                textBoxFilePath.Text = DataFilePath;
            }
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxFilePath.Text = DataFilePath;
        }

        /// <summary>
        /// this event saves the value on the screen to a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            FileAccess.FileAccess fa = new FileAccess.FileAccess(DataFilePath);
            fa.SaveToFile(textBoxCalcDisplay.Text);
        }

        #endregion

    }
}
