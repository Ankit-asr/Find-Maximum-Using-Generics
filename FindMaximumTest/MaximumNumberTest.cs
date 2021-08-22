using FindMaximum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindMaximumTest
{

    [TestClass]
    public class MaximumNumberTest
    {
        MaximumNumber max = new MaximumNumber();
        /// <summary>
        /// Test case 1.1
        /// </summary>
        [TestMethod]
        public void GivenMaxNumFirstPostion_WhenFindMaxNum_shouldReturnsMaxFirst()
        {
            double firstMax = max.MaximumFloatNumber(22.1, 1.64, 3.40);
            Assert.AreEqual(22.1, firstMax);

        }
        /// <summary>
        /// Test case 1.2
        /// <summary>
        [TestMethod]
        public void GivenMaxNumSecondPosition_WhenFindNum_ShouldReturnsMaxSecond()
        {
            double secondMax = max.MaximumFloatNumber(20.60, 50.45, 10.47);
            Assert.AreEqual(50.45, secondMax);
        }
        /// <summary>
        /// Test case 1.3
        /// <summary>
        [TestMethod]
        public void GivenMaxNumThirdPosition_WhenFindNum_ShouldReturnMaxThird()
        {
            double thirdMax = max.MaximumFloatNumber(1.54, 2.40, 3.36);
            Assert.AreEqual(3.36, thirdMax);
        }
    }
}