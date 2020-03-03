using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.bl.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Sum_10and20_30returned()
        {
            // arrange

            int x = 10;
            int y = 20;
            int expected = 30;

            // act

            Calculator c = new Calculator();
            int actual = c.Sum(x, y);

            // assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Minus_20and10_10returned()
        {
            // arrange

            int x = 20;
            int y = 10;
            int expected = 10;

            // act

            Calculator c = new Calculator();
            int actual = c.Minus(x, y);

            // assert

            Assert.AreEqual(expected, actual);
        }
    }

}
