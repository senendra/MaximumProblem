using MaximumProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Dynamic;

namespace UnitTestMaxProblem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetFirstPositionIntegerMaximumOutOfThree()
        {
            //Arrange 
            int firstNum = 10, secondNum = 5, thirdNum = 3;
            int expected = firstNum;
            //Act 
            int result = FindMaximum.MaxValue(firstNum, secondNum, thirdNum);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetSecondPositionIntegerMaximumOutOfThree()
        {
            //Arrange 
            int firstNum = 10, secondNum = 15, thirdNum = 3;
            int expected = secondNum;
            //Act 
            int result = FindMaximum.MaxValue(firstNum, secondNum, thirdNum);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetThirdPositionIntegerMaximumOutOfThree()
        {
            //Arrange 
            int firstNum = 10, secondNum = 15, thirdNum = 30;
            int expected = thirdNum;
            //Act 
            int result = FindMaximum.MaxValue(firstNum, secondNum, thirdNum);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetFirstPositionDoubleMaximumOutOfThree()
        {
            //Arrange 
            double firstNum = 10.1, secondNum = 2.2, thirdNum = 3.3;
            double expected = firstNum;
            //Act 
            double result = FindMaximum.MaxValue(firstNum, secondNum, thirdNum);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetSecondPositionDoubleMaximumOutOfThree()
        {
            //Arrange 
            double firstNum = 10.1, secondNum = 22.2, thirdNum = 3.3;
            double expected = secondNum;
            //Act 
            double result = FindMaximum.MaxValue(firstNum, secondNum, thirdNum);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetThirdPositionDoubleMaximumOutOfThree()
        {
            //Arrange 
            double firstNum = 10.1, secondNum = 22.2, thirdNum = 33.3;
            double expected = thirdNum;
            //Act 
            double result = FindMaximum.MaxValue(firstNum, secondNum, thirdNum);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetFirstPositionStringMaximumOutOfThree()
        {
            //Arrange 
            string first = "Peace", second = "Apple", third = "Banana";
            string expected = first;
            //Act 
            string result = FindMaximum.MaxValue(first, second, third);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetSecondPositionStringMaximumOutOfThree()
        {
            //Arrange 
            string first = "Apple", second = "Peace", third = "Banana";
            string expected = second;
            //Act 
            string result = FindMaximum.MaxValue(first, second, third);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetThirdPositionStringMaximumOutOfThree()
        {
            //Arrange 
            string first = "Apple", second = "Banana", third = "Peace";
            string expected = third;
            //Act 
            string result = FindMaximum.MaxValue(first, second, third);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
