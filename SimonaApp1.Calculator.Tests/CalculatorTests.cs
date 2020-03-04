using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.bl.Tests
{
    [TestClass]
    public class CalculatorTests

    {
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(12, 30, 42)]
        [DataRow(14, 1, 15)]
        [DataRow(-1, 1, 0)]
        public void Sum_Using_DataRow(double a, double b, double expected)
        {
            Calculator calculator = new Calculator();
            var actual = calculator.Sum(a, b);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(1, 1, 0)]
        [DataRow(30, 10, 20)]
        [DataRow(14, 1, 13)]
        [DataRow(-1, 1, -2)]
        public void Minus_Using_DataRow(double a, double b, double expected)
        {
            Calculator calculator = new Calculator();
            var actual = calculator.Minus(a, b);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(30.5, 10, 3.05)]
        [DataRow(385, -7, -55)]
        [DataRow(-4.55, 2, -2.275)]
        public void Division_Using_DataRow(double a, double b, double expected)
        {
            Calculator calculator = new Calculator();
            var actual = calculator.Division(a, b);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(48.5, 0, 0)]
        [DataRow(-999, 99.9, -99800.1)]
        [DataRow(-0.55, -2, 1.1)]
        public void Multiplication_Using_DataRow(double a, double b, double expected)
        {
            Calculator calculator = new Calculator();
            var actual = calculator.Multiplication(a, b);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(2, 4)]
        [DataRow(-5, 25)]
        [DataRow(-999, 998001 )]
        [DataRow(0, 0)]
        public void Squaring_Using_DataRow(double a, double expected)
        {
            Calculator calculator = new Calculator();
            var actual = calculator.Squaring(a);
            Assert.AreEqual(expected, actual);
        }
    }

}



  //  {
        //[TestMethod]
        //public void Sum_10and20_30returned()
        //{
        //    // arrange

        //    double x = 10;
        //    double y = 20;
        //    double expected = 30;

        //    // act

        //    Calculator c = new Calculator();
        //    double actual = c.Sum(x, y);

            // assert

            //Assert.AreEqual(expected, actual);
     //   }

       // [TestMethod]
       // public void Minus_20and10_10returned()
       // {
            // arrange

            //double x = 20;
            //double y = 10;
           // double expected = 10;

            // act

            //Calculator c = new Calculator();
            //double actual = c.Minus(x, y);

            // assert

            //Assert.AreEqual(expected, actual);
    //    }
 //   }

//}
