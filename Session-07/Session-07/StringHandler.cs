using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class StringHandler {
        // Properties
        public string? Text { get; set; }

        // Constructor
        public StringHandler(string? text) {
            Text = text;
        }
        
        // Methods
        public virtual string HandleString(){
            return string.Empty;

        }
    }
}
