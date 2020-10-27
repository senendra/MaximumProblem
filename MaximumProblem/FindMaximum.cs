using System;
using System.Collections.Generic;
using System.Text;
namespace MaximumProblem
{
    public class FindMaximum
    {

        public static int MaxValue(int firstNum, int secondNum, int thirdNum)
        {
            if (firstNum.CompareTo(secondNum) == 1 && firstNum.CompareTo(thirdNum) == 1 ||
                firstNum.CompareTo(secondNum) == 1 && firstNum.CompareTo(thirdNum) == 0 ||
                firstNum.CompareTo(secondNum) == 0 && firstNum.CompareTo(thirdNum) == 1)
            {
                return firstNum;
            }
            else if (secondNum.CompareTo(firstNum) == 1 && secondNum.CompareTo(thirdNum) == 1 ||
                     secondNum.CompareTo(firstNum) == 1 && secondNum.CompareTo(thirdNum) == 0 ||
                     secondNum.CompareTo(firstNum) == 0 && secondNum.CompareTo(thirdNum) == 1)
            {
                return secondNum;
            }
            else
            {
                return thirdNum;
            }
        }
        public static double MaxValue(double firstNum, double secondNum, double thirdNum)
        {
            if (firstNum.CompareTo(secondNum) == 1 && firstNum.CompareTo(thirdNum) == 1 ||
                firstNum.CompareTo(secondNum) == 1 && firstNum.CompareTo(thirdNum) == 0 ||
                firstNum.CompareTo(secondNum) == 0 && firstNum.CompareTo(thirdNum) == 1)
            {
                return firstNum;
            }
            else if (secondNum.CompareTo(firstNum) == 1 && secondNum.CompareTo(thirdNum) == 1 ||
                     secondNum.CompareTo(firstNum) == 1 && secondNum.CompareTo(thirdNum) == 0 ||
                     secondNum.CompareTo(firstNum) == 0 && secondNum.CompareTo(thirdNum) == 1)
            {
                return secondNum;
            }
            else
            {
                return thirdNum;
            }
        }
        public static string MaxValue(string first, string second, string third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0 ||
                first.CompareTo(second) > 0 && first.CompareTo(third) == 0 ||
                first.CompareTo(second) == 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0 ||
                     second.CompareTo(first) > 0 && second.CompareTo(third) == 0 ||
                     second.CompareTo(first) == 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else
            {
                return third;
            }
        }
    }
}
