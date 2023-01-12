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

        // It calculates the operation 14 + ((-3 × 6) / 7)
        public double calculateThirdOperation()
        {
            int firstNumber = 14;
            int secondNumber = -3;
            int thirdNumber = 6;
            int fourthNumber = 7;
            double result = firstNumber + ((secondNumber * thirdNumber) / fourthNumber);
            return result;
        }

        // It calculates the operation 2 + ((13 / 6) × 6) + √7
        public double calculateFourthOperation()
        {
            int firstNumber = 2;
            int secondNumber = 13;
            int thirdNumber = 6;
            int fourthNumber = 6;            
            double fifthNumber = Math.Sqrt(7);
            double result = firstNumber + ((secondNumber / thirdNumber) * fourthNumber) + fifthNumber;
            return result;
        }

        // It calculates the operation ( 6 ^ 4 + 5 ^ 7) / (9 Modulo 4)
        public double calculateFifthOperation()
        {
            int firstNumber = 6;
            int secondNumber = 4;
            int thirdNumber = 5;
            int fourthNumber = 7;
            int fifthNumber = 9;
            int sixthNumber = 4;
            
            double firstPow = Math.Pow(firstNumber, secondNumber);
            double secondPow = Math.Pow(thirdNumber, fourthNumber);
            double result = (firstPow + secondPow) / (fifthNumber % sixthNumber);
            return result;
        }

    }
}