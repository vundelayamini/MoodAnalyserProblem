using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
    class MoodAnalyzerException:Exception
    {
        ExceptionType type;  //Create instance of custom exception type
        public string message;

        public enum ExceptionType  
        {
            NULL_EXCEPTION, EMPTY_EXCEPTION,
            CLASS_NOT_FOUND,
            CONSTRUCTOR_NOT_FOUND
        }
        public MoodAnalyzerException(ExceptionType type, string message) : base(message)  //parameterized constructor and also using bsae method
        {
            this.type = type;
        }
    }
}
