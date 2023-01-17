using System.Text;

internal class ConsolePrompt {
    public ConsolePrompt() {
    }

    public void DisplayUserOptions() {
        string[] options = {
            "1. Convert a decimal number to binary",
            "2. Convert to Uppercase the longest word in your input",
            "3. Reverse a word"
        };
        StringBuilder stringBuilder = new StringBuilder("Please select the number from the options:");
        stringBuilder.AppendLine();
        for(int i=0; i< options.Length; i++) {
            stringBuilder.AppendLine($"{options[i]}");
        }
        Console.WriteLine(stringBuilder);
    }

    public void GetUserSelection() {
        
    }
}