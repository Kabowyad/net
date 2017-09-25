using System;

namespace ConsoleApplication.exception{
    public class CandyException: ApplicationException
    {
        public CandyException() { }

        public CandyException(string message) : base(message) { }

        public CandyException(string message, Exception inner) : base(message, inner) { }
    }
}