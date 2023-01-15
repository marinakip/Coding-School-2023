using Session_05;
using System;
using System.ComponentModel;
using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {

        
        int[] exercises = { 1, 2, 3, 4, 5 };
        int sessionNumber = 5;
        Console.WriteLine($"SESSION-{sessionNumber:00} EXERCISES STARTING.... {Environment.NewLine}");

        
        
        // Exercise 1: Write a C# program that reverses a given string (your name).

        Console.WriteLine($"EXERCISE {exercises[0]} {Environment.NewLine}");
        Console.Write($"Please insert your name to show it reversed: ");
       
        string name = Console.ReadLine();
        //TODO: Do Regex input validation for name input
        while (name != null){
            if (int.TryParse(name, out int numericValue))
            {
                Console.WriteLine("The input is invalid. You entered a number. Try again.");
                name = Console.ReadLine();

            }
            else
            {
                StringReverse reversedName = new StringReverse(name);
                reversedName.PrintReverseString();
                break;
            }
        }
      

        // Exercise 2: Write a C# program that asks the user for an integer (n) and gives them
        // the possibility to choose between computing the sum and computing the product of 1,…,n.

        
        Console.WriteLine($"EXERCISE {exercises[1]} {Environment.NewLine}");
        Console.WriteLine($"What do you want to calculate? ");
        Console.Write("1. Sum \t");                             //TODO: Fix output in one line
        Console.Write($"2. Product {Environment.NewLine}");
        string selection = Console.ReadLine();    //TODO: Check if it is an integer
        int selectionNumber = Convert.ToInt32(selection);

        Console.WriteLine("Please insert n value to calculate the Sum of 1,...,n :");
        string number = Console.ReadLine();    //TODO: Check if it is an integer and not negative
        int n = Convert.ToInt32(number);
        if (selectionNumber == 1){
            Sum sum = new Sum();
            int resultSum = sum.CalculateSum(n);
            Console.WriteLine($"The sum of {n} numbers is: {resultSum}");
        }
        else{
            Product product = new Product();
            int resultProduct = product.CalculateProduct(n);
            Console.WriteLine($"The product of {n} numbers is: {resultProduct}");
        }


        // Exercise 3: Write a C# program that asks the user for an integer (n) and finds all the prime numbers from 1 to n.

        Console.WriteLine($"{Environment.NewLine}EXERCISE {exercises[2]} {Environment.NewLine}");
        Console.Write("Please insert n value to find all the prime numbers from 1 to n:");
        string input = Console.ReadLine();    //TODO: Check if it is an integer and not negative
        int primesUpperBound = Convert.ToInt32(input);       //TODO: REFACTOR EXTRACT METHOD FOR INPUT and if string is number and not negative
        Console.WriteLine($"The primes from 1 to {primesUpperBound} are:");
       
        Prime primeNumber = new Prime();
        primeNumber.CalculateAllPrimes(primesUpperBound);



        // Exercise 4: Write a C# program to multiply all values from Array1 with all values
        // from Array2 and display the results in a new Array.
        //  • Array1: [2, 4, 9, 12]
        //  • Array2: [1, 3, 7, 10]
        Console.WriteLine($"{Environment.NewLine}");
        Console.WriteLine($"{Environment.NewLine}EXERCISE {exercises[3]} {Environment.NewLine}");
        CartesianProduct cartesianProduct = new CartesianProduct();
        Console.WriteLine($"The arrays for the cartesian product are: ");
        cartesianProduct.printArray1();
        Console.WriteLine();
        cartesianProduct.printArray2();
     
        Console.WriteLine($"{Environment.NewLine}The cartesian product of the array is: ");
        cartesianProduct.printCartesianProduct();



        // Exercise 5: Write a C# program to sort the given array of integers from the lowest
        //to the highest number.
        //• Array: [ 0, -2, 1, 20, -31, 50 , -4, 17, 89, 100 ]

        Console.WriteLine($"{Environment.NewLine}");
        Console.WriteLine($"{Environment.NewLine}EXERCISE {exercises[4]} {Environment.NewLine}");
        Sorting sorting = new Sorting();
        Console.WriteLine("The array to be sorted is: ");
        sorting.PrintArray1();
        Console.WriteLine($"{Environment.NewLine}The sorted array is: ");
        sorting.PrintSortedArray();


        Console.ReadLine();
       
    }
}