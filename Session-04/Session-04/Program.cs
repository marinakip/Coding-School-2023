using Session_04;

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

        Console.ReadLine();

    }
}