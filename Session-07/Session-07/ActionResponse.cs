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
        public ActionResponse() {
            RequestID = Guid.NewGuid();
            ResponseID = Guid.NewGuid();
            Output = string.Empty;
        }
    }
}
