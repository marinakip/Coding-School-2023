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


/*Basic Algorithm 
 * 
 * The whole idea is that the MessageLogger should keep the transactions, so:
 *      - The user has selected one of the available options (e.g Convert) (first choice)
 *      - Validations (Maybe MessageLogger should also be used in validation in Exceptions)
 *      - Action Request is created with id, Action.Convert as Action and Input "convert" or "1"
 *      - Message is created with id, timestamp and string "corvert" or "1"
 *      - Message is added to the array Messages in the MessageLogger in a null slot in our case Messages[0]
 *      - User gives input
 *      - Validations (Maybe MessageLogger should also be used in validation in Exceptions)
 *      - Message is created with id, timestamp and string userInput and added to the next slot in Messages array in the MessagesLogger Messages[1]
 *      - Action Resolver is created and MessageLogger is passed to the ActionResolver 
 *      - Action Resolver takes the Action Request and  executes the appropriate fuction, in our case Convert()
 *      - If Convert() succeeds, Message is created with id, timestamp and string the converted result
 *      - If Convert() has an Exception a Message is created with id, timestamp and string the Exception message
 *      - ActionResponse is created with requestID, responseID and String the result (either converted number to string or exception)
 * 
 */
internal class Program {
    private static void Main(string[] args) {

        //Maybe use MessageLogger for ConsolePrompts (writelines) too???
        ConsolePrompt consolePrompt = new ConsolePrompt();
        consolePrompt.DisplayUserOptions();

        // should create Message in the MessageLogger for the first choice too, this is the first input
        int userSelection = consolePrompt.GetUserSelection();  // 1 ConvertToBinary, 2 Uppercase , 3 Reverse

        //Console.WriteLine("The input is " + userSelection); //for testing

        consolePrompt.PromptUserForInput(userSelection); 

        string? inputForExecution = Console.ReadLine(); // needs again extra steps for validation

        // This implementation doesn't keep log messages for the choice input
        switch (userSelection) {
            case 1:
                ActionEnum action = ActionEnum.Convert;
                Guid requestID = Guid.NewGuid();
                ActionRequest request = new ActionRequest(requestID, inputForExecution, action);
                Message message = new Message(Guid.NewGuid(), DateTime.Now, inputForExecution);
                MessageLogger messageLogger= new MessageLogger();
                messageLogger.Write(message);
                //messageLogger.ReadAll(); // for testing
                Guid responseID = Guid.NewGuid();
                ActionResponse response = new ActionResponse(); 
                break; 
            case 2: 
                break; 
            case 3:  
            default:
                break;
        }
        

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