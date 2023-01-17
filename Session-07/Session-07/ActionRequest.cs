using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    
    public class ActionRequest {

        // Properties
        public Guid RequestID { get; set; }
        public string? Input { get; set; }
        public ActionEnum Action { get; set; }

        // Constructors


        public ActionRequest() {
            RequestID = Guid.NewGuid(); 

        }

        public ActionRequest(Guid requestID) {
            RequestID = requestID;
        }

        public ActionRequest(Guid requestID, string input) {
            RequestID = requestID;
            Input = input;
        }

        public ActionRequest(Guid requestID, string input, ActionEnum enumerator) {
            RequestID = Guid.NewGuid(); ;
            Input = input;
            Action = enumerator;    
        }
    }
}
