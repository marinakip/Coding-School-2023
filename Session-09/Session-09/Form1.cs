namespace Session_09 {
    public partial class Form1 : Form {

        #region Properties
        private decimal? _valueLeft = null;
        private decimal? _valueRight = null;
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

        private void button1_Click(object sender, EventArgs e) {

        }

        private void button13_Click(object sender, EventArgs e) {

        }

        private void buttonEqual_Click(object sender, EventArgs e) {
            ctrlDisplay.Text += " = ";

            switch (_calcOperation) {
                case CalcOperation.Addition:

                    Addition addition = new Addition();
                    _result = addition.Do(_value1, _value2);

                    break;

                default:
                    break;
            }

            ctrlDisplay.Text += _result;
        }
        private void Form1_Load(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void button18_Click(object sender, EventArgs e) {

        }
    }



}