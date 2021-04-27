using System;

namespace MoodAnalyserProblem
{
   public class Program
   {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser:");
            MoodAnalyzer mood = new MoodAnalyzer();
            MoodAnalyzerFactory factory = new MoodAnalyzerFactory();
        }
    }
}
