using System;

namespace Session_04
{
    public class MathematicalOperation
    {
        // It calculates the operation −1 + (5 × 6)
        public int calculateFirstOperation()
        { 
            int firstNumber = -1;
            int secondNumber = 5;
            int thirdNumber = 6;       
            int result = firstNumber + (secondNumber * thirdNumber);
            return result;
        }

        // It calculates the operation 38 + 5 𝑚𝑜𝑑 7
        public int calculateSecondOperation()
        {
            int firstNumber = 38;
            int secondNumber = 5;
            int thirdNumber = 7;
            int result = firstNumber + (secondNumber % thirdNumber);
            return result;
        }

    }
}