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
    }
}
