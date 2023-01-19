using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOperationsLibrary {
    internal class Addition {

        public Addition(){}

        public decimal Add(decimal? valueLeft, decimal? valueRight) {

            decimal result = 0;

            if (valueLeft != null && valueRight != null) {
                result = valueLeft.Value + valueRight.Value;
            }

            return result;
        }

    }
}
