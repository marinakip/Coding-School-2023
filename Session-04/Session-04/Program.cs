﻿using Session_04;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        // Exercise 1: Write a C# program to print Hello and your name in the same line.
        HelloName greeting = new HelloName();
        greeting.PrintHelloName();

        // Exercise 2: Write a C# program to print the sum of two numbers and the division of those two numbers
        SumAndDivision calculation= new SumAndDivision();
        calculation.printNumbers();
        Console.WriteLine("The sum of the numbers is: " + calculation.CalculateSum());
        Console.WriteLine("The division of the numbers is: " + calculation.CalculateDivision());

        /* Exercise 3: Write a C# program to print the result of the specified operations
        *   • −1 + (5 × 6)
        *   • 38 + 5 𝑚𝑜𝑑 7
        *   • 14 + ((-3 × 6) / 7)
        *   • 2 + ((13 / 6) × 6) + √7
        *   •( 6 ^ 4 + 5 ^ 7) / 9 𝑚𝑜𝑑 4
        */

        MathematicalOperation operation = new MathematicalOperation();
        Console.WriteLine("The first operation is:  −1 + (5 × 6)");   
        Console.WriteLine("The result is: " + operation.calculateFirstOperation());

        Console.WriteLine("The second operation is:  38 + 5 𝑚𝑜𝑑 7");
        Console.WriteLine("The result is: " + operation.calculateSecondOperation());




        Console.ReadLine();

    }
}