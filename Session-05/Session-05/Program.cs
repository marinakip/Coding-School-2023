using Session_05;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        int[] exercises = { 1, 2, 3, 4, 5 };
        int sessionNumber = 5;
        Console.WriteLine($"SESSION-{sessionNumber:00} EXERCISES STARTING.... {Environment.NewLine}");

        Console.WriteLine($"EXERCISE {exercises[0]} {Environment.NewLine}");
        Console.Write($"Please give me your name to show it reversed: ");
        string name = Console.ReadLine();
        StringReverse reversedName = new StringReverse(name);
        reversedName.PrintReverseString();

        Console.ReadLine();
    }
}