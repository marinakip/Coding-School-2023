using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class ActionResolver {
        // Properties
        public MessageLogger Logger { get; set; }

        // Constructor
        
        public ActionResolver(MessageLogger logger) {
            Logger = logger;    
        }

        // Methods
        public ActionResponse Execute(ActionRequest request) {

            ActionResponse response = new ActionResponse();
            response.ResponseID = Guid.NewGuid();
            response.RequestID = request.RequestID;
            

            Log("EXECUTION START");


            try {
                switch (request.Action) {
                    case ActionEnum.Convert:
                        Log("CONVERT");
                        response.Output = ConvertDecimalToBinary(request.Input);
                        break;
                    case ActionEnum.Uppercase:
                        Log("UPPERCASE");
                        response.Output = ConvertToUppercase(request.Input);
                        //ToUppercase();
                        break;
                    case ActionEnum.Reverse:
                        Log("REVERSE");
                        // Reverse();
                        break;
                    default:
                        Log("ERROR");
                        // ERROR MESSAGE
                        break;
                }
            } catch (Exception exception) {
                Log(exception.Message);
                throw;
            } finally {
                Log("EXECUTION END");
            }

            return response;
            //return null;
        }

        private static void Log(String text) {
            Console.WriteLine("----------");
            Console.WriteLine(text);
        }
        public string ConvertDecimalToBinary(string input) {
            //if (IsDecimalNumber(input)) {

            //}

            //StringConverter converter = new StringConverter();
            //converter.Text = input;

            return string.Empty;
        }

        public string ConvertToUppercase(string input) {
            // “Uppercase” you must check if the Input is a string and has more than
            // one words(separated by a space), then find the longest word in the
            // Input string and convert it to uppercase.
            


            return input.ToUpper();
        }

        //public string Reverse(string input) {
        //    // “Reverse” you must check if the Input is a string and reverse it.

        //    return string.Empty;

        //}

    }
}
