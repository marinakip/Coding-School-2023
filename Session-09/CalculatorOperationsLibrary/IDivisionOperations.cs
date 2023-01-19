using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOperationsLibrary {
    internal interface IDivisionOperations {
        public decimal Divide(decimal valueLeft, decimal valueRight);
        public decimal CalculateModulo(decimal valueLeft, decimal valueRight);
    }
}
