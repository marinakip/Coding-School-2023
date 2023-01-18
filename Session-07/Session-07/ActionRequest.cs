using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    
    public class ActionRequest : ActionEntity {

        // Properties
        public string? Input { get; set; }
        public ActionEnum Action { get; set; }

        // Constructor
        public ActionRequest() : base() {
        }

        public ActionRequest(string input, ActionEnum action) : base() {
            //RequestID = Guid.NewGuid();
            Input = input;  
            Action = action;    

        }

    }
}
