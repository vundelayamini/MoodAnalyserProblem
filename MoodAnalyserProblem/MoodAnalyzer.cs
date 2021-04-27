using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
    public class MoodAnalyzer
    {
        public string message;  //instance variable      


        public MoodAnalyzer(string message) //parameterized constructor 
        {
            this.message = message;

        }
        //UC2-Handling Exception
        public string Analyzer()  //Analyzer method find mood
        {
            try
            {
                if (this.message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch(NullReferenceException ex)
            {
                return ex.Message;
            }

        }


    }
}

