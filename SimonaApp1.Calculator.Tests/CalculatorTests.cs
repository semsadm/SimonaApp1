using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Moq;

namespace Calculator.bl.Tests
{
    [TestClass]
    public class CalculatorTests

    {
        
        [DataTestMethod]
        [DataRow(1, 1, 2,0)]
        [DataRow(12, 30, 42,1)]
        [DataRow(14, 1, 15,5)]
        [DataRow(-1, 1, 0,7)]
        public void Sum_Using_DataRow(double right, double left, double expected, int roundDigits)
        {
            var optionsMock = new Mock<IRoundStrategy>();
            optionsMock.Setup(t => t.RoundDigits).Returns(roundDigits);
            optionsMock.Setup(t => t.Rounding).Returns(MidpointRounding.AwayFromZero);

            Calculator calculator = new Calculator(optionsMock.Object);

            var actual = calculator.Sum(right, left);

            optionsMock.Verify(t => t.RoundDigits, Times.Once);


            Assert.AreEqual(expected, actual);


        }
    } 
}
