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
        /// <summary>
        /// TC1.1Given sad mood should return sad
        /// </summary>
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

        /// <summary>
        /// TC1.2-Given happy mood should return happy 
        /// </summary>
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
        /// <summary>
        ///TC 2.1:- Given Null Mood Should Return Happy
        /// </summary>

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
        /// <summary>
        ///  TC 3.1:- NULL Given NULL Mood Should Throw MoodAnalysisException
        /// </summary>
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
        /// <summary>
        /// TC 3.2- Given Empty Mood Should Throw  MoodAnalysisException 
        /// </summary>

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
        /// <summary>
        ///TC 4.1:- Given MoodAnalyser Class Name Should Return MoodAnalyser Object
        /// </summary>
        [TestMethod]
        public void Given_MoodAnalyser_ClassName_ShouldReturn_MoodAnalyseObject()
        {
            object expected = new MoodAnalyzer("NULL");
            object obj = MoodAnalyzerFactory.CreateMoodAnalyseMethod("MoodAnalyzer.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }
        /// <summary>
        /// TC 4.2- Given Class Name When Improper Should Throw MoodAnalysisException
        /// </summary>

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
        /// <summary>
        ///TC 4.3- Given Class When Constructor Not Proper Should Throw MoodAnalysisException.
        /// </summary>

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
        /// <summary>
        ///TC 5.1:- Given MoodAnalyser When Proper Return MoodAnalyser Object.
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyser_WhenCorrect_Return_MoodAnalyseObject()
        {
            string message = "I am in happy mood";
            MoodAnalyzer expected = new MoodAnalyzer("I am in happy mood"); //Create object and arrange 
            object obj = null;

            try
            {
                MoodAnalyzerFactory factory = new MoodAnalyzerFactory();
                obj = factory.CreateMoodAnalyzerParameterObject("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer", message);
            }
            catch (Exception ex)
            {
               obj.Equals(expected);
            }
        }

        /// <summary>
        ///  TC 5.2- Given Class Name When Improper Should Throw MoodAnalysisException
        /// </summary>
        [TestMethod]
        public void GivenInvalidClassName_ShouldThrow_MoodAnalyserException_Of_ParameterisedConstructor()
        {
            string expected = "Class not found";
            try
            {
                object obj = MoodAnalyzerFactory.CreatedMoodAnalyserUsingParameterizedConstructor("MoodAnalyzer.sampleClass", "MoodAnalyser", "HAPPY");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }
        /// <summary>
        ///TC 5.3 Given Invalid constructor name should throw MoodAnalyserException
        /// </summary> 
        [TestMethod]
        public void GivenInvalidConstructorName_ShouldThrow_MoodAnalyserException_Of_ParameterizedConstructor()
        {
            string expected = "Constructor is not found";
            try
            {
                object obj = MoodAnalyzerFactory.CreatedMoodAnalyserUsingParameterizedConstructor("MoodAnalyzer.MoodAnalyser", "sampleClass", "HAPPY");
            }
            catch (Exception ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }
        /// <summary>
        /// TC6.1-Given Happy should return happy
        /// </summary>
        [TestMethod]
        public void Given_HappyMood_ShouldReturn_Happy()
        {
            string Message = "Happy";
            MoodAnalyzer expected = new MoodAnalyzer("I am in happy mood");
            object obj = null;
            try
            {
                MoodAnalyserFactory Factory = new MoodAnalyserFactory();
                obj = Factory.InvokeAnalyzerMethod(Message, "Analyzer");
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            obj.Equals(expected);
        }
        /// <summary>
        /// TC7.1-Set Happy Message with Reflector Should Return HAPPY
        /// </summary>
        [TestMethod]
        public void GivenMessageDynamically_returnMessage()
        {
            string expected = "Iam so happy";

            string actual = MoodAnalyzerFactory.SetField("Iam so happy", "message");
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        //TC 7.2- Set Field When Improper Should Throw Exception with No Such Field
        /// </summary>
        [TestMethod]
        public void GivenImproperFieldName_ThrowNoSuchFieldException()
        {

            string expected = "No Such Field";
            try
            {
                MoodAnalyzerFactory.SetField("Iam so happy", "wrongMessage");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }
        /// <summary>
        /// TC 7.3- Setting Null Message with Reflector Should Throw Exception
        /// </summary>

        [TestMethod]
        public void GivenNullMessage_ThrowException()
        {
            string expected = "Mood should not be NULL";

            try
            {
                MoodAnalyzerFactory.SetField(null, "message");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }
    }
       
}

       