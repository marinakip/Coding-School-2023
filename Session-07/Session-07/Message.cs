namespace Session_07 {
    public class Message {

        // Properties
        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; } 
        public string? MessageText { get; set; }   //FIX: Renamed because of error CS0542: member names 
                                                   //     cannot be the same as their enclosing type
        // Constructors
        // public Message() {} // Unnessesary
        public Message(Guid id, DateTime date, string message) {
            ID = id;    
            TimeStamp = date;
            MessageText = message;
        }

    }




}