using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class ActionResponse {

        // Properties
        public Guid RequestID { get; set; }
        public Guid ResponseID { get; set; }
        public string? Output { get; set; }

        // Constructors
        //public ActionResponse() { }  // Unnessesary
        public ActionResponse(Guid requestID, Guid responseID) {
            RequestID = requestID;
            ResponseID = responseID; 
        }
        public ActionResponse(Guid requestID, Guid responseID, string? output) {
            RequestID = requestID;
            ResponseID = responseID;
            Output = output;
        }   
    }
}
