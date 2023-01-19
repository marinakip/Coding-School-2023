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

        enum CalcOperation {
            Addition //,
            //Substraction,
            //Multiplication,
            //Division,
            //RaiseToPower,
            //SquareRoot
        }

        private void button1_Click(object sender, EventArgs e) {  //1
            ClearAllValues();

            textBox1.Text += " 1 ";

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

            assignValue(1);

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

        private void button14_Click(object sender, EventArgs e) { //=
            ClearAllValues();

            textBox1.Text += " = ";

            assignValue(1);

        }

        private void button4_Click(object sender, EventArgs e) { //+
            ClearAllValues();

            textBox1.Text += " + ";

            assignValue(1);

        }

        private void button8_Click(object sender, EventArgs e) { //-

        }

        private void button12_Click(object sender, EventArgs e) { // multiply

        }

        private void button15_Click(object sender, EventArgs e) { // divide

        }

        private void button16_Click(object sender, EventArgs e) { // square root

        }

        private void button17_Click(object sender, EventArgs e) { // clear

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e) { // calculator display

        }

        private void button13_Click(object sender, EventArgs e) { 

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void button18_Click(object sender, EventArgs e) {

        }

        private void buttonEqual_Click(object sender, EventArgs e) {
           // ctrlDisplay.Text += " = ";

            //switch (_calcOperation) {
            //    case CalcOperation.Addition:

            //        Addition addition = new Addition();
            //        _result = addition.Do(_value1, _value2);

            //        break;

            //    default:
            //        break;
            //}

            //ctrlDisplay.Text += _result;
        }

       
    }



}