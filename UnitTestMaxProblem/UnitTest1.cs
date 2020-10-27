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
        [TestMethod]
        public void GetMaximumIntegerOutOfArray()
        {
            //Arrange 
            int[] intArray = { 10, 20, 30 };
            int expected = 30;
            GenericMaximum<int> find = new GenericMaximum<int>(intArray);
            //Act 
            int result = find.MaximumValue();
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetMaximumFloatOutOfArray()
        {
            //Arrange 
            float[] floatArray = { 10.1f, 20.2f, 30.3f };
            float expected = 30.3f;
            GenericMaximum<float> find = new GenericMaximum<float>(floatArray);
            //Act 
            float result = find.MaximumValue();
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void GetMaximumStringOutOfArray()
        {
            //Arrange 
            string[] stringArray = { "Apple", "Peace", "Banana" };
            string expected = "Peace";
            GenericMaximum<string> find = new GenericMaximum<string>(stringArray);
            //Act 
            string result = find.MaximumValue();
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
