using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOperationsLibrary {
    internal class DivisionOperation : IDivisionOperations {
        public DivisionOperation() { }
        public decimal Divide(decimal valueLeft, decimal valueRight) {
            decimal result = valueLeft / valueRight;
            return result;

        }
        public decimal CalculateModulo(decimal valueLeft, decimal valueRight) {
            decimal result = valueLeft % valueRight;
            return result;
        }
    }
}
