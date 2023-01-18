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
            switch (request.Action) {
                case ActionEnum.Convert:
                    Log("CONVERT");
                    //Convert();
                    break;
                case ActionEnum.Uppercase:
                    Log("UPPERCASE");
                    // ToUpper();
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


            return null;
        }

        private static void Log(String text) {
            Console.WriteLine("----------");
            Console.WriteLine(text);
        }
    }
}
