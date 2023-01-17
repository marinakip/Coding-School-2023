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

        /// <summary>
        /// It returns the messages array with all the logs
        /// </summary>
        public Message[] ReadAll() { //should return Message[]
            return Messages;
        }
        /// <summary>
        /// It clears all the messages from the array, so the array length should be zero 
        /// </summary>
        public void Clear(out int messagesLength) {
            messagesLength = 0;  
        }
        public void Write(Message message) { }
    }
}