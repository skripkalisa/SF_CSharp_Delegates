using System;

namespace Task1
{
    public class CustomException : Exception
    {
        public CustomException (string message) 
            : base(message)
        {}   
    }
}