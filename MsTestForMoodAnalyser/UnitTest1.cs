using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;
using System;

namespace MsTestForMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        private object MoodAnalyserFactory;

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
        //UC2-Handle Exception if user provides invalid mood
        [TestMethod]
        public void Given_Nullmood_Expecting_Exception_Result()
        {
            //Arrange
            MoodAnalyzer mood = new MoodAnalyzer(null);
            string expected = "Object reference not set to an instance of an object.";

            //Act
            string actual = mood.Analyzer();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        //TC 2.1:- Given Null Mood Should Return Happy.

        [TestMethod]
        public void Given_Nullmood_Expecting_happy_Result()
        {
            //Arrange
            MoodAnalyzer mood = new MoodAnalyzer(null); //Create object
            string expected = "happy";
            //Act
            string actual = mood.Analyzer();
            //Assert
            Assert.AreEqual(expected, actual);


        }
        // TC 3.1:- NULL Given NULL Mood Should Throw MoodAnalysisException
        [TestMethod]
        public void Given_Nullmood_Using_CustomExpection_Return_Null()
        {
            //Arrange
            MoodAnalyzer mood = new MoodAnalyzer(null); //Create object  
            string actual = "";
            try
            {
                //Act
                actual = mood.Analyzer();

            }
            catch (Exception ex)
            {
                //Assert
                Assert.AreEqual("Mood should not be null", ex.Message);
            }
        }

        // TC 3.2- Given Empty Mood Should Throw  MoodAnalysisException 

        [TestMethod]

        public void GivenMood_IfEmpty_ShouldThrowException()
        {
            string actual = "";

            try
            {
                //Arrange
                string message = string.Empty;
                MoodAnalyzer mood = new MoodAnalyzer(message); //Create object 
                //Act
                actual = mood.Analyzer();

            }
            catch (Exception ex)
            {
                //Assert
                Assert.AreEqual("Mood should not be empty", ex.Message);
            }
        }
        //TC 4.1:- Given MoodAnalyser Class Name Should Return MoodAnalyser Object
        [TestMethod]
        public void Given_MoodAnalyser_ClassName_ShouldReturn_MoodAnalyseObject()
        {
            object expected = new MoodAnalyzer("NULL");
            object obj = MoodAnalyzerFactory.CreateMoodAnalyseMethod("MoodAnalyzer.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }

        //TC 4.2- Given Class Name When Improper Should Throw MoodAnalysisException

        [TestMethod]
        public void GivenInvalidClassName_ShouldThrow_MoodAnalyserException()
        {
            string expected = "Class not Found";
            try
            {
                object obj = MoodAnalyzerFactory.CreateMoodAnalyseMethod("MoodAnalyser.sampleClass", "MoodAnalyser");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        //TC 4.3- Given Class When Constructor Not Proper Should Throw MoodAnalysisException.

        [TestMethod]
        public void GivenClass_WhenNotProper_Constructor_ShouldThrow_MoodAnalyserException()
        {
            string expected = "Constructor is not Found";
            try
            {
                object obj = MoodAnalyzerFactory.CreateMoodAnalyzerMethod("MoodAnalyserProblem.MoodAnalyzer ", "MoodAnalyzer");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}

       