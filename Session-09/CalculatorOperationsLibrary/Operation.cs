namespace CalculatorOperationsLibrary {
    public class Operation {
        public Operation() { }
        public decimal Add(decimal valueLeft, decimal valueRight) {
            decimal result = valueLeft + valueRight;
            return result;
        }
        public decimal Subtrack(decimal valueLeft, decimal valueRight) {
            decimal result = valueLeft - valueRight;
            return result;
        }
        public decimal Multiply(decimal valueLeft, decimal valueRight) {
            decimal result = valueLeft * valueRight;
            return result;
        }
       
        public decimal RaiseToPower(decimal valueLeft, decimal valueRight) {
            double result = Math.Pow((double) valueLeft, (double) valueRight);
            return (decimal) result;
        }
        public decimal CalculateSquareRoot(decimal value) {
            double result = Math.Sqrt((double) value);
            return (decimal) result;
        }


    }
}