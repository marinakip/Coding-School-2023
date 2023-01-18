using Session_07;
using System.ComponentModel.DataAnnotations;
/// <summary>
/// Message Logger implementation to keep track of different user transactions:
/// The user has the options to:
/// - Convert a decimal number to binary
/// - Uppercase the longest word in the input string
/// - Reverse the input string
/// Everytime the user does something, it should log the ID, TimeStamp and the Message for the action
/// Use case: The user is asked to choose between convert, uppercase or reverse. If the selection is valid 
/// the logger displays a message in the form (ID, timestamp, Corvert/Uppercase/Reverse) when the request started
/// and another message when the resolver executed the action (ID, timestamp, sucessful message / error)
///
/// </summary>

internal class Program {
    private static void Main(string[] args) {

        
        ConsolePrompt consolePrompt = new ConsolePrompt();
        consolePrompt.DisplayUserOptions();
        int userSelection = consolePrompt.GetUserSelection();
        //Console.WriteLine("The input is " + userSelection); //for testing

        //ActionRequest request = new ActionRequest();
        //ActionResponse response = new ActionResponse();

        //ActionResolver resolver = new ActionResolver();

        //response = resolver.Execute(request);

        //MessageLogger messageLogger = new MessageLogger();

        //try {
        //    messageLogger.ReadAll();
        //} catch (Exception exception) {
        //    Console.WriteLine(exception.ToString());
        //    throw;
        //}


        Console.ReadLine();




    }
}