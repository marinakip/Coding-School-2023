using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class ActionResponse : ActionEntity{
        // Properties
        public Guid ResponseID { get; set; }
        public string? Output { get; set; }

        // Constructors
        public ActionResponse() : base() {
            //ResponseID = Guid.NewGuid();
            Output = string.Empty;
        }
    }
}
