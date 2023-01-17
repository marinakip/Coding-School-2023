namespace Session_07 {
    public class MessageLogger {

        // Properties
        public Message[] Messages { get; set; } 

        // Constructors
        public MessageLogger() {
            Messages = new Message[1000];  // 1000 is the maximum capacity of messages that the logger keeps
        } 
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