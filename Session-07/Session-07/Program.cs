using Session_07;
using System.ComponentModel.DataAnnotations;

internal class Program {
    private static void Main(string[] args) {

        ActionRequest request = new ActionRequest() { 
            Input = "Marina",
            Action = ActionEnum.Reverse
        };
        ActionResponse response = new ActionResponse();
        MessageLogger messageLogger = new MessageLogger();

        ActionResolver resolver = new ActionResolver(messageLogger);

        try {
            response = resolver.Execute(request);
        } catch (Exception exception) {
            Console.WriteLine(exception.ToString());
            throw;
        }

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