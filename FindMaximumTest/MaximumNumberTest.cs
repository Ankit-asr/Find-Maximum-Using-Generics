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
            int firstMax = max.MaximumIntegerNumber(22, 1, 3);
            Assert.AreEqual(22, firstMax);

        }
        /// <summary>
        /// Test case 1.2
        /// <summery>
        [TestMethod]
        public void GivenMaxNumSecondPosition_WhenFindNum_ShouldReturnsMaxSecond()
        {
            int seconMax = max.MaximumIntegerNumber(20, 50, 10);
            Assert.AreEqual(50, seconMax);
        }
        /// <summary>
        /// Test case 1.3
        /// <summery>
        [TestMethod]
        public void GivenMaxNumThirdPosition_WhenFindNum_ShouldReturnMaxThird()
        {
            int thirdMax = max.MaximumIntegerNumber(1, 2, 3);
            Assert.AreEqual(3, thirdMax);
        }
    }
}