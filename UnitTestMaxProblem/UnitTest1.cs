using MaximumProblem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Dynamic;
namespace UnitTestMaxProblem
{
    [TestClass]
    public class UnitTest1
    {
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
