using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;

namespace MsTestForMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void GivenSadMood_ShouldReturnSAD()
        {
            //Arrange
            string expected = "sad";
            MoodAnalyzer obj = new MoodAnalyzer("I am in sad Mood");
            //Act
            string actual = obj.Analyzer();

            //Assert
            Assert.AreEqual(expected, actual);
        }

       
        [TestMethod]
        public void Given_Happymood_Expecting_Happy_Result()  
        {
            //Arrange
            MoodAnalyzer mood = new MoodAnalyzer("I am in happy mood");  //create object
            string expected = "happy";
            //Act
            string actual = mood.Analyzer();    
            //Assert
            Assert.AreEqual(expected, actual);  
        }
    }
}