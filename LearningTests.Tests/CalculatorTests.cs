using NUnit.Framework;

namespace LearningTests.Tests
{
    public class CalculatorTests
    {
        [Test]
        public void Addup20Readmore30()
        {
            Assert.AreEqual(50, new Calculator().Add(20, 30));
        }

        [Test]
        public void Subtract30Less10ShouldSer20()
        {
            Assert.AreEqual(20, new Calculator().Subtract(30, 10));
        }

        [Test]
        public void Multiply20Times3MustBeSer60()
        {
            Assert.AreEqual(60, new Calculator().Multiply(20, 3));
        }

        [Test]
        public void Divide40Por4DustSer10()
        {
            Assert.AreEqual(10, new Calculator().Share(40, 4));
        }
    }
}