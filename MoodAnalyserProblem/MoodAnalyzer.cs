using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
    public class MoodAnalyzer
    {
        public string message;  //instance variable      

        public MoodAnalyzer()
        {
        }

        public MoodAnalyzer(string message) //parameterized constructor 
        {
            this.message = message;

        }
        //UC2-Handling Exception
        public string Analyzer()  //Analyzer method find mood
        {
            try
            {
                 //UC 3 Inform user if he entered Invalid Mood

                if (this.message.Equals(string.Empty))
                {

                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.EMPTY_EXCEPTION, "Mood should not be empty");
                }
                if (this.message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }

            catch (NullReferenceException ex)
            {
                return ex.Message;
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NULL_EXCEPTION, "Mood should not be null");
            }

        }


    }
}

