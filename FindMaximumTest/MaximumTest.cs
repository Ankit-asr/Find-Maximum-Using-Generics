using FindMaximum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindMaximumTest
{

    [TestClass]
    public class MaximumTest
    {
        /// <summary>
        /// Test case 1.1
        /// </summary>
        [TestMethod]
        public void GivenMaxStringFirstPostion_WhenFindMaxString_shouldReturnsMaxFirst()
        {
            Maximum<string> findMaxString = new Maximum<string>("Apple", "Peach", "Banana");
            string firstMax = findMaxString.MaximumValue();
            Assert.AreEqual("Peach", firstMax);

        }
        /// <summary>
        /// Test case 1.2
        /// <summary>
        [TestMethod]
        public void GivenMaxIntSecondPosition_WhenFindInteger_ShouldReturnsMaxSecond()
        {
            Maximum<int> findMaxInteger = new Maximum<int>(12, 33, 23);
            int seconMax = findMaxInteger.MaximumValue();
            Assert.AreEqual(33, seconMax);
        }
        /// <summary>
        /// Test case 1.3
        /// <summary>
        [TestMethod]
        public void GivenMaxDoubleThirdPosition_WhenFindDouble_ShouldReturnMaxThird()
        {
            Maximum<double> findMaxDouble = new Maximum<double>(23.23, 44.12, 70.34);
            double thirdMax = findMaxDouble.MaximumValue();
            Assert.AreEqual(70.34, thirdMax);
        }
    }
}