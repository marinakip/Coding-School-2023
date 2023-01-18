using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class StringConverter : StringHandler {
        //public string? Text { get; set; }

        public StringConverter(string text) : base(text) {    
        }

        public override string HandleString() {
            string conversionResult = ConvertToBinary();
            return conversionResult;
        }

        private string ConvertToBinary() {
            try {
                if (IsDecimal()) {
                  

                    return string.Empty;

                } else {
                    throw new Exception("Number is not a decimal");
                }

            } catch (Exception exception) {
                Console.WriteLine(exception.ToString());
                throw;
            } 

        }

        private bool IsDecimal() {
            throw new NotImplementedException();
        }
    }
}
