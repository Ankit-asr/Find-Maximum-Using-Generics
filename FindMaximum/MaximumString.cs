using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximum
{
    public class MaximumString
    {
        public static string CheckMaxString(string firstString, string secondString, string thirdString)
        {
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0)
                return firstString;
            if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0)
                return secondString;
            if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0)
                return thirdString;
            throw new Exception("firstString,secondString and thirdString all are same");
        }
    }
}