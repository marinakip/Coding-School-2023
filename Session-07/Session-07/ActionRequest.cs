﻿using System;
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

        // Constructor
        public ActionRequest() {
            RequestID = Guid.NewGuid();
        }

    }
}
