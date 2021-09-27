namespace exceptions {
    public class ArgumentException : System.Exception {
        public ArgumentException() : base() { }
        public ArgumentException(string message) : base(message) { }
        public ArgumentException(string message, System.Exception inner) : base(message, inner) { }
        protected ArgumentException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }    
}
