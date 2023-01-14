using Session_05;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.Clear();
        int[] exercises = { 1, 2, 3, 4, 5 };
        int sessionNumber = 5;
        Console.WriteLine($"SESSION-{sessionNumber:00} EXERCISES STARTING.... {Environment.NewLine}");


        // Exercise 1: Write a C# program that reverses a given string (your name).

        Console.WriteLine($"EXERCISE {exercises[0]} {Environment.NewLine}");
        Console.Write($"Please insert your name to show it reversed: ");
        string name = Console.ReadLine();               //TODO: Check if it is a string, should not take numbers
        StringReverse reversedName = new StringReverse(name);
        reversedName.PrintReverseString();

        // Exercise 2: Write a C# program that asks the user for an integer (n) and gives them
        // the possibility to choose between computing the sum and computing the product of 1,…,n.

        Console.WriteLine($"EXERCISE {exercises[1]} {Environment.NewLine}");
        Console.WriteLine($"What do you want to calculate? ");
        Console.Write("1. Sum \t");
        Console.Write($"2. Product {Environment.NewLine}");
        string number = Console.ReadLine();    //TODO: Check if it is an integer
        if(number == 2){

        }
        else{

        }             



        //Console.WriteLine();

        Console.ReadLine();
       
    }
}