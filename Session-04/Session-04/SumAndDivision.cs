using System;

namespace Session_04
{
    public class SumAndDivision
    {
        double firstNumber = 8.2;
        double secondNumber = 9.5;

        public void printNumbers()
        {
            Console.WriteLine("The numbers are: " + firstNumber + "  " + secondNumber);        
        }

        public double CalculateSum() 
        {        
            double sum = firstNumber + secondNumber; 
            return sum; 
        }

        public double CalculateDivision() 
        {
            double division =  firstNumber/secondNumber;   
            return division;
        }
    }
}