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
        public string Analyzer()  //Analyzer method find mood
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


    }
}

