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
        /// It writes to the console all the messages from the  message array
        /// </summary>
        public void ReadAll() {
            //Message[] messagesArray = GetMessagesArray();
            //foreach (Message message in messagesArray) {
            //    Console.WriteLine(message?.ToString());  
            //};
        }
        /// <summary>
        /// It clears all the messages from the array, so the array length should be zero 
        /// </summary>
        public void Clear() {
            //Message[] messagesArray = GetMessagesArray();
            //int length = messagesArray.Length;  
            //Array.Clear(messagesArray, 0, length);
        }

        /// <summary>
        /// It writes the message given to the messages array 
        /// </summary>
        /// <param name="message"></param>
        public void Write(Message message) {
            //Message[] messagesArray= GetMessagesArray();
            //for (int i = 0; i < messagesArray.Length; i++) {  
            //    if (messagesArray[i] == null) {
            //        messagesArray[i] = message;
            //        break;
            //    }
            //}
                
         }

        // Help method to return Messages array because it was a property
        // It didn't feel right to use Message.Length
        //private Message[] GetMessagesArray() {
        //    return Messages;
        //}
           
    }
}