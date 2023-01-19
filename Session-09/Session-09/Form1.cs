
using CalculatorOperationsLibrary;
using System;
using System.Net.Http.Headers;

namespace Session_09 {
    public partial class Form1 : Form {

        #region Properties

        private decimal? _valueLeft = null;   // valueLeft is at the left side of operation
        private decimal? _valueRight = null;  // valueRight is at the right side of operation
        private decimal? _calculationResult = null;
        private CalcOperation _calcOperation;
       

        #endregion

        #region Constructor
        public Form1() {
            InitializeComponent();
        }
        #endregion

        #region Buttons for numbers
        private void button1_Click(object sender, EventArgs e) {  //1
            ClearAllValues();
            textBox1.Text += " 1 ";   //textBox1 is calculator display
            assignValue(1);

        }

        private void ClearAllValues() {
            if (ExistCalculationResult()) {  //TODO: change name - bad name
                textBox1.Text = string.Empty;    //textBox1 is calculator display
                _valueLeft = null;
                _valueRight = null;
                _calculationResult = null;
            }
        }

        private bool ExistCalculationResult() { //TODO: change name - bad name
            return _calculationResult != null;
        }

        private void assignValue(int number) {
            if (IsLeftValueEmpty()) {
                _valueLeft = number;
            } else {
                _valueRight = number;
            }
        }

        private bool IsLeftValueEmpty() {
            return _valueLeft == null;
        }

        private void button2_Click(object sender, EventArgs e) { //2
            ClearAllValues();
            textBox1.Text += " 2 ";  
            assignValue(2);
        }

        private void button3_Click(object sender, EventArgs e) { //3

        }

        private void button5_Click(object sender, EventArgs e) { //4

        }

        private void button6_Click(object sender, EventArgs e) { //5

        }

        private void button7_Click(object sender, EventArgs e) { //6

        }

        private void button9_Click(object sender, EventArgs e) { //7

        }

        private void button10_Click(object sender, EventArgs e) { //8

        }

        private void button11_Click(object sender, EventArgs e) { //9

        }

        #endregion

        #region Operation Buttons
        private void button14_Click(object sender, EventArgs e) { //=
            textBox1.Text += " = ";     
            Operation operation = new Operation();
            switch (_calcOperation) {
                case CalcOperation.Addition:
                    //Addition addition = new Addition();
                    //_calculationResult = addition.Add((decimal)_valueLeft, (decimal)_valueRight);                    
                    _calculationResult = operation.Add((decimal)_valueLeft, (decimal)_valueRight);
                    break;
                default:
                    break;
            }

            textBox1.Text += _calculationResult;

        }

        private void assignEnumerator(string enumeratorString) {
            textBox1.Text += enumeratorString;
            try {
                switch (enumeratorString) {
                    case " + ":
                        _calcOperation = CalcOperation.Addition;
                        break;
                    case " - ":
                        _calcOperation = CalcOperation.Substraction;
                        break;
                    case " * ":
                        _calcOperation = CalcOperation.Multiplication;
                        break;
                    case " / ":
                        _calcOperation = CalcOperation.Division;
                        break;
                    case " ^ ":
                        _calcOperation = CalcOperation.RaiseToPower;
                        break;
                    case "Sqrt":
                        _calcOperation = CalcOperation.SquareRoot;
                        break;
                    default:
                        throw new Exception("The operation is not supported.");
                }
            } catch (Exception exception) {
                MessageBox.Show(exception.ToString());
            }

        }

        private void button4_Click(object sender, EventArgs e) { //+
            assignEnumerator(" + ");

        }     

        private void button8_Click(object sender, EventArgs e) { //-
            assignEnumerator(" - ");
        }

        private void button12_Click(object sender, EventArgs e) { // multiply
            assignEnumerator(" * ");

        }

        private void button15_Click(object sender, EventArgs e) { // divide
            assignEnumerator(" / ");

        }

        private void button16_Click(object sender, EventArgs e) { // square root
            assignEnumerator(" Sqrt ");

        }
        private void button17_Click(object sender, EventArgs e) { // clear
            ClearAllValues();
        }

        #endregion

        #region Calculator Display
        private void textBox1_TextChanged_1(object sender, EventArgs e) { }    // calculator display
        #endregion
    }
}