using System;

namespace LessQuick {
    public class SyntaxException : Exception {

        public SyntaxException() {
        }

        public SyntaxException(string message) : base(message) {
        }
    }
}
