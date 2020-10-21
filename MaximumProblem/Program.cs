using System;
namespace MaximumProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Problem Program");
            int intfirstNum = 3, intsecondNum = 2, intthirdNum = 10;
            Console.WriteLine("Maximum of " + intfirstNum + " , " + intsecondNum + " , " + intthirdNum + " is : " + FindMaximum.MaxValue(intfirstNum, intsecondNum, intthirdNum));
            double doubleFirstNum = 3.3, doubleSecondNum = 2.2, doubleThirdNum = 1.1;
            Console.WriteLine("Maximum of " + doubleFirstNum + " , " + doubleSecondNum + " , " + doubleThirdNum + " is : " + FindMaximum.MaxValue(doubleFirstNum, doubleSecondNum, doubleThirdNum));
        }
    }
}
