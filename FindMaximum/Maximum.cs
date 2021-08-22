﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximum
{
    public class Maximum<T> where T : IComparable
    {
        public T firstValue, secondValue, thirdValue;
        public Maximum(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }
        /// <summary>
        /// Display maximum Value of the given type 
        /// </summary>
        /// <returns></returns>
        public T MaximumValue()
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
                return firstValue;
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
                return secondValue;
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
                return thirdValue;
            return (default(T));
        }
    }
}