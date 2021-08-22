using FindMaximum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindMaximumTest
{

    [TestClass]
    public class MaximumStringTest
    {
        /// <summary>
        /// Test case 1.1
        /// </summary>
        [TestMethod]
        public void GivenMaxStringFirstPostion_WhenFindMax_ShouldReturnMaxFirst()
        {
            string firstMax = MaximumString.CheckMaxString("Banana" ,"Apple", "Peach");
            Assert.AreEqual("Peach" , firstMax);
        }
        /// <summary>
        /// Test case 1.2
        /// <summary>
        [TestMethod]
        public void GivenMaxStringSecondPostion_WhenFindMax_ShouldReturnMaxSecond()
        {
            string secondMax = MaximumString.CheckMaxString("Apple", "Banana", "Peach");
            Assert.AreEqual("Peach", secondMax);
        }
       
        /// <summary>
        /// Test case 1.3
        /// <summary>
        [TestMethod]
        public void GivenMaxStringThirdPostion_WhenFindMax_ShouldReturnMaxFirst()
        {
            string thirdMax = MaximumString.CheckMaxString("Banana", "Apple", "Peach");
            Assert.AreEqual("Peach", thirdMax);
        }
    }
}