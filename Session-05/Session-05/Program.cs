using Session_05;
using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.Clear();
        int[] exercises = { 1, 2, 3, 4, 5 };
        int sessionNumber = 5;
        Console.WriteLine($"SESSION-{sessionNumber:00} EXERCISES STARTING.... {Environment.NewLine}");


        //// Exercise 1: Write a C# program that reverses a given string (your name).

        //Console.WriteLine($"EXERCISE {exercises[0]} {Environment.NewLine}");
        //Console.Write($"Please insert your name to show it reversed: ");
        //string name = Console.ReadLine();               //TODO: Check if it is a string, should not take numbers
        //StringReverse reversedName = new StringReverse(name);
        //reversedName.PrintReverseString();

        // Exercise 2: Write a C# program that asks the user for an integer (n) and gives them
        // the possibility to choose between computing the sum and computing the product of 1,…,n.

        Console.Clear(); //HACK: To clear console cache because it keeps showing previous results, no errors and build is successful
        Console.WriteLine($"EXERCISE {exercises[1]} {Environment.NewLine}");
        Console.WriteLine($"What do you want to calculate? ");
        Console.Write("1. Sum \t");
        Console.Write($"2. Product {Environment.NewLine}");
        string selection = Console.ReadLine();    //TODO: Check if it is an integer
        int selectionNumber = Convert.ToInt32(selection);    
        if(selectionNumber == 1){
            Console.WriteLine("Please insert n value to calculate the Sum of 1,...,n :");
            string number = Console.ReadLine();    //TODO: Check if it is an integer
            int n = Convert.ToInt32(number);
            Sum sum = new Sum();
            int result = sum.CalculateSum(n);
            Console.WriteLine($"The sum of {n} numbers is: {result}");
        }
        else{
            //Product product = new Product();
            //product.calculateProduct(n);   
        }             



        //Console.WriteLine();

        Console.ReadLine();
       
    }
}