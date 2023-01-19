using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOperationsLibrary {
    internal interface IOperations {
        public decimal Add(decimal valueLeft, decimal valueRight);
        public decimal Subtrack(decimal valueLeft, decimal valueRight);
        public decimal Multiply(decimal valueLeft, decimal valueRight);

        // Division and Modulo methods are declared in IDivisionOperations Interface

        public decimal RaiseToPower(decimal valueLeft, decimal valueRight);
        public decimal CalculateSquareRoot(decimal value);

    }
}
