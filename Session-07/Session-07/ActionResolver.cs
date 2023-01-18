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
                    
                    //Convert();
                    break;
                case ActionEnum.Uppercase:
                    // ToUpper();
                    break;
                case ActionEnum.Reverse:
                    // Reverse();
                    break;
                default:
                    break;
            }


            return null;
        }
    }
}
