
using CalculatorOperationsLibrary;
using System;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;

namespace Session_09 {
    public partial class Form1 : Form {

        // textBox1 is calculator display. CAN'T BE RENAMED because the designer breaks
        // Works only for simple operations, doesn't show result correctly when it has more than one digits
        
        
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

        #region Methods

        private void ClearAllValues() {
            if (ExistCalculationResult()) {  //TODO: change name - bad name
                textBox1.Text = string.Empty;    
                _valueLeft = null;
                _valueRight = null;
                _calculationResult = null;
            }
        }

        private void DispatchButtonNumberToDisplay(string stringNumber) {
            ClearAllValues();
            int number = ConvertStringNumberToInteger(stringNumber);
            AssignValueToFirstNumberInDisplay(number);
        }
        private void AssignValueToFirstNumberInDisplay(int number) {
            if (IsLeftValueEmpty()) {
                _valueLeft = number;
            } else {
                _valueRight = number;
            }
        }

        private int ConvertStringNumberToInteger(string stringNumber) {
            textBox1.Text += stringNumber;
            int number = 0;
            if (Int32.TryParse(stringNumber, out number)) {
                //parsing successful
            }            
            return number;
        }

        private void AssignEnumerator(string enumeratorString) {
            textBox1.Text += enumeratorString;
            try {
                switch (enumeratorString) {
                    case "+":
                        _calcOperation = CalcOperation.Addition;
                        break;
                    case "-":
                        _calcOperation = CalcOperation.Substraction;
                        break;
                    case "*":
                        _calcOperation = CalcOperation.Multiplication;
                        break;
                    case "/":
                        _calcOperation = CalcOperation.Division;
                        break;
                    case "^":
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

        private bool ExistCalculationResult() { //TODO: change name - bad name ExistCalculationResult
            return _calculationResult != null;
        }     

        private bool IsLeftValueEmpty() {
            return _valueLeft == null;
        }

        private void AssignResult(String equalSymbol) {
            textBox1.Text += equalSymbol;
            Calculate();
            textBox1.Text += _calculationResult;
            //string result = RegexParse(textBox1.Text); // Doesn't work
            //textBox1.Text += result;
        }

        private string RegexParse(string input) {
            string pattern = @"[\d|Sqrt(?:+-\/*^)|Sqrt(?=)\d]";
            string calculationResult = "=" + _calculationResult.ToString();
            // matches input textBox1.Text e.g 22+27= and replaces it with " = calculation result"
            string result = Regex.Replace(input, pattern, calculationResult);            
            return result;
        }

        private void Calculate() {
            Operation operation = new Operation();
            try {
                switch (_calcOperation) {
                    case CalcOperation.Addition:
                        _calculationResult = operation.Add((decimal)_valueLeft, (decimal)_valueRight);
                        break;
                    case CalcOperation.Substraction:
                        _calculationResult = operation.Subtrack((decimal)_valueLeft, (decimal)_valueRight);
                        break;
                    case CalcOperation.Multiplication:
                        _calculationResult = operation.Multiply((decimal)_valueLeft, (decimal)_valueRight);
                        break;
                    case CalcOperation.Division:
                        DivisionOperation divisionOperation = new DivisionOperation();
                        _calculationResult = divisionOperation.Divide((decimal)_valueLeft, (decimal)_valueRight);
                        break;
                    case CalcOperation.RaiseToPower:
                        _calculationResult = operation.RaiseToPower((decimal)_valueLeft, (decimal)_valueRight);
                        break;
                    case CalcOperation.SquareRoot:
                        _calculationResult = operation.CalculateSquareRoot((decimal)_valueLeft);
                        break;
                    default:
                        throw new InvalidOperationException();
                }
            } catch (Exception) {
                throw new Exception("Something went wrong. Unsupported Operation.");
            }
        }

        private void Form1_Load(object sender, EventArgs e) {  //doesn't work
                                                               //TODO: Resolve expression e.g "1+2=3"
                                                               //TODO: Advanced: Resolve expression e.g "10,4+210,5 ="

            // Regex     /[\d|Sqrt(?:+-\/*^)|Sqrt(?=)\d]/gm
            // Possible Matches
            //      1+Sqrt4=
            //      1 + 1=            
            //      11111 + 563214 =
            //      Sqrt4+1=

            //TestRegex();

        }

        private static void TestRegex(string textToParse, string replacement) {
            string pattern = @"[\d|Sqrt(?:+-\/*^)|Sqrt(?=)\d]";
            string test = "1+2=3"; 
            //Match match = Regex.Match(test, pattern);
            //if (match.Success) {
            //    MessageBox.Show("Expression matches");
            //} else {
            //    MessageBox.Show("Expression not matches.");
            //}

            string[] parts = Regex.Split(test, pattern);
            MessageBox.Show("Left Value: " + parts[0]);
            MessageBox.Show("Right Value: " + parts[1]);
            MessageBox.Show("Result: " + parts[2]);
        }
        #endregion

        #region Calculator Display
        private void textBox1_TextChanged_1(object sender, EventArgs e) { }    // calculator display
        #endregion

        #region Number Buttons
        private void button1_Click(object sender, EventArgs e) {  // Calculator Button 1
            DispatchButtonNumberToDisplay("1");
        }

        private void button2_Click(object sender, EventArgs e) { // Calculator Button 2
            DispatchButtonNumberToDisplay("2");           
        }

        private void button3_Click(object sender, EventArgs e) { // Calculator Button 3
            DispatchButtonNumberToDisplay("3");
        }

        private void button5_Click(object sender, EventArgs e) { // Calculator Button 4
            DispatchButtonNumberToDisplay("4");
        }

        private void button6_Click(object sender, EventArgs e) { // Calculator Button 5
            DispatchButtonNumberToDisplay("5");
        }

        private void button7_Click(object sender, EventArgs e) { // Calculator Button 6
            DispatchButtonNumberToDisplay("6");
        }

        private void button9_Click(object sender, EventArgs e) { // Calculator Button 7
            DispatchButtonNumberToDisplay("7");
        }

        private void button10_Click(object sender, EventArgs e) { // Calculator Button 8
            DispatchButtonNumberToDisplay("8");
        }

        private void button11_Click(object sender, EventArgs e) { // Calculator Button 9
            DispatchButtonNumberToDisplay("9");
        }
        #endregion

        #region Operation Buttons
        private void button14_Click(object sender, EventArgs e) { // Calculator Button =
            AssignResult("=");
        }

        private void button4_Click(object sender, EventArgs e) { // Calculator Button +
            AssignEnumerator("+");
        }     

        private void button8_Click(object sender, EventArgs e) { // Calculator Button -
            AssignEnumerator("-");
        }

        private void button12_Click(object sender, EventArgs e) { // Calculator Button multiply 
            AssignEnumerator("*");
        }

        private void button15_Click(object sender, EventArgs e) { // Calculator Button / divide
            AssignEnumerator("/");
        }

        private void button16_Click(object sender, EventArgs e) { // Calculator Button square root
            AssignEnumerator("Sqrt");
        }
        private void button17_Click(object sender, EventArgs e) { // Calculator Button clear CE
            ClearAllValues();
        }
        #endregion
       
    }
}