namespace Session_07 {
    public class MessageLogger {

        // Properties
        public Message[] Messages { get; set; } 

        // Constructors
        //public MessageLogger() { } // Unessesary 
        public MessageLogger(Message[] messages) {
            Messages = messages;    
        }

        // Methods
        public void ReadAll() { //should return Message[]

        }
        public void Clear() {

        }
        public void Write(Message message) { }
    }
}