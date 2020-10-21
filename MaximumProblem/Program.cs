using System;
namespace MaximumProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Problem Program");
            int firstNum = 3, secondNum = 2, thirdNum = 10;
            Console.WriteLine("Maximum of " + firstNum + " , " + secondNum + " , " + thirdNum + " is : " + FindMaximum.MaxValue(firstNum, secondNum, thirdNum));
        }
    }
}
