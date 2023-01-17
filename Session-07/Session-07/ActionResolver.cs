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


            return null;
        }
    }
}
