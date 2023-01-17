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

        // Unnessary constructors
        //public ActionRequest() { }
        //
        //public ActionRequest(Guid requestID) { 
        //    RequestID = requestID;
        //}

        //public ActionRequest(Guid requestID, string input) {
        //    RequestID = requestID;
        //    Input = input;
        //}

        // Only this construtor is actually needed, the others don't make sense
        public ActionRequest(Guid requestID, string input, ActionEnum enumerator) {
            RequestID = requestID;
            Input = input;
            Action = enumerator;    
        }
    }
}
