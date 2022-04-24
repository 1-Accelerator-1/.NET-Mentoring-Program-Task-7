using System;

namespace Task_7.ValidationExceptions
{
    public class NumberOutOfRangeException : Exception
    {
        public NumberOutOfRangeException()
        {
        }

        public NumberOutOfRangeException(string message)
            : base(message)
        {
        }

        public NumberOutOfRangeException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
