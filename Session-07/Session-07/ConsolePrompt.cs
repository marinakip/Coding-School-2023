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

    public int GetUserSelection() {
        int inputNumber = 0;
        try {
            string? input = Console.ReadLine();
            while (input != null) {
                int selectionNumber;
                bool result = int.TryParse(input,  out selectionNumber);
                if (result){
                    inputNumber = selectionNumber;
                    return inputNumber;
                } else {
                    Console.WriteLine("Your input is invalid. Please try again.");
                }
                input = Console.ReadLine();
            }
        } catch (Exception exception) {
            Console.WriteLine(exception.ToString());
            throw;
        }
        return 0; //is not a valid choice , only 1,2,3 is valid choices.
        
    }

}