using MaximumProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
